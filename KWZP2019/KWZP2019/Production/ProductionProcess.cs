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
    public partial class ProductionProcess : Form
    {
        RoofingCompanyEntities db;
        public ProductionProcess(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void ProductionProcess_Load(object sender, EventArgs e)
        {
            ///DODAŁEM TO
            List<PlannedProduction> missingProductionProcess = db.PlannedProductions.
               Where(c => !db.ProductionProces.
               Select(b => b.IdPlan).
               Contains(c.IdPlan)).ToList();


            foreach (PlannedProduction plannedProduction in missingProductionProcess)
            {
                if (plannedProduction.Inproduction == true)
                {
                    ProductionProce productionProces = new ProductionProce();
                    productionProces.IdPlan = plannedProduction.IdPlan;
                    productionProces.StartDate = plannedProduction.PlannedStartd;
                    productionProces.EndDate = plannedProduction.PlannedEndd;
                    db.ProductionProces.Add(productionProces);
                }
                else
                {
                    continue;
                }
            }
            db.SaveChanges();

            ProductionProcessGridView.DataSource = db.ProductionProces.
            Where(ProdProc => ProdProc.EndDate >= DateTime.Now).ToList();

        }
    }
}
