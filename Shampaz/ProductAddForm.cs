using DevComponents.DotNetBar.Controls;
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
    public partial class ProductAddForm : DevComponents.DotNetBar.Office2007Form
    {
        public int ProductId { get; set; }
        public bool EditMode { get; set; }

        public ProductAddForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Trim().Length == 0)
            {
                DesktopAlert.Show("نام نمی تواند خالی باشد", eDesktopAlertColor.Red, eAlertPosition.BottomRight);
                return;
            }

            decimal price;
            try
            {
                price = Convert.ToDecimal(txtPrice.Text);
            }
            catch
            {
                price = 0;
            }

            if(price == 0)
            {
                DesktopAlert.Show("قیمت کالا را وارد کنید", eDesktopAlertColor.Red, eAlertPosition.BottomRight);
                return;
            }

            // Profit
            decimal profit;
            try
            {
                profit = Convert.ToDecimal(txtProfit.Text);
            }
            catch
            {
                profit = 0;
            }

            // save data
            var db = new shampazEntities();

            Product p;
            if (EditMode)
            {
                p = db.Products.Where(x => x.Id == ProductId).FirstOrDefault();
                p.Name = txtName.Text.Trim();
                p.Price = price;
                p.Profit = profit;

                DesktopAlert.Show("محصول بروزرسانی شد", eDesktopAlertColor.Green, eAlertPosition.BottomRight);
            }
            else
            {
                db.Products.Add(new Product
                {
                    Name = txtName.Text.Trim(),
                    Price = price,
                    Profit = profit
                });

                DesktopAlert.Show("محصول ثبت شد", eDesktopAlertColor.Green, eAlertPosition.BottomRight);
            }

            db.SaveChanges();
            DialogResult = DialogResult.OK;
            
            Close();
        }

        private void ProductAddForm_Load(object sender, EventArgs e)
        {
            if (EditMode)
            {
                var db = new shampazEntities();
                var p = db.Products.Where(x => x.Id == ProductId).FirstOrDefault();
                txtName.Text = p.Name;
                txtPrice.Text = p.Price.ToString();
                txtProfit.Text = p.Profit.ToString();
            }
        }
    }
}
