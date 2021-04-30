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
    public partial class BuyFactorAddForm : DevComponents.DotNetBar.Office2007Form
    {
        public Person SelectedPerson { get; set; }
        public bool EditMode { get; set; }
        public BuyFactor EditedFactor { get; set; }

        public BuyFactorAddForm()
        {
            InitializeComponent();
        }

        private void SellFactorForm_Load(object sender, EventArgs e)
        {
            var db = new shampazEntities();

            if (EditedFactor == null)
            {
                pdpDate.GeorgianDate = DateTime.Now;
                SelectedPerson = db.Persons.FirstOrDefault();
                calculateAndSetTotalPrice();
            }
            else
            {
                SelectedPerson = EditedFactor.Person;
                pdpDate.GeorgianDate = EditedFactor.Date;
                lblFactorId.Text = EditedFactor.Id.ToString();
                txtDescription.Text = EditedFactor.Description;
                txtTotalPrice.Text = EditedFactor.TotalPrice.ToString("#,#");
                txtPayment.Text = EditedFactor.PaymentPrice.ToString("#,#");

                foreach (var item in EditedFactor.BuyFactorItems)
                {
                    dgvItems.Rows.Add(item.Product.Id, item.Product.Name, item.Price, item.Quantity, item.TotalPrice);
                }
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
                    var number = Convert.ToDouble(r.Cells["clnNumber"].Value) + 1;
                    r.Cells["clnNumber"].Value = number;

                    var totalPrice = Convert.ToDecimal(number) * product.Price;
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
        }

        private decimal calculateTotalPrice()
        {
            decimal totalPrice = 0;

            foreach(DataGridViewRow r in dgvItems.Rows)
            {
                decimal price = Convert.ToDecimal(r.Cells["clnProductPrice"].Value);
                double number = Convert.ToDouble(r.Cells["clnNumber"].Value);
                totalPrice += Convert.ToDecimal(number) * price;
            }

            return totalPrice;
        }

        private void dgvItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            double number = Convert.ToDouble(dgvItems.Rows[e.RowIndex].Cells["clnNumber"].Value);
            decimal price = Convert.ToDecimal(dgvItems.Rows[e.RowIndex].Cells["clnProductPrice"].Value);
            dgvItems.Rows[e.RowIndex].Cells["clnTotalPrice"].Value = Convert.ToDecimal(number) * price;

            calculateAndSetTotalPrice();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(EditedFactor == null)
            {
                save();
            }
            else
            {
                update();
            }
        }

        private void save()
        {
            var db = new shampazEntities();

            var factor = new BuyFactor
            {
                Date = (DateTime)pdpDate.GeorgianDate,
                PersonId = SelectedPerson.Id,
                TotalPrice = Convert.ToDecimal(txtTotalPrice.Text),
                Description = txtDescription.Text,
                PaymentPrice = Convert.ToDecimal(txtPayment.Text)
            };

            db.BuyFactors.Add(factor);

            foreach (DataGridViewRow r in dgvItems.Rows)
            {
                var ProductId = Convert.ToInt32(r.Cells["clnProductId"].Value);

                factor.BuyFactorItems.Add(
                    new BuyFactorItem
                    {
                        Name = r.Cells["clnProductName"].Value.ToString(),
                        Quantity = Convert.ToDouble(r.Cells["clnNumber"].Value),
                        Price = Convert.ToDecimal(r.Cells["clnProductPrice"].Value),
                        ProductId = Convert.ToInt32(r.Cells["clnProductId"].Value),
                        TotalPrice = Convert.ToDecimal(r.Cells["clnTotalPrice"].Value),
                    }
                );
            }

            db.SaveChanges();
            DesktopAlert.Show("فاکتور ذخیره شد", eDesktopAlertColor.Green, eAlertPosition.BottomRight);
            EditedFactor = factor;
        }

        private void update()
        {
            var db = new shampazEntities();
            var factor = db.BuyFactors.Where(x => x.Id == EditedFactor.Id).FirstOrDefault();
            factor.Date = (DateTime)pdpDate.GeorgianDate;
            factor.PersonId = SelectedPerson.Id;
            factor.TotalPrice = Convert.ToDecimal(txtTotalPrice.Text);
            factor.Description = txtDescription.Text;
            factor.PaymentPrice = Convert.ToDecimal(txtPayment.Text);

            //MessageBox.Show(factor.Id.ToString());
            db.BuyFactorItems.RemoveRange(factor.BuyFactorItems);

            //foreach( var item in factor.SellFactorItems )
            //{
            //    db.SellFactorItems.Remove(item);
            //    db.SaveChanges();
            //}

            foreach (DataGridViewRow r in dgvItems.Rows)
            {
                factor.BuyFactorItems.Add(
                    new BuyFactorItem
                    {
                        Name = r.Cells["clnProductName"].Value.ToString(),
                        Quantity = Convert.ToDouble(r.Cells["clnNumber"].Value),
                        Price = Convert.ToDecimal(r.Cells["clnProductPrice"].Value),
                        ProductId = Convert.ToInt32(r.Cells["clnProductId"].Value),
                        TotalPrice = Convert.ToDecimal(r.Cells["clnTotalPrice"].Value)
                    }
                );
            }

            db.SaveChanges();
            DesktopAlert.Show("فاکتور بروزرسانی شد", eDesktopAlertColor.Green, eAlertPosition.BottomRight);
            EditedFactor = factor;
        }

        private void btnSaveAndClose_Click(object sender, EventArgs e)
        {
            btnSave.PerformClick();
            Close();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            btnSave.PerformClick();
            DialogResult = DialogResult.Retry;
            Close();
            Dispose();
            new BuyFactorAddForm().ShowDialog();
        }

        private void btnProductRemove_Click(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count == 0)
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
