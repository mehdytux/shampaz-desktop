using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shampaz
{
    public partial class SellFactorForm : DevComponents.DotNetBar.Office2007Form
    {
        public Person SelectedPerson { get; set; }
        public bool EditMode { get; set; }
        public SellFactor EditedSellFactor { get; set; }

        public SellFactorForm()
        {
            InitializeComponent();
        }

        private void SellFactorForm_Load(object sender, EventArgs e)
        {
            var db = new shampazEntities();

            if (EditedSellFactor == null)
            {
                pdpDate.GeorgianDate = DateTime.Now;
                SelectedPerson = db.Persons.FirstOrDefault();
                calculateAndSetTotalPrice();
            }
            else
            {
                SelectedPerson = EditedSellFactor.Person;
                pdpDate.GeorgianDate = EditedSellFactor.Date;
                lblFactorId.Text = EditedSellFactor.Id.ToString();
                txtDescription.Text = EditedSellFactor.Description;
                txtTotalPrice.Text = EditedSellFactor.TotalPrice.ToString("#,#");
                dtpTime.Value = EditedSellFactor.Date;

                foreach (var item in EditedSellFactor.SellFactorItems)
                {
                    dgvItems.Rows.Add(item.Product.Id, item.Product.Name, item.Price, item.Numbers, item.TotalPrice);
                }

                btnPrint.Enabled = true;
                btnKitchenReceipt.Enabled = true;
            }

            btnPerson.Text = SelectedPerson.Name;
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            var form = new PersonsForm();
            form.SelectMode = true;
            form.ShowDialog();

            if(form.DialogResult == DialogResult.OK)
            {
                SelectedPerson = form.SelectedPerson;
                btnPerson.Text = SelectedPerson.Name;
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var form = new ProductsForm();
            form.SelectMode = true;
            form.ShowDialog();

            if (form.DialogResult != DialogResult.OK)
            {
                return;
            }

            addProduct(form.SelectedProduct);
        }

        private void addProduct(Product product)
        {
            bool itemExists = false;
            // check product is exists
            foreach (DataGridViewRow r in dgvItems.Rows)
            {
                // is product exists
                if (r.Cells["clnProductId"].Value.ToString() == product.Id.ToString())
                {
                    var number = Convert.ToInt32(r.Cells["clnNumber"].Value) + 1;
                    r.Cells["clnNumber"].Value = number;

                    var totalPrice = number * product.Price;
                    r.Cells["clnTotalPrice"].Value = totalPrice;
                    itemExists = true;
                }
            }

            if (!itemExists)
            {
                dgvItems.Rows.Add(product.Id, product.Name, product.Price, 1, product.Price);
            }

            calculateAndSetTotalPrice();
        }

        private void calculateAndSetTotalPrice()
        {
            txtTotalPrice.Text = calculateTotalPrice().ToString("#,#");
            if(EditedSellFactor != null)
            {
                lblPriceDiff.Text = (calculateTotalPrice() - EditedSellFactor.TotalPrice).ToString("#,#");
            }
        }

        private decimal calculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach(DataGridViewRow r in dgvItems.Rows)
            {
                decimal price = Convert.ToDecimal(r.Cells["clnProductPrice"].Value);
                int number = Convert.ToInt32(r.Cells["clnNumber"].Value);
                totalPrice += number * price;
            }

            return totalPrice;
        }

        private void dgvItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int number = Convert.ToInt32(dgvItems.Rows[e.RowIndex].Cells["clnNumber"].Value);
            decimal price = Convert.ToDecimal(dgvItems.Rows[e.RowIndex].Cells["clnProductPrice"].Value);
            dgvItems.Rows[e.RowIndex].Cells["clnTotalPrice"].Value = number * price;

            calculateAndSetTotalPrice();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var data = new List<ReportRow>();

            foreach(var item in EditedSellFactor.SellFactorItems)
            {
                PersianCalendar pc = new PersianCalendar();
                string pDate = string.Format("{0}/{1}/{2}", pc.GetYear(EditedSellFactor.Date), pc.GetMonth(EditedSellFactor.Date), pc.GetDayOfMonth(EditedSellFactor.Date));

                data.Add(
                    new ReportRow
                    {
                        FactorDate = pDate,
                        FactorId = Convert.ToInt32(EditedSellFactor.Id),
                        FactorTotalPrice = EditedSellFactor.TotalPrice.ToString("#,#"),
                        ItemName = item.Name,
                        itemPrice = item.Price.ToString("#,#"),
                        ItemQuantity = item.Numbers,
                        ItemTotalPrice = item.TotalPrice.ToString("#,#"),
                        PersonAddress = SelectedPerson.Address,
                        PersonMobile = SelectedPerson.Mobile,
                        PersonName = SelectedPerson.Name,
                        Description = txtDescription.Text
                    }
                );
            }

            var form = new SellFactorPrintForm( data );
            form.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(EditedSellFactor == null)
            {
                save();
            }
            else
            {
                update();
            }

            btnPrint.Enabled = true;
            btnKitchenReceipt.Enabled = true;
        }

        private void save()
        {
            var db = new shampazEntities();

            var factor = new SellFactor
            {
                Date = (DateTime)pdpDate.GeorgianDate + dtpTime.Value.TimeOfDay,
                PersonId = SelectedPerson.Id,
                TotalPrice = Convert.ToDecimal(txtTotalPrice.Text),
                Description = txtDescription.Text
            };

            db.SellFactors.Add(factor);

            foreach (DataGridViewRow r in dgvItems.Rows)
            {
                factor.SellFactorItems.Add(
                    new SellFactorItem
                    {
                        Name = r.Cells["clnProductName"].Value.ToString(),
                        Numbers = Convert.ToInt32(r.Cells["clnNumber"].Value),
                        Price = Convert.ToDecimal(r.Cells["clnProductPrice"].Value),
                        ProductId = Convert.ToInt32(r.Cells["clnProductId"].Value),
                        TotalPrice = Convert.ToDecimal(r.Cells["clnTotalPrice"].Value),
                    }
                );
            }

            db.SaveChanges();
            DesktopAlert.Show("فاکتور ذخیره شد", eDesktopAlertColor.Green, eAlertPosition.BottomRight);
            EditedSellFactor = factor;
        }

        private void update()
        {
            var db = new shampazEntities();
            var factor = db.SellFactors.Where(x => x.Id == EditedSellFactor.Id).FirstOrDefault();
            factor.Date = (DateTime)pdpDate.GeorgianDate + dtpTime.Value.TimeOfDay;
            factor.PersonId = SelectedPerson.Id;
            factor.TotalPrice = Convert.ToDecimal(txtTotalPrice.Text);
            factor.Description = txtDescription.Text;
            //MessageBox.Show(factor.Id.ToString());
            db.SellFactorItems.RemoveRange(factor.SellFactorItems);

            //foreach( var item in factor.SellFactorItems )
            //{
            //    db.SellFactorItems.Remove(item);
            //    db.SaveChanges();
            //}

            foreach (DataGridViewRow r in dgvItems.Rows)
            {
                factor.SellFactorItems.Add(
                    new SellFactorItem
                    {
                        Name = r.Cells["clnProductName"].Value.ToString(),
                        Numbers = Convert.ToInt32(r.Cells["clnNumber"].Value),
                        Price = Convert.ToDecimal(r.Cells["clnProductPrice"].Value),
                        ProductId = Convert.ToInt32(r.Cells["clnProductId"].Value),
                        TotalPrice = Convert.ToDecimal(r.Cells["clnTotalPrice"].Value)
                    }
                );
            }

            db.SaveChanges();
            DesktopAlert.Show("فاکتور بروزرسانی شد", eDesktopAlertColor.Green, eAlertPosition.BottomRight);
            EditedSellFactor = factor;
        }

        private void btnSaveAndClose_Click(object sender, EventArgs e)
        {
            btnSave.PerformClick();
            Close();
        }

        private void btnKitchenReceipt_Click(object sender, EventArgs e)
        {
            var data = new List<ReportRow>();

            foreach (var item in EditedSellFactor.SellFactorItems)
            {
                PersianCalendar pc = new PersianCalendar();
                string pDate = string.Format("{0}/{1}/{2}", pc.GetYear(EditedSellFactor.Date), pc.GetMonth(EditedSellFactor.Date), pc.GetDayOfMonth(EditedSellFactor.Date));

                data.Add(
                    new ReportRow
                    {
                        FactorDate = pDate,
                        FactorId = Convert.ToInt32(EditedSellFactor.Id),
                        FactorTotalPrice = EditedSellFactor.TotalPrice.ToString("#,#"),
                        ItemName = item.Name,
                        itemPrice = item.Price.ToString("#,#"),
                        ItemQuantity = item.Numbers,
                        ItemTotalPrice = item.TotalPrice.ToString("#,#"),
                        PersonAddress = SelectedPerson.Address,
                        PersonMobile = SelectedPerson.Mobile,
                        PersonName = SelectedPerson.Name,
                        Description = txtDescription.Text
                    }
                );
            }

            var form = new SellFactorKitchenReportForm(data);
            form.ShowDialog();
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            btnSave.PerformClick();
            DialogResult = DialogResult.Retry;
            Close();
            Dispose();
            new SellFactorForm().ShowDialog();
        }

        private void btnProductRemove_Click(object sender, EventArgs e)
        {
            if(dgvItems.SelectedRows.Count == 0)
            {
                return;
            }

            foreach (DataGridViewRow item in dgvItems.SelectedRows)
            {
                dgvItems.Rows.RemoveAt(item.Index);
            }

            calculateAndSetTotalPrice();
        }
    }
}
