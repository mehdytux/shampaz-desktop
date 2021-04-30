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
    public partial class PersonsSalesAggregationForm : DevComponents.DotNetBar.Office2007Form
    {
        public PersonsSalesAggregationForm()
        {
            InitializeComponent();
        }

        private void SellFactorList_Load(object sender, EventArgs e)
        {
            pDateFrom.GeorgianDate = DateTime.Now;
            pDateTo.GeorgianDate = DateTime.Now;
            //dgvFactorsRefresh();
        }

        private void dgvFactorsRefresh()
        {
            dgvFactors.Rows.Clear();

            var db = new shampazEntities();

            var to = pDateTo.GeorgianDate + new TimeSpan(23, 59, 59);
            var query = from item in db.SellFactorItems
                        join f in db.SellFactors on item.SellFactorId equals f.Id
                        where f.Date >= pDateFrom.GeorgianDate && f.Date <= to
                        select new
                        {
                            f.PersonId,
                            f.Person,
                            Quantity = item.Numbers,
                            item.TotalPrice
                        };

            var items = (
                    from item in query
                    group item by item.PersonId into g
                    select new
                    {
                        PersonId = g.Key,
                        PersonName = g.Select(p => p.Person).FirstOrDefault().Name,
                        Quantity = g.Select(q => q.Quantity).Sum(),
                        TotalPrice = g.Select(t => t.TotalPrice).Sum()
                    }
                ).ToList();

            int itemsCount = 0;
            decimal totalPrice = 0;
            foreach (var item in items)
            {
                dgvFactors.Rows.Add(item.PersonId, item.PersonName, item.Quantity, item.TotalPrice.ToString("#,#"));
                itemsCount += item.Quantity;
                totalPrice += item.TotalPrice;
            }

            txtSumNumbers.Text = itemsCount.ToString("#,#");
            txtSumPrice.Text = totalPrice.ToString("#,#");
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dgvFactorsRefresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new SellFactorForm();
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

        private void dgvFactors_SelectionChanged(object sender, EventArgs e)
        {
            int itemsCount = 0;
            decimal totalPrice = 0;

            if(dgvFactors.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow row in dgvFactors.SelectedRows)
                {
                    itemsCount += Convert.ToInt32(row.Cells["clnNumbers"].Value);
                    totalPrice += Convert.ToDecimal(row.Cells["clnTotalPrice"].Value);
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvFactors.Rows)
                {
                    itemsCount += Convert.ToInt32(row.Cells["clnNumbers"].Value);
                    totalPrice += Convert.ToDecimal(row.Cells["clnTotalPrice"].Value);
                }
            }

            txtSumNumbers.Text = itemsCount.ToString("#,#");
            txtSumPrice.Text = totalPrice.ToString("#,#");
        }

        private void dgvFactors_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Name == "clnTotalPrice")
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
