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
    public partial class ProductionHistory : Form
    {
        RoofingCompanyEntities db;
        public ProductionHistory(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void ProductionHistory_Load(object sender, EventArgs e)
        {
            
            ProductionHistoryGridView.DataSource = db.ProductionProces.
               Where(ProdHist => ProdHist.EndDate < DateTime.Now).ToList();
        }
    }
}
