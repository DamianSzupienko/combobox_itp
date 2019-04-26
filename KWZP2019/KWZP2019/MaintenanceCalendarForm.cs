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
    public partial class MaintenanceCalendarForm : Form
    {
        RoofingCompanyEntities db;
        StartForm startForm;
        MaintenanceManagement maintenanceManagementForm;

        public MaintenanceCalendarForm(RoofingCompanyEntities db, StartForm startForm, MaintenanceManagement maintenanceManagementForm)
        {
            this.db = db;
            this.startForm = startForm;
            this.maintenanceManagementForm = maintenanceManagementForm;
            InitializeComponent();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            this.maintenanceManagementForm.Show();
            this.Hide();
        }
    }
}
