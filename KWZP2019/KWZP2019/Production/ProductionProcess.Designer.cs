namespace KWZP2019
{
    partial class ProductionProcess
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
            this.ProductionProcessGridView = new System.Windows.Forms.DataGridView();
            this.productionProceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idProcesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.failuresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outControlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedProductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProductionProcessGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionProceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductionProcessGridView
            // 
            this.ProductionProcessGridView.AutoGenerateColumns = false;
            this.ProductionProcessGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductionProcessGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProcesDataGridViewTextBoxColumn,
            this.idPlanDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.failuresDataGridViewTextBoxColumn,
            this.outControlDataGridViewTextBoxColumn,
            this.plannedProductionDataGridViewTextBoxColumn});
            this.ProductionProcessGridView.DataSource = this.productionProceBindingSource;
            this.ProductionProcessGridView.Location = new System.Drawing.Point(12, 68);
            this.ProductionProcessGridView.Name = "ProductionProcessGridView";
            this.ProductionProcessGridView.Size = new System.Drawing.Size(760, 281);
            this.ProductionProcessGridView.TabIndex = 0;
            // 
            // productionProceBindingSource
            // 
            this.productionProceBindingSource.DataSource = typeof(KWZP2019.ProductionProce);
            // 
            // idProcesDataGridViewTextBoxColumn
            // 
            this.idProcesDataGridViewTextBoxColumn.DataPropertyName = "IdProces";
            this.idProcesDataGridViewTextBoxColumn.HeaderText = "IdProces";
            this.idProcesDataGridViewTextBoxColumn.Name = "idProcesDataGridViewTextBoxColumn";
            // 
            // idPlanDataGridViewTextBoxColumn
            // 
            this.idPlanDataGridViewTextBoxColumn.DataPropertyName = "IdPlan";
            this.idPlanDataGridViewTextBoxColumn.HeaderText = "IdPlan";
            this.idPlanDataGridViewTextBoxColumn.Name = "idPlanDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // failuresDataGridViewTextBoxColumn
            // 
            this.failuresDataGridViewTextBoxColumn.DataPropertyName = "Failures";
            this.failuresDataGridViewTextBoxColumn.HeaderText = "Failures";
            this.failuresDataGridViewTextBoxColumn.Name = "failuresDataGridViewTextBoxColumn";
            // 
            // outControlDataGridViewTextBoxColumn
            // 
            this.outControlDataGridViewTextBoxColumn.DataPropertyName = "OutControl";
            this.outControlDataGridViewTextBoxColumn.HeaderText = "OutControl";
            this.outControlDataGridViewTextBoxColumn.Name = "outControlDataGridViewTextBoxColumn";
            // 
            // plannedProductionDataGridViewTextBoxColumn
            // 
            this.plannedProductionDataGridViewTextBoxColumn.DataPropertyName = "PlannedProduction";
            this.plannedProductionDataGridViewTextBoxColumn.HeaderText = "PlannedProduction";
            this.plannedProductionDataGridViewTextBoxColumn.Name = "plannedProductionDataGridViewTextBoxColumn";
            // 
            // ProductionProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.ProductionProcessGridView);
            this.Name = "ProductionProcess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aktualnie w produkcji";
            this.Load += new System.EventHandler(this.ProductionProcess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductionProcessGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionProceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductionProcessGridView;
        private System.Windows.Forms.BindingSource productionProceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProcesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn failuresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outControlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedProductionDataGridViewTextBoxColumn;
    }
}