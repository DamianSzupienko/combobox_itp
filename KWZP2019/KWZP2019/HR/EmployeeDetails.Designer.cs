namespace KWZP2019
{
    partial class EmployeeDetails
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
            this.dataGridViewEmployeeDetails = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HouseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApartmentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PESEL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExamination = new System.Windows.Forms.Button();
            this.btnContract = new System.Windows.Forms.Button();
            this.btnEducation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployeeDetails
            // 
            this.dataGridViewEmployeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.ZipCode,
            this.City,
            this.Street,
            this.HouseNumber,
            this.ApartmentNumber,
            this.PhoneNumber,
            this.PESEL});
            this.dataGridViewEmployeeDetails.Location = new System.Drawing.Point(18, 19);
            this.dataGridViewEmployeeDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewEmployeeDetails.Name = "dataGridViewEmployeeDetails";
            this.dataGridViewEmployeeDetails.RowHeadersVisible = false;
            this.dataGridViewEmployeeDetails.RowTemplate.Height = 24;
            this.dataGridViewEmployeeDetails.Size = new System.Drawing.Size(448, 301);
            this.dataGridViewEmployeeDetails.TabIndex = 0;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Imię";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Nazwisko";
            this.LastName.Name = "LastName";
            // 
            // ZipCode
            // 
            this.ZipCode.HeaderText = "Kod Pocztowy";
            this.ZipCode.Name = "ZipCode";
            // 
            // City
            // 
            this.City.HeaderText = "Miasto";
            this.City.Name = "City";
            // 
            // Street
            // 
            this.Street.HeaderText = "Ulica";
            this.Street.Name = "Street";
            // 
            // HouseNumber
            // 
            this.HouseNumber.HeaderText = "Numer domu";
            this.HouseNumber.Name = "HouseNumber";
            // 
            // ApartmentNumber
            // 
            this.ApartmentNumber.HeaderText = "Numer mieszkania";
            this.ApartmentNumber.Name = "ApartmentNumber";
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Numer telefonu";
            this.PhoneNumber.Name = "PhoneNumber";
            // 
            // PESEL
            // 
            this.PESEL.HeaderText = "PESEL";
            this.PESEL.Name = "PESEL";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(500, 47);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnExamination
            // 
            this.btnExamination.Location = new System.Drawing.Point(500, 167);
            this.btnExamination.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExamination.Name = "btnExamination";
            this.btnExamination.Size = new System.Drawing.Size(92, 25);
            this.btnExamination.TabIndex = 2;
            this.btnExamination.Text = "Badania lekarskie";
            this.btnExamination.UseVisualStyleBackColor = true;
            // 
            // btnContract
            // 
            this.btnContract.Location = new System.Drawing.Point(500, 202);
            this.btnContract.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnContract.Name = "btnContract";
            this.btnContract.Size = new System.Drawing.Size(92, 25);
            this.btnContract.TabIndex = 3;
            this.btnContract.Text = "Umowa";
            this.btnContract.UseVisualStyleBackColor = true;
            // 
            // btnEducation
            // 
            this.btnEducation.Location = new System.Drawing.Point(500, 237);
            this.btnEducation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEducation.Name = "btnEducation";
            this.btnEducation.Size = new System.Drawing.Size(92, 25);
            this.btnEducation.TabIndex = 4;
            this.btnEducation.Text = "Wykształcenie";
            this.btnEducation.UseVisualStyleBackColor = true;
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnEducation);
            this.Controls.Add(this.btnContract);
            this.Controls.Add(this.btnExamination);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dataGridViewEmployeeDetails);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EmployeeDetails";
            this.Text = "Employee Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEmployeeDetails;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnExamination;
        private System.Windows.Forms.Button btnContract;
        private System.Windows.Forms.Button btnEducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApartmentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PESEL;
    }
}