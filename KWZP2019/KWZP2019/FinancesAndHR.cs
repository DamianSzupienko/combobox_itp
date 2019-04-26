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
    public partial class FinancesAndHR : Form
    {
        RoofingCompanyEntities db;
        public FinancesAndHR(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btnHR_Click(object sender, EventArgs e)
        {
            HR hr = new HR(db);
            hr.Show();
        }

        private void btnFinances_Click(object sender, EventArgs e)
        {
            Finances finances = new Finances(db);
            finances.Show();
        }

    }
}
