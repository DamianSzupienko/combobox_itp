namespace KWZP2019
{
    partial class AddEmployee
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblHouseNumber = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblApartmentNumber = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblPESEL = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbZipCode = new System.Windows.Forms.TextBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.tbHouseNumber = new System.Windows.Forms.TextBox();
            this.tbApartmentNumber = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbPESEL = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControlContractLenght = new System.Windows.Forms.TabControl();
            this.ContractLenght = new System.Windows.Forms.TabPage();
            this.lblContractLenght = new System.Windows.Forms.Label();
            this.tbContractLenght = new System.Windows.Forms.TextBox();
            this.Dates = new System.Windows.Forms.TabPage();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.tabControlContractLenght.SuspendLayout();
            this.ContractLenght.SuspendLayout();
            this.Dates.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(38, 19);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(26, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Imię";
            this.lblFirstName.Click += new System.EventHandler(this.lblFirstName_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(38, 68);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(53, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Nazwisko";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(38, 113);
            this.lblZipCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(75, 13);
            this.lblZipCode.TabIndex = 2;
            this.lblZipCode.Text = "Kod Pocztowy";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(38, 155);
            this.lblCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(38, 13);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "Miasto";
            // 
            // lblHouseNumber
            // 
            this.lblHouseNumber.AutoSize = true;
            this.lblHouseNumber.Location = new System.Drawing.Point(38, 223);
            this.lblHouseNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHouseNumber.Name = "lblHouseNumber";
            this.lblHouseNumber.Size = new System.Drawing.Size(69, 13);
            this.lblHouseNumber.TabIndex = 3;
            this.lblHouseNumber.Text = "Numer Domu";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(38, 193);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(31, 13);
            this.lblStreet.TabIndex = 3;
            this.lblStreet.Text = "Ulica";
            // 
            // lblApartmentNumber
            // 
            this.lblApartmentNumber.AutoSize = true;
            this.lblApartmentNumber.Location = new System.Drawing.Point(38, 259);
            this.lblApartmentNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApartmentNumber.Name = "lblApartmentNumber";
            this.lblApartmentNumber.Size = new System.Drawing.Size(73, 13);
            this.lblApartmentNumber.TabIndex = 4;
            this.lblApartmentNumber.Text = "Numer Lokalu";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(38, 291);
            this.lblPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(83, 13);
            this.lblPhoneNumber.TabIndex = 5;
            this.lblPhoneNumber.Text = "Numer Telefonu";
            // 
            // lblPESEL
            // 
            this.lblPESEL.AutoSize = true;
            this.lblPESEL.Location = new System.Drawing.Point(38, 328);
            this.lblPESEL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPESEL.Name = "lblPESEL";
            this.lblPESEL.Size = new System.Drawing.Size(41, 13);
            this.lblPESEL.TabIndex = 6;
            this.lblPESEL.Text = "PESEL";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(196, 19);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(138, 20);
            this.tbFirstName.TabIndex = 7;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(196, 64);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(138, 20);
            this.tbLastName.TabIndex = 8;
            // 
            // tbZipCode
            // 
            this.tbZipCode.Location = new System.Drawing.Point(196, 109);
            this.tbZipCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbZipCode.Name = "tbZipCode";
            this.tbZipCode.Size = new System.Drawing.Size(138, 20);
            this.tbZipCode.TabIndex = 9;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(196, 151);
            this.tbCity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(138, 20);
            this.tbCity.TabIndex = 10;
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(196, 189);
            this.tbStreet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(138, 20);
            this.tbStreet.TabIndex = 11;
            // 
            // tbHouseNumber
            // 
            this.tbHouseNumber.Location = new System.Drawing.Point(196, 219);
            this.tbHouseNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbHouseNumber.Name = "tbHouseNumber";
            this.tbHouseNumber.Size = new System.Drawing.Size(138, 20);
            this.tbHouseNumber.TabIndex = 12;
            // 
            // tbApartmentNumber
            // 
            this.tbApartmentNumber.Location = new System.Drawing.Point(196, 259);
            this.tbApartmentNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbApartmentNumber.Name = "tbApartmentNumber";
            this.tbApartmentNumber.Size = new System.Drawing.Size(138, 20);
            this.tbApartmentNumber.TabIndex = 13;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(196, 291);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(138, 20);
            this.tbPhoneNumber.TabIndex = 14;
            // 
            // tbPESEL
            // 
            this.tbPESEL.Location = new System.Drawing.Point(196, 324);
            this.tbPESEL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPESEL.Name = "tbPESEL";
            this.tbPESEL.Size = new System.Drawing.Size(138, 20);
            this.tbPESEL.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(452, 291);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 46);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(452, 240);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 46);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Wyczyść";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(452, 189);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 46);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Wyjdź";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabControlContractLenght
            // 
            this.tabControlContractLenght.Controls.Add(this.ContractLenght);
            this.tabControlContractLenght.Controls.Add(this.Dates);
            this.tabControlContractLenght.Location = new System.Drawing.Point(409, 10);
            this.tabControlContractLenght.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControlContractLenght.Name = "tabControlContractLenght";
            this.tabControlContractLenght.SelectedIndex = 0;
            this.tabControlContractLenght.Size = new System.Drawing.Size(182, 172);
            this.tabControlContractLenght.TabIndex = 19;
            // 
            // ContractLenght
            // 
            this.ContractLenght.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ContractLenght.Controls.Add(this.lblContractLenght);
            this.ContractLenght.Controls.Add(this.tbContractLenght);
            this.ContractLenght.Location = new System.Drawing.Point(4, 22);
            this.ContractLenght.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContractLenght.Name = "ContractLenght";
            this.ContractLenght.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ContractLenght.Size = new System.Drawing.Size(174, 146);
            this.ContractLenght.TabIndex = 0;
            this.ContractLenght.Text = "Długość Umowy";
            // 
            // lblContractLenght
            // 
            this.lblContractLenght.AutoSize = true;
            this.lblContractLenght.Location = new System.Drawing.Point(11, 25);
            this.lblContractLenght.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContractLenght.Name = "lblContractLenght";
            this.lblContractLenght.Size = new System.Drawing.Size(84, 13);
            this.lblContractLenght.TabIndex = 1;
            this.lblContractLenght.Text = "Dlugość Umowy";
            // 
            // tbContractLenght
            // 
            this.tbContractLenght.Location = new System.Drawing.Point(11, 50);
            this.tbContractLenght.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbContractLenght.Name = "tbContractLenght";
            this.tbContractLenght.Size = new System.Drawing.Size(146, 20);
            this.tbContractLenght.TabIndex = 0;
            // 
            // Dates
            // 
            this.Dates.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Dates.Controls.Add(this.dateTimePickerEndDate);
            this.Dates.Controls.Add(this.lblEndDate);
            this.Dates.Controls.Add(this.dateTimePickerStartDate);
            this.Dates.Controls.Add(this.lblStartDate);
            this.Dates.Location = new System.Drawing.Point(4, 22);
            this.Dates.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dates.Name = "Dates";
            this.Dates.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dates.Size = new System.Drawing.Size(174, 146);
            this.Dates.TabIndex = 1;
            this.Dates.Text = "Daty Od i Do";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(12, 112);
            this.dateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerEndDate.TabIndex = 3;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(10, 89);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(143, 13);
            this.lblEndDate.TabIndex = 2;
            this.lblEndDate.Text = "Koniec Umowy (yyyy-MM-dd)";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(12, 41);
            this.dateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerStartDate.TabIndex = 1;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(10, 17);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(155, 13);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Początek Umowy (yyyy-MM-dd)";
            // 
            // AddEmployee
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.tabControlContractLenght);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbPESEL);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbApartmentNumber);
            this.Controls.Add(this.tbHouseNumber);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.tbCity);
            this.Controls.Add(this.tbZipCode);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lblPESEL);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblApartmentNumber);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblHouseNumber);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblZipCode);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddEmployee";
            this.Text = "Dodaj Pracownika";
            this.tabControlContractLenght.ResumeLayout(false);
            this.ContractLenght.ResumeLayout(false);
            this.ContractLenght.PerformLayout();
            this.Dates.ResumeLayout(false);
            this.Dates.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblHouseNumber;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblApartmentNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblPESEL;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbZipCode;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.TextBox tbHouseNumber;
        private System.Windows.Forms.TextBox tbApartmentNumber;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbPESEL;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControlContractLenght;
        private System.Windows.Forms.TabPage ContractLenght;
        private System.Windows.Forms.Label lblContractLenght;
        private System.Windows.Forms.TextBox tbContractLenght;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TabPage Dates;
    }
}