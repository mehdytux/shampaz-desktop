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
    public partial class ProductsSalesSumProfitForm : DevComponents.DotNetBar.Office2007Form
    {
        public ProductsSalesSumProfitForm()
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

            var items = from item in db.SellFactorItems
                        join f in db.SellFactors on item.SellFactorId equals f.Id
                        where f.Date >= pDateFrom.GeorgianDate && f.Date <= to
                        group item by item.ProductId into g
                        select new
                        {
                            ProductId = g.Key,
                            ProductName = g.Select(n => n.Product).FirstOrDefault().Name,
                            ProductProfit = g.Select(t => t.Product).FirstOrDefault().Profit,
                            Quantity = g.Select(q => q.Numbers).Sum()
                        };

            int itemsCount = 0;
            decimal totalProfit = 0;

            foreach (var item in items)
            {
                dgvFactors.Rows.Add(item.ProductId, item.ProductName, item.Quantity, item.ProductProfit, item.Quantity * item.ProductProfit);
                itemsCount += item.Quantity;
                totalProfit += item.Quantity * item.ProductProfit;
            }

            txtSumNumbers.Text = itemsCount.ToString("#,#");
            txtSumProfit.Text = totalProfit.ToString("#,#");

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

        private void deleteFactor(SellFactor factor)
        {
            var db = new shampazEntities();
            
            db.SaveChanges();
        }

        private void dgvFactors_SelectionChanged(object sender, EventArgs e)
        {
            int itemsCount = 0;
            decimal totalProfit = 0;

            if (dgvFactors.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvFactors.SelectedRows)
                {
                    itemsCount += Convert.ToInt32(row.Cells["clnNumbers"].Value);
                    totalProfit += Convert.ToDecimal(row.Cells["clnTotalProfit"].Value);
                }
            }
            else
            {
                foreach (DataGridViewRow row in dgvFactors.Rows)
                {
                    itemsCount += Convert.ToInt32(row.Cells["clnNumbers"].Value);
                    totalProfit += Convert.ToDecimal(row.Cells["clnTotalProfit"].Value);
                }
            }

            txtSumNumbers.Text = itemsCount.ToString("#,#");
            txtSumProfit.Text = totalProfit.ToString("#,#");
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

        private void dgvFactors_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var singleProfit = Convert.ToDecimal(dgvFactors.Rows[e.RowIndex].Cells["clnSingleProfit"].Value);
            var quantity = Convert.ToDecimal(dgvFactors.Rows[e.RowIndex].Cells["clnNumbers"].Value);

            dgvFactors.Rows[e.RowIndex].Cells["clnTotalProfit"].Value = singleProfit * quantity;
        }
    }
}
