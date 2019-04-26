namespace KWZP2019
{
    partial class HR
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
            this.tbEmployeeSearching = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridViewEmloyees = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PESEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warnings = new System.Windows.Forms.ListBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnExamination = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnTraining = new System.Windows.Forms.Button();
            this.btnAbsences = new System.Windows.Forms.Button();
            this.btnPayChecks = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmloyees)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmployeeSearching
            // 
            this.tbEmployeeSearching.Location = new System.Drawing.Point(31, 20);
            this.tbEmployeeSearching.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEmployeeSearching.Name = "tbEmployeeSearching";
            this.tbEmployeeSearching.Size = new System.Drawing.Size(221, 20);
            this.tbEmployeeSearching.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(265, 20);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 26);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Szukaj";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEmloyees
            // 
            this.dataGridViewEmloyees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmloyees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.Position,
            this.PhoneNumber,
            this.Address,
            this.PESEL});
            this.dataGridViewEmloyees.Location = new System.Drawing.Point(8, 64);
            this.dataGridViewEmloyees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewEmloyees.Name = "dataGridViewEmloyees";
            this.dataGridViewEmloyees.RowHeadersVisible = false;
            this.dataGridViewEmloyees.RowTemplate.Height = 24;
            this.dataGridViewEmloyees.Size = new System.Drawing.Size(358, 265);
            this.dataGridViewEmloyees.TabIndex = 2;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "EmployeeName";
            this.FirstName.HeaderText = "Imię";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "EmployeeSurname";
            this.LastName.HeaderText = "Nazwisko";
            this.LastName.Name = "LastName";
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Stanowisko";
            this.Position.Name = "Position";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Numer telefonu";
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // Address
            // 
            this.Address.DataPropertyName = "City,HouseNumber";
            this.Address.HeaderText = "Adres";
            this.Address.Name = "Address";
            // 
            // PESEL
            // 
            this.PESEL.DataPropertyName = "PESEL";
            this.PESEL.HeaderText = "PESEL";
            this.PESEL.Name = "PESEL";
            // 
            // Warnings
            // 
            this.Warnings.FormattingEnabled = true;
            this.Warnings.Location = new System.Drawing.Point(385, 287);
            this.Warnings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Warnings.Name = "Warnings";
            this.Warnings.Size = new System.Drawing.Size(160, 43);
            this.Warnings.TabIndex = 3;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(439, 20);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(90, 26);
            this.btnDetails.TabIndex = 4;
            this.btnDetails.Text = "Szczegóły";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnExamination
            // 
            this.btnExamination.Location = new System.Drawing.Point(439, 51);
            this.btnExamination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExamination.Name = "btnExamination";
            this.btnExamination.Size = new System.Drawing.Size(90, 30);
            this.btnExamination.TabIndex = 5;
            this.btnExamination.Text = "Badania";
            this.btnExamination.UseVisualStyleBackColor = true;
            this.btnExamination.Click += new System.EventHandler(this.btnExamination_Click);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(439, 86);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(90, 41);
            this.btnAddEmployee.TabIndex = 6;
            this.btnAddEmployee.Text = "Dodaj pracownika";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnTraining
            // 
            this.btnTraining.Location = new System.Drawing.Point(439, 132);
            this.btnTraining.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTraining.Name = "btnTraining";
            this.btnTraining.Size = new System.Drawing.Size(90, 35);
            this.btnTraining.TabIndex = 7;
            this.btnTraining.Text = "Szkolenia";
            this.btnTraining.UseVisualStyleBackColor = true;
            this.btnTraining.Click += new System.EventHandler(this.btnTraining_Click);
            // 
            // btnAbsences
            // 
            this.btnAbsences.Location = new System.Drawing.Point(439, 172);
            this.btnAbsences.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAbsences.Name = "btnAbsences";
            this.btnAbsences.Size = new System.Drawing.Size(90, 30);
            this.btnAbsences.TabIndex = 8;
            this.btnAbsences.Text = "Nieobecności";
            this.btnAbsences.UseVisualStyleBackColor = true;
            this.btnAbsences.Click += new System.EventHandler(this.btnAbsences_Click);
            // 
            // btnPayChecks
            // 
            this.btnPayChecks.Location = new System.Drawing.Point(439, 207);
            this.btnPayChecks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPayChecks.Name = "btnPayChecks";
            this.btnPayChecks.Size = new System.Drawing.Size(90, 35);
            this.btnPayChecks.TabIndex = 9;
            this.btnPayChecks.Text = "Wypłaty";
            this.btnPayChecks.UseVisualStyleBackColor = true;
            // 
            // HR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnPayChecks);
            this.Controls.Add(this.btnAbsences);
            this.Controls.Add(this.btnTraining);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnExamination);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.Warnings);
            this.Controls.Add(this.dataGridViewEmloyees);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbEmployeeSearching);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HR";
            this.Text = "Kadry";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmloyees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmployeeSearching;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridViewEmloyees;
        private System.Windows.Forms.ListBox Warnings;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnExamination;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnTraining;
        private System.Windows.Forms.Button btnAbsences;
        private System.Windows.Forms.Button btnPayChecks;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PESEL;
    }
}