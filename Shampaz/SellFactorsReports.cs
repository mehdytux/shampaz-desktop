using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shampaz
{
    public partial class SellFactorsReports : DevComponents.DotNetBar.Office2007Form
    {
        public SellFactorsReports()
        {
            InitializeComponent();
        }

        private void SellFactorList_Load(object sender, EventArgs e)
        {
            pDateFrom.GeorgianDate = DateTime.Now;
            pDateTo.GeorgianDate = DateTime.Now;

            dgvFactorsRefresh();
        }

        private void dgvFactorsRefresh()
        {
            dgvFactors.Rows.Clear();

            var db = new shampazEntities();
            var to = pDateTo.GeorgianDate + new TimeSpan(23, 59, 59);

            //var items = from factor in db.SellFactors
            //           where factor.Date >= pDateFrom.GeorgianDate && factor.Date <= to
            //           select factor;

            //MessageBox.Show(items.Count().ToString());
            //return;

            var rows = from factor in db.SellFactors
                       where DbFunctions.TruncateTime(factor.Date) >= pDateFrom.GeorgianDate && DbFunctions.TruncateTime(factor.Date) <= pDateTo.GeorgianDate
                       group factor by DbFunctions.TruncateTime(factor.Date) into g
                       select new
                       {
                           Date = g.Key,
                           FactorsQuantity = g.Count(),
                           ItemsQuantity = g.Select(w => w.SellFactorItems.Sum(s=>s.Numbers)).Sum(),
                           TotalPrice = g.Select(t => t.TotalPrice).Sum()
                       };


            //where factor.Date >= pDateFrom.GeorgianDate && factor.Date <= to
            //group factor by DbFunctions.TruncateTime(factor.Date) into g

            //select new
            // {
            //    Date = g.Key,
            //    FactorsQuantity = g.Count(),
            //    Items = g.Select(w => w.SellFactorItems),
            //    TotalPrice = g.Select(t => t.TotalPrice).Sum()
            // };

            //txtFactorsCount.Text = factors.Count.ToString("#,#");

            var itemsCount = 0;
            decimal totalPrice = 0;
            foreach(var row in rows)
            {
                var day = Convert.ToDateTime(row.Date);
                PersianCalendar pc = new PersianCalendar();
                string pDate = string.Format("{0}/{1}/{2}", pc.GetYear(day), pc.GetMonth(day), pc.GetDayOfMonth(day));
                dgvFactors.Rows.Add(pDate, row.FactorsQuantity, row.ItemsQuantity, row.TotalPrice.ToString("#,#"));

                itemsCount += row.ItemsQuantity;
                totalPrice += row.TotalPrice;
            }

            txtFactorItemsCount.Text = itemsCount.ToString("#,#");
            txtFactorsTotalPrice.Text = totalPrice.ToString("#,#");

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            dgvFactorsRefresh();
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

        private void dgvFactors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if(dgvFactors.SelectedRows.Count < 1)
            {
                return;
            }

            var date = dgvFactors.SelectedRows[0].Cells["clnDate"].Value.ToString().Split('/');
            var form = new SellFactorList();

            form.pDateFrom.PersianDate = new PersianDateInfo( Convert.ToInt32(date[0]), Convert.ToInt32(date[1]), Convert.ToInt32(date[2]));
            form.pDateTo.PersianDate = new PersianDateInfo(Convert.ToInt32(date[0]), Convert.ToInt32(date[1]), Convert.ToInt32(date[2]));
            form.ShowDialog();
        }
    }
}
