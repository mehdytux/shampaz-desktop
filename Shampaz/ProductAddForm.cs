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

            var db = new shampazEntities();
            db.Products.Add(new Product
            {
                Name = txtName.Text.Trim(),
                Price = price
            });

            db.SaveChanges();
            DialogResult = DialogResult.OK;
            DesktopAlert.Show("محصول ثبت شد", eDesktopAlertColor.Green, eAlertPosition.BottomRight);
            Close();
        }
    }
}
