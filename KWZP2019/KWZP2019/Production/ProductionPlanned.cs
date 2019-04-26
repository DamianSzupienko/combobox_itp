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
    public partial class ProductionPlanned : Form
    {
        RoofingCompanyEntities db;
        int id, newId;
        public ProductionPlanned(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void ProductionPlanned_Load(object sender, EventArgs e)
        {
            PlannedProductionGridView.DataSource = db.PlannedProductions.ToList();
            newId = PlannedProductionGridView.RowCount + 1;
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool isTxtBoxEmpty(TextBox tBox)
        {
            return tBox.Text.Trim().Length < 1;
        }
        private void txtBoxPlanSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            int planNumber;
            if(isTxtBoxEmpty(txtBoxPlanSearch)) 
            {
                PlannedProductionGridView.DataSource = db.PlannedProductions.ToList();
            }
            else
            {
                planNumber = Convert.ToInt32(txtBoxPlanSearch.Text.Trim());
                PlannedProductionGridView.DataSource = (from PlannedProduction in db.PlannedProductions
                                                        where PlannedProduction.IdPlan == planNumber
                                                        select PlannedProduction).ToList();
            }
        }

        private void PlannedProductionGridView_SelectionChanged(object sender, EventArgs e)
        {
            id = Convert.ToInt32(this.PlannedProductionGridView.CurrentRow.Cells[0].Value);
        }

        private void btnRefreshPlanList_Click(object sender, EventArgs e)
        {
            PlannedProductionGridView.DataSource = db.PlannedProductions.ToList();
        }

        private void btnAddPlan_Click(object sender, EventArgs e)
        {
            NewProductionPlan NewProductionPlanForm = new NewProductionPlan(db, id, newId);
            NewProductionPlanForm.Show();
        }
        



    }
}
