using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KWZP2019
{
    public partial class OshTrainingForm : Form
    {
        RoofingCompanyEntities db;
        StartForm startForm;
        QualityControl qualityControlForm;

        public OshTrainingForm(RoofingCompanyEntities db, StartForm startForm, QualityControl qualityControlForm)
        {
            this.db = db;
            this.startForm = startForm;
            this.qualityControlForm = qualityControlForm;
            InitializeComponent();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.startForm.Show();
            this.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.qualityControlForm.Show();
            this.Hide();
        }

        private void OshTrainingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.startForm.Show();
        }

        private void OshTrainingForm_Load(object sender, EventArgs e)
        {
            List<Department> departmentList = db.Departments.ToList();
            foreach(Department dep in departmentList)
            {
                domainUpDownDepartmentName.Items.Add(dep.DepartmentName);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dataGVOshTraining.DataSource = db.ViewOshTrainings.
                Where(vOsh => vOsh.DepartmentName == domainUpDownDepartmentName.Text
                && DbFunctions.AddDays(vOsh.TrainingDate, (int)vOsh.ValidityOfOshTraining * 365) <= DbFunctions.AddDays(DateTime.Now, 45)
                && vOsh.EndDate > DbFunctions.AddDays(DateTime.Now, 45))
                .Select(osh => new { osh.EmployeeName, osh.EmployeeSurname, NextTrainingDate = DbFunctions.AddDays(osh.TrainingDate, (int)osh.ValidityOfOshTraining * 365) })
                .ToList();
        }
    }
}
