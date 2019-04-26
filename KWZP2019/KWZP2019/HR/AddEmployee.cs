using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP2019
{
    public partial class AddEmployee : Form
    {
        RoofingCompanyEntities db;
        public AddEmployee(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
            clear();
        }

        
        void clear()
        {
            tbFirstName.Text = "";
            tbLastName.Text =  "";
            tbZipCode.Text = "";
            tbCity.Text = "";
            tbStreet.Text = "";
            tbHouseNumber.Text = "";
            tbApartmentNumber.Text = "";
            tbPhoneNumber.Text = "";
            tbPESEL.Text = "";
            tbContractLenght.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbFirstName.Text.Trim() == "" || tbLastName.Text.Trim() == "")
            {
                MessageBox.Show("Imię i nazwisko są wymagane");
            }
            Employee newEmployee = new Employee();
            newEmployee.EmployeeName = tbFirstName.Text.Trim();
            newEmployee.EmployeeSurname = tbLastName.Text.Trim();
            newEmployee.ZipCode = tbZipCode.Text.Trim();
            newEmployee.City = tbCity.Text.Trim();
            newEmployee.Street = tbStreet.Text.Trim();
            newEmployee.HouseNumber = tbHouseNumber.Text.Trim();
            newEmployee.ApartmentNum = tbApartmentNumber.Text.Trim();
            newEmployee.PhoneNumber = tbPhoneNumber.Text.Trim();
            newEmployee.PESEL = long.Parse(tbPESEL.Text.Trim());
            Contract newContract = new Contract();
            if (tbContractLenght.Text.Trim() == "")
            {
               
            }
            
        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }
    }
}
