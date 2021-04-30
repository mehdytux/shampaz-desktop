using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class BuyFactorList : DevComponents.DotNetBar.Office2007Form
    {
        public BuyFactorList()
        {
            InitializeComponent();
        }

        private void SellFactorList_Load(object sender, EventArgs e)
        {
            pDateFrom.GeorgianDate = DateTime.Now;
            pDateTo.GeorgianDate = DateTime.Now;

            var items = new List<KeyValuePair<string, string>>();
            items.Add(new KeyValuePair<string,string>("all", "همه"));
            items.Add(new KeyValuePair<string,string>("bihesab", "بی حساب"));
            items.Add(new KeyValuePair<string,string>("bestankar", "بستاتکار"));
            items.Add(new KeyValuePair<string,string>("bedehkar", "بدهکار"));
            cmbStatus.DataSource = items;
            cmbStatus.DisplayMember = "Value";
            cmbStatus.ValueMember = "Key";

            dgvFactorsRefresh();
        }

        private void dgvFactorsRefresh()
        {
            dgvFactors.Rows.Clear();

            var db = new shampazEntities();
            var to = pDateTo.GeorgianDate + new TimeSpan(23, 59, 59);
            var factorsQuery = db.BuyFactors.Where(x => x.Date >= pDateFrom.GeorgianDate && x.Date <= to);
            //MessageBox.Show(cmbStatus.SelectedValue.ToString());
            switch (cmbStatus.SelectedValue.ToString())
            {
                case "bihesab":
                    factorsQuery = factorsQuery.Where(x => x.TotalPrice == x.PaymentPrice);
                    break;
                case "bestankar":
                    factorsQuery = factorsQuery.Where(x => x.TotalPrice > x.PaymentPrice);
                    break;
                case "bedehkar":
                    factorsQuery = factorsQuery.Where(x => x.TotalPrice < x.PaymentPrice);
                    break;
            }

            var factors = factorsQuery.ToList();

            txtFactorsCount.Text = factors.Count.ToString("#,#");

            double itemsCount = 0;
            decimal totalPrice = 0;
            foreach(var factor in factors)
            {
                PersianCalendar pc = new PersianCalendar();
                string pDate = string.Format("{0}/{1}/{2}", pc.GetYear(factor.Date), pc.GetMonth(factor.Date), pc.GetDayOfMonth(factor.Date));

                var numbers = factor.BuyFactorItems.Sum(x => x.Quantity);

                // Status
                string status;
                if(factor.TotalPrice < factor.PaymentPrice)
                {
                    status = "بدهکار";
                }
                else if (factor.TotalPrice > factor.PaymentPrice)
                {
                    status = "بستانکار";
                }
                else
                {
                    status = "بی حساب";
                }

                var remaining = factor.TotalPrice - factor.PaymentPrice;

                dgvFactors.Rows.Add(
                    factor.Id, pDate,
                    factor.Person.Name,
                    numbers,
                    factor.TotalPrice.ToString("#,#"),
                    factor.PaymentPrice.ToString("#,#"),
                    status,
                    remaining.ToString("#,#")
                );

                itemsCount += numbers;
                totalPrice += factor.TotalPrice;
            }

            txtFactorItemsCount.Text = itemsCount.ToString("#,#");
            txtFactorsTotalPrice.Text = totalPrice.ToString("#,#");

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dgvFactorsRefresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new BuyFactorAddForm();
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                dgvFactorsRefresh();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dgvFactors.SelectedRows.Count == 0)
            {
                return;
            }

            var id = Convert.ToInt32(dgvFactors.SelectedRows[0].Cells["clnId"].Value);
            var db = new shampazEntities();
            var form = new BuyFactorAddForm();
            form.EditedFactor = db.BuyFactors.Where(x => x.Id == id).FirstOrDefault();
            form.ShowDialog();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvFactors.SelectedRows.Count == 0)
            {
                return;
            }

            var result = MessageBox.Show("آیا مطئن هستید?", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.No)
            {
                return;
            }

            var db = new shampazEntities();
            foreach(DataGridViewRow row in dgvFactors.SelectedRows)
            {
                var id = Convert.ToInt32(row.Cells["clnId"].Value);
                var factor = db.BuyFactors.Where(x => x.Id == id).FirstOrDefault();
                var items = db.BuyFactorItems.Where(x => x.BuyFactorId == factor.Id).ToList();
                db.BuyFactorItems.RemoveRange(items);
                db.BuyFactors.Remove(factor);
            }

            db.SaveChanges();
            DesktopAlert.Show("فاکتور حذف شد", eDesktopAlertColor.Green, eAlertPosition.BottomRight);

            btnFilter.PerformClick();
        }

        private void deleteFactor(SellFactor factor)
        {
            var db = new shampazEntities();
            
            db.SaveChanges();
        }

        private void dgvFactors_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Name == "clnTotalPrice" || e.Column.Name == "clnPaymentPrice" )
            {
                e.SortResult = System.Decimal.Compare(
                    Convert.ToDecimal(e.CellValue1.ToString()),
                    Convert.ToDecimal(e.CellValue2.ToString())
                );

                e.Handled = true;
            }
        }
    }
}
