namespace KWZP2019
{
    partial class AddTraining
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
            this.dataGridViewTrainings = new System.Windows.Forms.DataGridView();
            this.TrainingName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTrainingName = new System.Windows.Forms.Label();
            this.tbTrainingName = new System.Windows.Forms.TextBox();
            this.lblTrainingStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerTrainingStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTrainingEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblTrainingEndDate = new System.Windows.Forms.Label();
            this.lblEmployeeFirstName = new System.Windows.Forms.Label();
            this.tbEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.tbEmployeeLastName = new System.Windows.Forms.TextBox();
            this.lblEmployeeLastName = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainings)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTrainings
            // 
            this.dataGridViewTrainings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrainings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TrainingName,
            this.StartDate,
            this.EndDate,
            this.EmployeeFirstName,
            this.EmployeeLastName});
            this.dataGridViewTrainings.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewTrainings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewTrainings.Name = "dataGridViewTrainings";
            this.dataGridViewTrainings.RowHeadersVisible = false;
            this.dataGridViewTrainings.RowTemplate.Height = 24;
            this.dataGridViewTrainings.Size = new System.Drawing.Size(377, 310);
            this.dataGridViewTrainings.TabIndex = 0;
            // 
            // TrainingName
            // 
            this.TrainingName.HeaderText = "Nazwa szkolenia";
            this.TrainingName.Name = "TrainingName";
            // 
            // StartDate
            // 
            this.StartDate.HeaderText = "Początek";
            this.StartDate.Name = "StartDate";
            // 
            // EndDate
            // 
            this.EndDate.HeaderText = "Koniec";
            this.EndDate.Name = "EndDate";
            // 
            // EmployeeFirstName
            // 
            this.EmployeeFirstName.HeaderText = "Imię Pracownika";
            this.EmployeeFirstName.Name = "EmployeeFirstName";
            // 
            // EmployeeLastName
            // 
            this.EmployeeLastName.HeaderText = "Nazwisko Pracownika";
            this.EmployeeLastName.Name = "EmployeeLastName";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(416, 322);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 34);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(476, 322);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 34);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblTrainingName
            // 
            this.lblTrainingName.AutoSize = true;
            this.lblTrainingName.Location = new System.Drawing.Point(427, 28);
            this.lblTrainingName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrainingName.Name = "lblTrainingName";
            this.lblTrainingName.Size = new System.Drawing.Size(87, 13);
            this.lblTrainingName.TabIndex = 3;
            this.lblTrainingName.Text = "Nazwa szkolenia";
            // 
            // tbTrainingName
            // 
            this.tbTrainingName.Location = new System.Drawing.Point(429, 44);
            this.tbTrainingName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTrainingName.Name = "tbTrainingName";
            this.tbTrainingName.Size = new System.Drawing.Size(76, 20);
            this.tbTrainingName.TabIndex = 4;
            // 
            // lblTrainingStartDate
            // 
            this.lblTrainingStartDate.AutoSize = true;
            this.lblTrainingStartDate.Location = new System.Drawing.Point(427, 86);
            this.lblTrainingStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrainingStartDate.Name = "lblTrainingStartDate";
            this.lblTrainingStartDate.Size = new System.Drawing.Size(99, 13);
            this.lblTrainingStartDate.TabIndex = 5;
            this.lblTrainingStartDate.Text = "Początek szkolenia";
            // 
            // dateTimePickerTrainingStartDate
            // 
            this.dateTimePickerTrainingStartDate.Location = new System.Drawing.Point(429, 102);
            this.dateTimePickerTrainingStartDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerTrainingStartDate.Name = "dateTimePickerTrainingStartDate";
            this.dateTimePickerTrainingStartDate.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerTrainingStartDate.TabIndex = 6;
            // 
            // dateTimePickerTrainingEndDate
            // 
            this.dateTimePickerTrainingEndDate.Location = new System.Drawing.Point(429, 155);
            this.dateTimePickerTrainingEndDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerTrainingEndDate.Name = "dateTimePickerTrainingEndDate";
            this.dateTimePickerTrainingEndDate.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerTrainingEndDate.TabIndex = 7;
            // 
            // lblTrainingEndDate
            // 
            this.lblTrainingEndDate.AutoSize = true;
            this.lblTrainingEndDate.Location = new System.Drawing.Point(429, 136);
            this.lblTrainingEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrainingEndDate.Name = "lblTrainingEndDate";
            this.lblTrainingEndDate.Size = new System.Drawing.Size(87, 13);
            this.lblTrainingEndDate.TabIndex = 8;
            this.lblTrainingEndDate.Text = "Koniec szkolenia";
            // 
            // lblEmployeeFirstName
            // 
            this.lblEmployeeFirstName.AutoSize = true;
            this.lblEmployeeFirstName.Location = new System.Drawing.Point(429, 192);
            this.lblEmployeeFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeFirstName.Name = "lblEmployeeFirstName";
            this.lblEmployeeFirstName.Size = new System.Drawing.Size(84, 13);
            this.lblEmployeeFirstName.TabIndex = 9;
            this.lblEmployeeFirstName.Text = "Imię pracownika";
            // 
            // tbEmployeeFirstName
            // 
            this.tbEmployeeFirstName.Location = new System.Drawing.Point(431, 209);
            this.tbEmployeeFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEmployeeFirstName.Name = "tbEmployeeFirstName";
            this.tbEmployeeFirstName.Size = new System.Drawing.Size(76, 20);
            this.tbEmployeeFirstName.TabIndex = 10;
            // 
            // tbEmployeeLastName
            // 
            this.tbEmployeeLastName.Location = new System.Drawing.Point(431, 258);
            this.tbEmployeeLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEmployeeLastName.Name = "tbEmployeeLastName";
            this.tbEmployeeLastName.Size = new System.Drawing.Size(76, 20);
            this.tbEmployeeLastName.TabIndex = 11;
            // 
            // lblEmployeeLastName
            // 
            this.lblEmployeeLastName.AutoSize = true;
            this.lblEmployeeLastName.Location = new System.Drawing.Point(431, 240);
            this.lblEmployeeLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmployeeLastName.Name = "lblEmployeeLastName";
            this.lblEmployeeLastName.Size = new System.Drawing.Size(111, 13);
            this.lblEmployeeLastName.TabIndex = 12;
            this.lblEmployeeLastName.Text = "Nazwisko pracownika";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(537, 322);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 34);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // AddTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblEmployeeLastName);
            this.Controls.Add(this.tbEmployeeLastName);
            this.Controls.Add(this.tbEmployeeFirstName);
            this.Controls.Add(this.lblEmployeeFirstName);
            this.Controls.Add(this.lblTrainingEndDate);
            this.Controls.Add(this.dateTimePickerTrainingEndDate);
            this.Controls.Add(this.dateTimePickerTrainingStartDate);
            this.Controls.Add(this.lblTrainingStartDate);
            this.Controls.Add(this.tbTrainingName);
            this.Controls.Add(this.lblTrainingName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewTrainings);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddTraining";
            this.Text = "AddTraining";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrainings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTrainings;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrainingName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeLastName;
        private System.Windows.Forms.Label lblTrainingName;
        private System.Windows.Forms.TextBox tbTrainingName;
        private System.Windows.Forms.Label lblTrainingStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTrainingStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTrainingEndDate;
        private System.Windows.Forms.Label lblTrainingEndDate;
        private System.Windows.Forms.Label lblEmployeeFirstName;
        private System.Windows.Forms.TextBox tbEmployeeFirstName;
        private System.Windows.Forms.TextBox tbEmployeeLastName;
        private System.Windows.Forms.Label lblEmployeeLastName;
        private System.Windows.Forms.Button btnEdit;
    }
}