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
    public partial class ProductsForm : DevComponents.DotNetBar.Office2007Form
    {
        public bool SelectMode { get; set; }
        public Product SelectedProduct { get; set; }

        public ProductsForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(new ProductAddForm().ShowDialog() == DialogResult.OK)
            {
                dgvProductsRefresh();
            }
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            dgvProductsRefresh();

            if (SelectMode)
            {
                //btnAdd.Enabled = false;
                //btnEdit.Enabled = false;
                //btnRemove.Enabled = false;
                btnSelect.Visible = true;
            }
        }

        private void dgvProductsRefresh()
        {
            dgvProducts.Rows.Clear();

            var db = new shampazEntities();
            foreach (var product in db.Products.ToList())
            {
                dgvProducts.Rows.Add(product.Id, product.Name, product.Price, product.Profit);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dgvProducts.SelectedRows.Count == 0)
            {
                return;
            }

            var form = new ProductAddForm();
            form.EditMode = true;
            form.ProductId = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["clnProductId"].Value);
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                dgvProductsRefresh();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("آیا از حذف کالا مطمئنید ؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                return;
            }

            if (dgvProducts.SelectedRows.Count == 0)
            {
                return;
            }

            var id = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["clnProductId"].Value);
            try
            {
                var db = new shampazEntities();
                var p = db.Products.Where(x => x.Id == id).FirstOrDefault();
                db.Products.Remove(p);
                db.SaveChanges();

                DesktopAlert.Show("محصول " + p.Name + " حذف شد", eDesktopAlertColor.Green, eAlertPosition.BottomRight);

                dgvProductsRefresh();
            }
            catch
            {
                DesktopAlert.Show("محصول را نمی توان حذف کرد", eDesktopAlertColor.Red, eAlertPosition.BottomRight);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var subject = txtSearch.Text;

            var db = new shampazEntities();
            var products = from p in db.Products
                          where p.Name.Contains(subject)
                          select p;

            dgvProducts.Rows.Clear();
            foreach(var p in products)
            {
                dgvProducts.Rows.Add(p.Id, p.Name, p.Price);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(dgvProducts.SelectedRows.Count == 0)
            {
                return;
            }

            var db = new shampazEntities();
            var id = Convert.ToInt32(dgvProducts.SelectedRows[0].Cells["clnProductId"].Value);
            SelectedProduct = db.Products.Where(x => x.Id == id).FirstOrDefault();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            var form = new ProductAddForm();
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                dgvProductsRefresh();
            }
        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelect.PerformClick();
        }
    }
}
