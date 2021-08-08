using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shampaz
{
    public partial class frmMain : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            var db = new shampazEntities();
            db.Persons.FirstOrDefault();
        }

        private void rbtnProducts_Click(object sender, EventArgs e)
        {
            new ProductsForm().ShowDialog();
        }

        private void btnPersons_Click(object sender, EventArgs e)
        {
            new PersonsForm().ShowDialog();
        }

        private void btnSellFactor_Click(object sender, EventArgs e)
        {
            new SellFactorForm().ShowDialog();
        }

        private void btnFactorsList_Click(object sender, EventArgs e)
        {
            new SellFactorList().ShowDialog();
        }

        private void buttonItem13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalesAggregation_Click(object sender, EventArgs e)
        {
            new SalesAggregationForm().ShowDialog();
        }

        private void btnPersonsSalesAggregation_Click(object sender, EventArgs e)
        {
            new PersonsSalesAggregationForm().ShowDialog();
        }

        private void btnSellFactor_Click_1(object sender, EventArgs e)
        {
            var form = new SellFactorForm();
            form.ShowDialog();
        }

        private void btnBuyFactor_Click(object sender, EventArgs e)
        {
            BuyFactorAddForm form = new BuyFactorAddForm();
            form.ShowDialog();
        }

        private void btnBuyFactorsList_Click(object sender, EventArgs e)
        {
            new BuyFactorList().ShowDialog();
        }

        private void btnNewSellFactor_Click(object sender, EventArgs e)
        {
            btnSellFactor.RaiseClick();
        }

        private void btnNewBuyFactor_Click(object sender, EventArgs e)
        {
            btnBuyFactor.RaiseClick();
        }

        private void btnPersonsBuysAggregation_Click(object sender, EventArgs e)
        {
            new PersonBuysAggregationForm().ShowDialog();
        }

        private void btnBuyFactorsList_Click_1(object sender, EventArgs e)
        {
            new BuyFactorList().ShowDialog();
        }

        private void btnProductsBuysAggregation_Click(object sender, EventArgs e)
        {
            new ProductsBuysAggregationForm().ShowDialog();
        }

        private void btnFactorsList_Click_1(object sender, EventArgs e)
        {
            new SellFactorList().ShowDialog();
        }

        private void btnProductsSalesAggregation_Click(object sender, EventArgs e)
        {
            new SalesAggregationForm().ShowDialog();
        }

        private void btnPersonsSalesAggregation_Click_1(object sender, EventArgs e)
        {
            new PersonsSalesAggregationForm().ShowDialog();
        }

        private void btnProductsSaleSumProfit_Click(object sender, EventArgs e)
        {
            new ProductsSalesSumProfitForm().ShowDialog();
        }

        private void btnSellFactorsReport_Click(object sender, EventArgs e)
        {
            new SellFactorsReports().ShowDialog();
        }
    }
}
