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
    public partial class OutControlForm : Form
    {
        RoofingCompanyEntities db;
        StartForm startForm;
        QualityControl qualityControlForm;

        public OutControlForm(RoofingCompanyEntities db, StartForm startForm, QualityControl qualityControlForm)
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

        private void OutControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.startForm.Show();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.qualityControlForm.Show();
            this.Hide();
        }
    }
}
