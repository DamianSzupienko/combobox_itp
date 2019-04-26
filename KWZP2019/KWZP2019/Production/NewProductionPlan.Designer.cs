namespace KWZP2019
{
    partial class NewProductionPlan
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
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxMachine = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxPlanNr = new System.Windows.Forms.TextBox();
            this.dateTimeStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cBoxIntoProduction = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.viewProcessEmpl = new System.Windows.Forms.DataGridView();
            this.lblOperators = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cBoxEmployee = new System.Windows.Forms.ComboBox();
            this.btnNewPlan = new System.Windows.Forms.Button();
            this.viewOrderDetail = new System.Windows.Forms.DataGridView();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.btnEndDateCalculate = new System.Windows.Forms.Button();
            this.idDetailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vUnhandledOrderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProcesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedProductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedProductionEmployeeDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.machineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.viewProcessEmpl)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vUnhandledOrderDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannedProductionEmployeeDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.machineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Location = new System.Drawing.Point(442, 17);
            this.btnAddEmp.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(68, 28);
            this.btnAddEmp.TabIndex = 0;
            this.btnAddEmp.Text = "DODAJ";
            this.btnAddEmp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Szczegół zamówienia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Przydzielona maszyna";
            // 
            // cBoxMachine
            // 
            this.cBoxMachine.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.machineBindingSource, "IdMachine", true));
            this.cBoxMachine.FormattingEnabled = true;
            this.cBoxMachine.Location = new System.Drawing.Point(170, 242);
            this.cBoxMachine.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxMachine.Name = "cBoxMachine";
            this.cBoxMachine.Size = new System.Drawing.Size(168, 21);
            this.cBoxMachine.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 285);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data zamówienia";
            // 
            // tBoxPlanNr
            // 
            this.tBoxPlanNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBoxPlanNr.Location = new System.Drawing.Point(358, 10);
            this.tBoxPlanNr.Margin = new System.Windows.Forms.Padding(2);
            this.tBoxPlanNr.Name = "tBoxPlanNr";
            this.tBoxPlanNr.Size = new System.Drawing.Size(76, 32);
            this.tBoxPlanNr.TabIndex = 7;
            // 
            // dateTimeStart
            // 
            this.dateTimeStart.AllowDrop = true;
            this.dateTimeStart.Location = new System.Drawing.Point(776, 285);
            this.dateTimeStart.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeStart.Name = "dateTimeStart";
            this.dateTimeStart.Size = new System.Drawing.Size(199, 20);
            this.dateTimeStart.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 324);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Szacowana data realizacji";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(776, 324);
            this.dateTimeEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(199, 20);
            this.dateTimeEnd.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(122, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Numer planu produkcji:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(329, 376);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 28);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "ZAPISZ";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(329, 422);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(68, 28);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "POWRÓT";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cBoxIntoProduction
            // 
            this.cBoxIntoProduction.AutoSize = true;
            this.cBoxIntoProduction.Location = new System.Drawing.Point(238, 431);
            this.cBoxIntoProduction.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxIntoProduction.Name = "cBoxIntoProduction";
            this.cBoxIntoProduction.Size = new System.Drawing.Size(15, 14);
            this.cBoxIntoProduction.TabIndex = 15;
            this.cBoxIntoProduction.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 430);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Przekazano do produkcji?";
            // 
            // viewProcessEmpl
            // 
            this.viewProcessEmpl.AutoGenerateColumns = false;
            this.viewProcessEmpl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewProcessEmpl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetailDataGridViewTextBoxColumn,
            this.idProcesDataGridViewTextBoxColumn,
            this.idEmployeeDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.plannedProductionDataGridViewTextBoxColumn,
            this.allocationDataGridViewTextBoxColumn});
            this.viewProcessEmpl.DataSource = this.plannedProductionEmployeeDetailBindingSource;
            this.viewProcessEmpl.Location = new System.Drawing.Point(603, 90);
            this.viewProcessEmpl.Margin = new System.Windows.Forms.Padding(2);
            this.viewProcessEmpl.Name = "viewProcessEmpl";
            this.viewProcessEmpl.RowTemplate.Height = 24;
            this.viewProcessEmpl.Size = new System.Drawing.Size(390, 181);
            this.viewProcessEmpl.TabIndex = 17;
            // 
            // lblOperators
            // 
            this.lblOperators.AutoSize = true;
            this.lblOperators.Location = new System.Drawing.Point(601, 65);
            this.lblOperators.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOperators.Name = "lblOperators";
            this.lblOperators.Size = new System.Drawing.Size(119, 13);
            this.lblOperators.TabIndex = 18;
            this.lblOperators.Text = "Przydzieleni pracownicy";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.dateTimePicker4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dateTimePicker3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cBoxEmployee);
            this.groupBox1.Controls.Add(this.btnAddEmp);
            this.groupBox1.Location = new System.Drawing.Point(457, 369);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(544, 81);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodawanie pracowników";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Pracownik";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(442, 48);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(68, 28);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.Text = "USUŃ";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(260, 54);
            this.dateTimePicker4.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker4.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Data zakończenia";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(260, 31);
            this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(151, 20);
            this.dateTimePicker3.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Data rozpoczęcia";
            // 
            // cBoxEmployee
            // 
            this.cBoxEmployee.FormattingEnabled = true;
            this.cBoxEmployee.Location = new System.Drawing.Point(4, 48);
            this.cBoxEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxEmployee.Name = "cBoxEmployee";
            this.cBoxEmployee.Size = new System.Drawing.Size(146, 21);
            this.cBoxEmployee.TabIndex = 5;
            // 
            // btnNewPlan
            // 
            this.btnNewPlan.Location = new System.Drawing.Point(503, 7);
            this.btnNewPlan.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewPlan.Name = "btnNewPlan";
            this.btnNewPlan.Size = new System.Drawing.Size(76, 33);
            this.btnNewPlan.TabIndex = 21;
            this.btnNewPlan.Text = "NOWY";
            this.btnNewPlan.UseVisualStyleBackColor = true;
            this.btnNewPlan.Click += new System.EventHandler(this.btnNewPlan_Click);
            // 
            // viewOrderDetail
            // 
            this.viewOrderDetail.AutoGenerateColumns = false;
            this.viewOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewOrderDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetailDataGridViewTextBoxColumn1,
            this.quantityDataGridViewTextBoxColumn,
            this.productCodeDataGridViewTextBoxColumn});
            this.viewOrderDetail.DataSource = this.vUnhandledOrderDetailsBindingSource;
            this.viewOrderDetail.Location = new System.Drawing.Point(17, 127);
            this.viewOrderDetail.Margin = new System.Windows.Forms.Padding(2);
            this.viewOrderDetail.Name = "viewOrderDetail";
            this.viewOrderDetail.RowTemplate.Height = 24;
            this.viewOrderDetail.Size = new System.Drawing.Size(416, 82);
            this.viewOrderDetail.TabIndex = 22;
            this.viewOrderDetail.SelectionChanged += new System.EventHandler(this.viewOrderDetail_SelectionChanged);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // btnEndDateCalculate
            // 
            this.btnEndDateCalculate.Location = new System.Drawing.Point(412, 314);
            this.btnEndDateCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnEndDateCalculate.Name = "btnEndDateCalculate";
            this.btnEndDateCalculate.Size = new System.Drawing.Size(167, 28);
            this.btnEndDateCalculate.TabIndex = 23;
            this.btnEndDateCalculate.Text = "OSZACUJ DATĘ KOŃCOWĄ";
            this.btnEndDateCalculate.UseVisualStyleBackColor = true;
            this.btnEndDateCalculate.Click += new System.EventHandler(this.btnEndDateCalculate_Click);
            // 
            // idDetailDataGridViewTextBoxColumn1
            // 
            this.idDetailDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idDetailDataGridViewTextBoxColumn1.DataPropertyName = "IdDetail";
            this.idDetailDataGridViewTextBoxColumn1.HeaderText = "Nr szczegółu";
            this.idDetailDataGridViewTextBoxColumn1.Name = "idDetailDataGridViewTextBoxColumn1";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Ilosć";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // productCodeDataGridViewTextBoxColumn
            // 
            this.productCodeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productCodeDataGridViewTextBoxColumn.DataPropertyName = "ProductCode";
            this.productCodeDataGridViewTextBoxColumn.HeaderText = "Kod produktu";
            this.productCodeDataGridViewTextBoxColumn.Name = "productCodeDataGridViewTextBoxColumn";
            // 
            // vUnhandledOrderDetailsBindingSource
            // 
            this.vUnhandledOrderDetailsBindingSource.DataSource = typeof(KWZP2019.vUnhandledOrderDetails);
            // 
            // idDetailDataGridViewTextBoxColumn
            // 
            this.idDetailDataGridViewTextBoxColumn.DataPropertyName = "IdDetail";
            this.idDetailDataGridViewTextBoxColumn.HeaderText = "IdDetail";
            this.idDetailDataGridViewTextBoxColumn.Name = "idDetailDataGridViewTextBoxColumn";
            this.idDetailDataGridViewTextBoxColumn.Visible = false;
            // 
            // idProcesDataGridViewTextBoxColumn
            // 
            this.idProcesDataGridViewTextBoxColumn.DataPropertyName = "IdProces";
            this.idProcesDataGridViewTextBoxColumn.HeaderText = "IdProces";
            this.idProcesDataGridViewTextBoxColumn.Name = "idProcesDataGridViewTextBoxColumn";
            this.idProcesDataGridViewTextBoxColumn.Visible = false;
            // 
            // idEmployeeDataGridViewTextBoxColumn
            // 
            this.idEmployeeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idEmployeeDataGridViewTextBoxColumn.DataPropertyName = "IdEmployee";
            this.idEmployeeDataGridViewTextBoxColumn.HeaderText = "IdEmployee";
            this.idEmployeeDataGridViewTextBoxColumn.Name = "idEmployeeDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // plannedProductionDataGridViewTextBoxColumn
            // 
            this.plannedProductionDataGridViewTextBoxColumn.DataPropertyName = "PlannedProduction";
            this.plannedProductionDataGridViewTextBoxColumn.HeaderText = "PlannedProduction";
            this.plannedProductionDataGridViewTextBoxColumn.Name = "plannedProductionDataGridViewTextBoxColumn";
            this.plannedProductionDataGridViewTextBoxColumn.Visible = false;
            // 
            // allocationDataGridViewTextBoxColumn
            // 
            this.allocationDataGridViewTextBoxColumn.DataPropertyName = "Allocation";
            this.allocationDataGridViewTextBoxColumn.HeaderText = "Allocation";
            this.allocationDataGridViewTextBoxColumn.Name = "allocationDataGridViewTextBoxColumn";
            this.allocationDataGridViewTextBoxColumn.Visible = false;
            // 
            // plannedProductionEmployeeDetailBindingSource
            // 
            this.plannedProductionEmployeeDetailBindingSource.DataSource = typeof(KWZP2019.PlannedProductionEmployeeDetail);
            // 
            // machineBindingSource
            // 
            this.machineBindingSource.DataSource = typeof(KWZP2019.Machine);
            // 
            // NewProductionPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 460);
            this.Controls.Add(this.btnEndDateCalculate);
            this.Controls.Add(this.viewOrderDetail);
            this.Controls.Add(this.btnNewPlan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblOperators);
            this.Controls.Add(this.viewProcessEmpl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cBoxIntoProduction);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimeStart);
            this.Controls.Add(this.tBoxPlanNr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxMachine);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewProductionPlan";
            this.Text = "NewProductionPlan";
            this.Load += new System.EventHandler(this.NewProductionPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewProcessEmpl)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vUnhandledOrderDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannedProductionEmployeeDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.machineBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxMachine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxPlanNr;
        private System.Windows.Forms.DateTimePicker dateTimeStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.CheckBox cBoxIntoProduction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView viewProcessEmpl;
        private System.Windows.Forms.BindingSource plannedProductionEmployeeDetailBindingSource;
        private System.Windows.Forms.Label lblOperators;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cBoxEmployee;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProcesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedProductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn allocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNewPlan;
        private System.Windows.Forms.DataGridView viewOrderDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource vUnhandledOrderDetailsBindingSource;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Button btnEndDateCalculate;
        private System.Windows.Forms.BindingSource machineBindingSource;
    }
}