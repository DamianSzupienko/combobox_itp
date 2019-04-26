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
    public partial class HR : Form
    {
        RoofingCompanyEntities db;
        public HR(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee(db);
            addEmployee.Show();
        }

        private void btnExamination_Click(object sender, EventArgs e)
        {
            Examination examination = new Examination(db);
            examination.Show();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            EmployeeDetails employeeDetails = new EmployeeDetails(db);
            employeeDetails.Show();
        }

        private void btnAbsences_Click(object sender, EventArgs e)
        {
            Absences absences = new Absences(db);
            absences.Show();
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            AddTraining addTraining = new AddTraining(db);
            addTraining.Show();
        }
    }
}
