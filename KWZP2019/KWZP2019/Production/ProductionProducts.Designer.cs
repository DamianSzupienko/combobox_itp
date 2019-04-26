namespace KWZP2019
{
    partial class ProductionProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btAddProduct = new System.Windows.Forms.Button();
            this.btEditProduct = new System.Windows.Forms.Button();
            this.btDeleteProduct = new System.Windows.Forms.Button();
            this.btEnd = new System.Windows.Forms.Button();
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSemiFinishedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTechnologyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inputDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semiFinishedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technologyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.technicalProductDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btAddProduct
            // 
            this.btAddProduct.Location = new System.Drawing.Point(195, 13);
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Size = new System.Drawing.Size(107, 21);
            this.btAddProduct.TabIndex = 0;
            this.btAddProduct.Text = "Dodaj";
            this.btAddProduct.UseVisualStyleBackColor = true;
            this.btAddProduct.Click += new System.EventHandler(this.btAddProduct_Click);
            // 
            // btEditProduct
            // 
            this.btEditProduct.Location = new System.Drawing.Point(314, 12);
            this.btEditProduct.Name = "btEditProduct";
            this.btEditProduct.Size = new System.Drawing.Size(107, 21);
            this.btEditProduct.TabIndex = 1;
            this.btEditProduct.Text = "Edytuj";
            this.btEditProduct.UseVisualStyleBackColor = true;
            // 
            // btDeleteProduct
            // 
            this.btDeleteProduct.Location = new System.Drawing.Point(433, 12);
            this.btDeleteProduct.Name = "btDeleteProduct";
            this.btDeleteProduct.Size = new System.Drawing.Size(107, 21);
            this.btDeleteProduct.TabIndex = 2;
            this.btDeleteProduct.Text = "Usuń";
            this.btDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btEnd
            // 
            this.btEnd.Location = new System.Drawing.Point(552, 12);
            this.btEnd.Name = "btEnd";
            this.btEnd.Size = new System.Drawing.Size(107, 21);
            this.btEnd.TabIndex = 3;
            this.btEnd.Text = "Koniec";
            this.btEnd.UseVisualStyleBackColor = true;
            this.btEnd.Click += new System.EventHandler(this.btEnd_Click);
            // 
            // dataGridProducts
            // 
            this.dataGridProducts.AutoGenerateColumns = false;
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductDataGridViewTextBoxColumn,
            this.idSemiFinishedDataGridViewTextBoxColumn,
            this.productCodeDataGridViewTextBoxColumn,
            this.idTechnologyDataGridViewTextBoxColumn,
            this.inputDateDataGridViewTextBoxColumn,
            this.orderDetailsDataGridViewTextBoxColumn,
            this.semiFinishedDataGridViewTextBoxColumn,
            this.technologyDataGridViewTextBoxColumn,
            this.technicalProductDataDataGridViewTextBoxColumn});
            this.dataGridProducts.DataSource = this.productBindingSource;
            this.dataGridProducts.Location = new System.Drawing.Point(12, 40);
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.Size = new System.Drawing.Size(776, 398);
            this.dataGridProducts.TabIndex = 4;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(KWZP2019.Product);
            // 
            // idProductDataGridViewTextBoxColumn
            // 
            this.idProductDataGridViewTextBoxColumn.DataPropertyName = "IdProduct";
            this.idProductDataGridViewTextBoxColumn.HeaderText = "IdProduct";
            this.idProductDataGridViewTextBoxColumn.Name = "idProductDataGridViewTextBoxColumn";
            // 
            // idSemiFinishedDataGridViewTextBoxColumn
            // 
            this.idSemiFinishedDataGridViewTextBoxColumn.DataPropertyName = "IdSemiFinished";
            this.idSemiFinishedDataGridViewTextBoxColumn.HeaderText = "IdSemiFinished";
            this.idSemiFinishedDataGridViewTextBoxColumn.Name = "idSemiFinishedDataGridViewTextBoxColumn";
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            // 
            // idTechnologyDataGridViewTextBoxColumn
            // 
            this.idTechnologyDataGridViewTextBoxColumn.DataPropertyName = "IdTechnology";
            this.idTechnologyDataGridViewTextBoxColumn.HeaderText = "IdTechnology";
            this.idTechnologyDataGridViewTextBoxColumn.Name = "idTechnologyDataGridViewTextBoxColumn";
            // 
            // inputDateDataGridViewTextBoxColumn
            // 
            this.inputDateDataGridViewTextBoxColumn.DataPropertyName = "InputDate";
            this.inputDateDataGridViewTextBoxColumn.HeaderText = "InputDate";
            this.inputDateDataGridViewTextBoxColumn.Name = "inputDateDataGridViewTextBoxColumn";
            // 
            // orderDetailsDataGridViewTextBoxColumn
            // 
            this.orderDetailsDataGridViewTextBoxColumn.DataPropertyName = "OrderDetails";
            this.orderDetailsDataGridViewTextBoxColumn.HeaderText = "OrderDetails";
            this.orderDetailsDataGridViewTextBoxColumn.Name = "orderDetailsDataGridViewTextBoxColumn";
            // 
            // semiFinishedDataGridViewTextBoxColumn
            // 
            this.semiFinishedDataGridViewTextBoxColumn.DataPropertyName = "SemiFinished";
            this.semiFinishedDataGridViewTextBoxColumn.HeaderText = "SemiFinished";
            this.semiFinishedDataGridViewTextBoxColumn.Name = "semiFinishedDataGridViewTextBoxColumn";
            // 
            // technologyDataGridViewTextBoxColumn
            // 
            this.technologyDataGridViewTextBoxColumn.DataPropertyName = "Technology";
            this.technologyDataGridViewTextBoxColumn.HeaderText = "Technology";
            this.technologyDataGridViewTextBoxColumn.Name = "technologyDataGridViewTextBoxColumn";
            // 
            // technicalProductDataDataGridViewTextBoxColumn
            // 
            this.technicalProductDataDataGridViewTextBoxColumn.DataPropertyName = "TechnicalProductData";
            this.technicalProductDataDataGridViewTextBoxColumn.HeaderText = "TechnicalProductData";
            this.technicalProductDataDataGridViewTextBoxColumn.Name = "technicalProductDataDataGridViewTextBoxColumn";
            // 
            // ProductionProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridProducts);
            this.Controls.Add(this.btEnd);
            this.Controls.Add(this.btDeleteProduct);
            this.Controls.Add(this.btEditProduct);
            this.Controls.Add(this.btAddProduct);
            this.Name = "ProductionProducts";
            this.Text = "Produkty";
            this.Load += new System.EventHandler(this.ProductionProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAddProduct;
        private System.Windows.Forms.Button btEditProduct;
        private System.Windows.Forms.Button btDeleteProduct;
        private System.Windows.Forms.Button btEnd;
        private System.Windows.Forms.DataGridView dataGridProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSemiFinishedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTechnologyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inputDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semiFinishedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technologyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn technicalProductDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}