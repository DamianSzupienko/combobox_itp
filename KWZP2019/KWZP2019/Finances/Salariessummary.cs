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
    public partial class SalariesSummary : Form
    {
        RoofingCompanyEntities db;
        public SalariesSummary(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }
    }
}
