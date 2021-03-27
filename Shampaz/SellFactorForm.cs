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
    public partial class SellFactorForm : DevComponents.DotNetBar.Office2007Form
    {
        public SellFactorForm()
        {
            InitializeComponent();
        }

        private void SellFactorForm_Load(object sender, EventArgs e)
        {
            pdpDate.GeorgianDate = DateTime.Now;
        }
    }
}
