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
    public partial class SellFactorList : DevComponents.DotNetBar.Office2007Form
    {
        public SellFactorList()
        {
            InitializeComponent();

            pDateFrom.GeorgianDate = DateTime.Now;
            pDateTo.GeorgianDate = DateTime.Now;
        }

        private void SellFactorList_Load(object sender, EventArgs e)
        {
            dgvFactorsRefresh();
        }

        private void dgvFactorsRefresh()
        {
            dgvFactors.Rows.Clear();

            var db = new shampazEntities();
            var to = pDateTo.GeorgianDate + new TimeSpan(23, 59, 59);
            var factors = db.SellFactors.Where(x => x.Date >= pDateFrom.GeorgianDate && x.Date <= to).ToList();

            txtFactorsCount.Text = factors.Count.ToString("#,#");

            var itemsCount = 0;
            decimal totalPrice = 0;
            foreach(var factor in factors)
            {
                PersianCalendar pc = new PersianCalendar();
                string pDate = string.Format("{0}/{1}/{2}", pc.GetYear(factor.Date), pc.GetMonth(factor.Date), pc.GetDayOfMonth(factor.Date));
                string pTime = string.Format("{0}:{1}", pc.GetHour(factor.Date), pc.GetMinute(factor.Date));

                var numbers = factor.SellFactorItems.Sum(x => x.Numbers);
                dgvFactors.Rows.Add(factor.Id, pDate, pTime, factor.Person.Name, numbers, factor.TotalPrice.ToString("#,#"));

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
            SellFactorForm form = new SellFactorForm();
            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK)
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
            var form = new SellFactorForm();
            form.EditedSellFactor = db.SellFactors.Where(x => x.Id == id).FirstOrDefault();
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
                var factor = db.SellFactors.Where(x => x.Id == id).FirstOrDefault();
                var items = db.SellFactorItems.Where(x => x.SellFactorId == factor.Id).ToList();
                db.SellFactorItems.RemoveRange(items);
                db.SellFactors.Remove(factor);
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
            if(e.Column.Name == "clnTotalPrice")
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
