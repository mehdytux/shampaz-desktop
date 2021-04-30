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
    public partial class PersonAddFrom : DevComponents.DotNetBar.Office2007Form
    {
        public int PersonId { get; set; }
        public bool EditMode { get; set; }

        public PersonAddFrom()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var name = txtName.Text.Trim();
            if(name.Length == 0)
            {
                DesktopAlert.Show("نام نمی تواند خالی باشد", eDesktopAlertColor.Red, eAlertPosition.BottomRight);
                return;
            }

            if (EditMode)
            {
                editPerson();
            }
            else
            {
                addPerson();
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void PersonAddFrom_Load(object sender, EventArgs e)
        {
            if (EditMode)
            {
                var db = new shampazEntities();
                var p = db.Persons.Where(x => x.Id == PersonId).FirstOrDefault();

                txtName.Text = p.Name;
                txtMobile.Text = p.Mobile;
                txtAddress.Text = p.Address;
            }
        }

        private void editPerson()
        {
            var db = new shampazEntities();
            var p = db.Persons.Where(x => x.Id == PersonId).FirstOrDefault();
            p.Name = txtName.Text.Trim();
            p.Mobile = txtMobile.Text.Trim();
            p.Address = txtAddress.Text.Trim();

            DesktopAlert.Show("شخص ویرایش شد", eDesktopAlertColor.Green, eAlertPosition.BottomRight);
            db.SaveChanges();
        }

        private void addPerson()
        {
            var db = new shampazEntities();
            db.Persons.Add(new Person
            {
                Name = txtName.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Mobile = txtMobile.Text.Trim()
            });

            db.SaveChanges();

            DesktopAlert.Show("شخص افزوده شد", eDesktopAlertColor.Green, eAlertPosition.BottomRight);
        }
    }
}
