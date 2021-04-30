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
    public partial class PersonsForm : DevComponents.DotNetBar.Office2007Form
    {
        public bool SelectMode { get; set; }
        public Person SelectedPerson { get; set; }

        public PersonsForm()
        {
            InitializeComponent();
        }

        private void dgvPersonsRefresh()
        {
            dgvPersons.Rows.Clear();

            var db = new shampazEntities();
            foreach (var p in db.Persons.ToList())
            {
                dgvPersons.Rows.Add(p.Id, p.Name, p.Mobile, p.Address);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new PersonAddFrom();
            form.ShowDialog();

            if(form.DialogResult == DialogResult.OK)
            {
                dgvPersonsRefresh();
            }
        }

        private void PersonsForm_Load(object sender, EventArgs e)
        {
            dgvPersonsRefresh();

            if (SelectMode)
            {
                //btnAdd.Enabled = false;
                //btnRemove.Enabled = false;
                //btnEdit.Enabled = false;
                btnSelect.Visible = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dgvPersons.SelectedRows.Count == 0)
            {
                return;
            }

            var form = new PersonAddFrom();
            form.EditMode = true;
            form.PersonId = Convert.ToInt32(dgvPersons.SelectedRows[0].Cells["clnId"].Value);
            form.ShowDialog();

            if(form.DialogResult == DialogResult.OK)
            {
                dgvPersonsRefresh();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("آیا از حذف شخص مطمئنید ؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.No)
            {
                return;
            }

            if (dgvPersons.SelectedRows.Count == 0)
            {
                return;
            }

            var id = Convert.ToInt32(dgvPersons.SelectedRows[0].Cells["clnId"].Value);

            var db = new shampazEntities();
            var p = db.Persons.Where(x => x.Id == id).FirstOrDefault();

            try
            {
                db.Persons.Remove(p);
                db.SaveChanges();
                DesktopAlert.Show("شخص حذف شد", eDesktopAlertColor.Green, eAlertPosition.BottomRight);
                dgvPersonsRefresh();
            }
            catch
            {
                DesktopAlert.Show("امکان حذف شخص نیست", eDesktopAlertColor.Red, eAlertPosition.BottomRight);
            }
        }

        private void txtSerach_TextChanged(object sender, EventArgs e)
        {
            var subject = txtSerach.Text;

            var db = new shampazEntities();
            var persons = from p in db.Persons
                          where p.Name.Contains(subject) || p.Mobile.Contains(subject) || p.Address.Contains(subject)
                          select p;

            dgvPersons.Rows.Clear();
            foreach(var p in persons)
            {
                dgvPersons.Rows.Add(p.Id, p.Name, p.Mobile, p.Address);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if(dgvPersons.SelectedRows.Count == 0)
            {
                return;
            }

            var id = Convert.ToInt32(dgvPersons.SelectedRows[0].Cells["clnId"].Value);

            var db = new shampazEntities();
            SelectedPerson = db.Persons.Where(x => x.Id == id).FirstOrDefault();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void dgvPersons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPersons_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSelect.PerformClick();
        }
    }
}
