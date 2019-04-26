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
    public partial class ProductionProducts : Form
    {
        RoofingCompanyEntities db;
        public ProductionProducts(RoofingCompanyEntities db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void btAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(db);
            addProduct.Show();
        }

        private void ProductionProducts_Load(object sender, EventArgs e)
        {
            dataGridProducts.DataSource = db.Products.ToList();
        }

        private void btEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
