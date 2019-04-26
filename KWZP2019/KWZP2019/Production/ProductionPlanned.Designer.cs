namespace KWZP2019
{
    partial class ProductionPlanned
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
            this.PlannedProductionGridView = new System.Windows.Forms.DataGridView();
            this.idPlanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMachineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedStartdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedEnddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inproductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetail1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedProductionEmployeeDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionProcesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedProductionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPlanSearch = new System.Windows.Forms.TextBox();
            this.btnAddPlan = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnMachineDet = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnRefreshPlanList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlannedProductionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannedProductionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PlannedProductionGridView
            // 
            this.PlannedProductionGridView.AutoGenerateColumns = false;
            this.PlannedProductionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlannedProductionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPlanDataGridViewTextBoxColumn,
            this.idDetailDataGridViewTextBoxColumn,
            this.idMachineDataGridViewTextBoxColumn,
            this.plannedStartdDataGridViewTextBoxColumn,
            this.plannedEnddDataGridViewTextBoxColumn,
            this.inproductionDataGridViewTextBoxColumn,
            this.orderDetailDataGridViewTextBoxColumn,
            this.orderDetail1DataGridViewTextBoxColumn,
            this.plannedProductionEmployeeDetailsDataGridViewTextBoxColumn,
            this.productionProcesDataGridViewTextBoxColumn});
            this.PlannedProductionGridView.DataSource = this.plannedProductionBindingSource;
            this.PlannedProductionGridView.Location = new System.Drawing.Point(12, 119);
            this.PlannedProductionGridView.Name = "PlannedProductionGridView";
            this.PlannedProductionGridView.RowTemplate.Height = 24;
            this.PlannedProductionGridView.Size = new System.Drawing.Size(1043, 316);
            this.PlannedProductionGridView.TabIndex = 0;
            this.PlannedProductionGridView.SelectionChanged += new System.EventHandler(this.PlannedProductionGridView_SelectionChanged);
            // 
            // idPlanDataGridViewTextBoxColumn
            // 
            this.idPlanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idPlanDataGridViewTextBoxColumn.DataPropertyName = "IdPlan";
            this.idPlanDataGridViewTextBoxColumn.HeaderText = "Nr. Planu";
            this.idPlanDataGridViewTextBoxColumn.Name = "idPlanDataGridViewTextBoxColumn";
            // 
            // idDetailDataGridViewTextBoxColumn
            // 
            this.idDetailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDetailDataGridViewTextBoxColumn.DataPropertyName = "IdDetail";
            this.idDetailDataGridViewTextBoxColumn.HeaderText = "Detal zamówienia";
            this.idDetailDataGridViewTextBoxColumn.Name = "idDetailDataGridViewTextBoxColumn";
            // 
            // idMachineDataGridViewTextBoxColumn
            // 
            this.idMachineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idMachineDataGridViewTextBoxColumn.DataPropertyName = "IdMachine";
            this.idMachineDataGridViewTextBoxColumn.HeaderText = "Maszyna";
            this.idMachineDataGridViewTextBoxColumn.Name = "idMachineDataGridViewTextBoxColumn";
            // 
            // plannedStartdDataGridViewTextBoxColumn
            // 
            this.plannedStartdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plannedStartdDataGridViewTextBoxColumn.DataPropertyName = "PlannedStartd";
            this.plannedStartdDataGridViewTextBoxColumn.HeaderText = "Planowany poczatek";
            this.plannedStartdDataGridViewTextBoxColumn.Name = "plannedStartdDataGridViewTextBoxColumn";
            // 
            // plannedEnddDataGridViewTextBoxColumn
            // 
            this.plannedEnddDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.plannedEnddDataGridViewTextBoxColumn.DataPropertyName = "PlannedEndd";
            this.plannedEnddDataGridViewTextBoxColumn.HeaderText = "Planowany koniec";
            this.plannedEnddDataGridViewTextBoxColumn.Name = "plannedEnddDataGridViewTextBoxColumn";
            // 
            // inproductionDataGridViewTextBoxColumn
            // 
            this.inproductionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inproductionDataGridViewTextBoxColumn.DataPropertyName = "Inproduction";
            this.inproductionDataGridViewTextBoxColumn.HeaderText = "Przekazano do produkcji?";
            this.inproductionDataGridViewTextBoxColumn.Name = "inproductionDataGridViewTextBoxColumn";
            // 
            // orderDetailDataGridViewTextBoxColumn
            // 
            this.orderDetailDataGridViewTextBoxColumn.DataPropertyName = "OrderDetail";
            this.orderDetailDataGridViewTextBoxColumn.HeaderText = "OrderDetail";
            this.orderDetailDataGridViewTextBoxColumn.Name = "orderDetailDataGridViewTextBoxColumn";
            this.orderDetailDataGridViewTextBoxColumn.Visible = false;
            // 
            // orderDetail1DataGridViewTextBoxColumn
            // 
            this.orderDetail1DataGridViewTextBoxColumn.DataPropertyName = "OrderDetail1";
            this.orderDetail1DataGridViewTextBoxColumn.HeaderText = "OrderDetail1";
            this.orderDetail1DataGridViewTextBoxColumn.Name = "orderDetail1DataGridViewTextBoxColumn";
            this.orderDetail1DataGridViewTextBoxColumn.Visible = false;
            // 
            // plannedProductionEmployeeDetailsDataGridViewTextBoxColumn
            // 
            this.plannedProductionEmployeeDetailsDataGridViewTextBoxColumn.DataPropertyName = "PlannedProductionEmployeeDetails";
            this.plannedProductionEmployeeDetailsDataGridViewTextBoxColumn.HeaderText = "PlannedProductionEmployeeDetails";
            this.plannedProductionEmployeeDetailsDataGridViewTextBoxColumn.Name = "plannedProductionEmployeeDetailsDataGridViewTextBoxColumn";
            this.plannedProductionEmployeeDetailsDataGridViewTextBoxColumn.Visible = false;
            // 
            // productionProcesDataGridViewTextBoxColumn
            // 
            this.productionProcesDataGridViewTextBoxColumn.DataPropertyName = "ProductionProces";
            this.productionProcesDataGridViewTextBoxColumn.HeaderText = "ProductionProces";
            this.productionProcesDataGridViewTextBoxColumn.Name = "productionProcesDataGridViewTextBoxColumn";
            this.productionProcesDataGridViewTextBoxColumn.Visible = false;
            // 
            // plannedProductionBindingSource
            // 
            this.plannedProductionBindingSource.DataSource = typeof(KWZP2019.PlannedProduction);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Szukaj planu:";
            // 
            // txtBoxPlanSearch
            // 
            this.txtBoxPlanSearch.Location = new System.Drawing.Point(486, 70);
            this.txtBoxPlanSearch.Name = "txtBoxPlanSearch";
            this.txtBoxPlanSearch.Size = new System.Drawing.Size(166, 22);
            this.txtBoxPlanSearch.TabIndex = 2;
            this.txtBoxPlanSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPlanSearch_KeyPress);
            // 
            // btnAddPlan
            // 
            this.btnAddPlan.Location = new System.Drawing.Point(12, 62);
            this.btnAddPlan.Name = "btnAddPlan";
            this.btnAddPlan.Size = new System.Drawing.Size(215, 39);
            this.btnAddPlan.TabIndex = 3;
            this.btnAddPlan.Text = "Nowy plan /edytuj plan";
            this.btnAddPlan.UseVisualStyleBackColor = true;
            this.btnAddPlan.Click += new System.EventHandler(this.btnAddPlan_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(929, 441);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(126, 39);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "POWRÓT";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(231, 441);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(201, 39);
            this.btnEmployee.TabIndex = 7;
            this.btnEmployee.Text = "Pracownicy wykonujący";
            this.btnEmployee.UseVisualStyleBackColor = true;
            // 
            // btnMachineDet
            // 
            this.btnMachineDet.Location = new System.Drawing.Point(12, 441);
            this.btnMachineDet.Name = "btnMachineDet";
            this.btnMachineDet.Size = new System.Drawing.Size(213, 39);
            this.btnMachineDet.TabIndex = 6;
            this.btnMachineDet.Text = "Szczegóły maszyny";
            this.btnMachineDet.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(438, 441);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(129, 39);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = "Zamówienie";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnRefreshPlanList
            // 
            this.btnRefreshPlanList.Location = new System.Drawing.Point(690, 65);
            this.btnRefreshPlanList.Name = "btnRefreshPlanList";
            this.btnRefreshPlanList.Size = new System.Drawing.Size(129, 39);
            this.btnRefreshPlanList.TabIndex = 9;
            this.btnRefreshPlanList.Text = "Odśwież listę";
            this.btnRefreshPlanList.UseVisualStyleBackColor = true;
            this.btnRefreshPlanList.Click += new System.EventHandler(this.btnRefreshPlanList_Click);
            // 
            // ProductionPlanned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 499);
            this.Controls.Add(this.btnRefreshPlanList);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnMachineDet);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddPlan);
            this.Controls.Add(this.txtBoxPlanSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlannedProductionGridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductionPlanned";
            this.Text = "Planowana produkcja";
            this.Load += new System.EventHandler(this.ProductionPlanned_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlannedProductionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannedProductionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PlannedProductionGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMachineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedStartdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedEnddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inproductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetail1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedProductionEmployeeDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionProcesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource plannedProductionBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPlanSearch;
        private System.Windows.Forms.Button btnAddPlan;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnMachineDet;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnRefreshPlanList;
    }
}