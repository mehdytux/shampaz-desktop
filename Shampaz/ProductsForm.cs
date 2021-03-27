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
        }

        private void dgvProductsRefresh()
        {
            dgvProducts.Rows.Clear();

            var db = new shampazEntities();
            foreach (var product in db.Products.ToList())
            {
                dgvProducts.Rows.Add(product.Id, product.Name, product.Price);
            }
        }
    }
}
