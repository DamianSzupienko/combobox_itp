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
    public partial class StartForm : Form
    {
      private RoofingCompanyEntities db;

        public StartForm()
        {
            InitializeComponent();
            db = new RoofingCompanyEntities();

        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            Production productionForm = new Production(db);
            productionForm.Show();
        }
        private void btnSales_Click(object sender, EventArgs e)
        {
            SalesDepartment salesDepartment = new SalesDepartment(db);
            salesDepartment.Show();
        }
        private void btnQA_Click(object sender, EventArgs e)
        {
            QualityControl qualityControlForm = new QualityControl(db, this);
            qualityControlForm.Show();
            this.Hide();
        }

        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            MaintenanceManagement maintenanceManagement = new MaintenanceManagement(db, this);
            maintenanceManagement.Show();
            this.Hide();
        }

        private void btnHR_Click(object sender, EventArgs e)
        {
            FinancesAndHR finanseIHR = new FinancesAndHR(db);
            finanseIHR.Show();
        }
    }
}
