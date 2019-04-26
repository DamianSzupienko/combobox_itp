namespace KWZP2019
{
    partial class ProductionHistory
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
            this.ProductionHistoryGridView = new System.Windows.Forms.DataGridView();
            this.productionProceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idProcesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.failuresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outControlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedProductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProductionHistoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionProceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductionHistoryGridView
            // 
            this.ProductionHistoryGridView.AutoGenerateColumns = false;
            this.ProductionHistoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductionHistoryGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProcesDataGridViewTextBoxColumn,
            this.idPlanDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.failuresDataGridViewTextBoxColumn,
            this.outControlDataGridViewTextBoxColumn,
            this.plannedProductionDataGridViewTextBoxColumn});
            this.ProductionHistoryGridView.DataSource = this.productionProceBindingSource;
            this.ProductionHistoryGridView.Location = new System.Drawing.Point(13, 60);
            this.ProductionHistoryGridView.Name = "ProductionHistoryGridView";
            this.ProductionHistoryGridView.Size = new System.Drawing.Size(759, 289);
            this.ProductionHistoryGridView.TabIndex = 0;
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
            // ProductionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.ProductionHistoryGridView);
            this.Name = "ProductionHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rejestr produkcji";
            this.Load += new System.EventHandler(this.ProductionHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductionHistoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionProceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductionHistoryGridView;
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