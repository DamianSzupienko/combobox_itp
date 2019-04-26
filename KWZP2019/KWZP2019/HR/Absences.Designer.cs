namespace KWZP2019
{
    partial class Absences
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
            this.dataGridViewAbsences = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbAbsenceType = new System.Windows.Forms.ComboBox();
            this.lblAbsenceType = new System.Windows.Forms.Label();
            this.dateTimePickerFirstDay = new System.Windows.Forms.DateTimePicker();
            this.lblFirstDay = new System.Windows.Forms.Label();
            this.dateTimePickerLastDay = new System.Windows.Forms.DateTimePicker();
            this.lblLastDay = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeOfAbsence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAbsences
            // 
            this.dataGridViewAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAbsences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.TypeOfAbsence,
            this.FirstDay,
            this.LastDay});
            this.dataGridViewAbsences.Location = new System.Drawing.Point(31, 29);
            this.dataGridViewAbsences.Name = "dataGridViewAbsences";
            this.dataGridViewAbsences.RowHeadersVisible = false;
            this.dataGridViewAbsences.RowTemplate.Height = 24;
            this.dataGridViewAbsences.Size = new System.Drawing.Size(481, 368);
            this.dataGridViewAbsences.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(603, 371);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 44);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Dodaj";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(96, 403);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // cbAbsenceType
            // 
            this.cbAbsenceType.FormattingEnabled = true;
            this.cbAbsenceType.Location = new System.Drawing.Point(562, 209);
            this.cbAbsenceType.Name = "cbAbsenceType";
            this.cbAbsenceType.Size = new System.Drawing.Size(121, 24);
            this.cbAbsenceType.TabIndex = 3;
            // 
            // lblAbsenceType
            // 
            this.lblAbsenceType.AutoSize = true;
            this.lblAbsenceType.Location = new System.Drawing.Point(559, 189);
            this.lblAbsenceType.Name = "lblAbsenceType";
            this.lblAbsenceType.Size = new System.Drawing.Size(119, 17);
            this.lblAbsenceType.TabIndex = 4;
            this.lblAbsenceType.Text = "Typ nieobecności";
            // 
            // dateTimePickerFirstDay
            // 
            this.dateTimePickerFirstDay.Location = new System.Drawing.Point(562, 270);
            this.dateTimePickerFirstDay.Name = "dateTimePickerFirstDay";
            this.dateTimePickerFirstDay.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerFirstDay.TabIndex = 5;
            // 
            // lblFirstDay
            // 
            this.lblFirstDay.AutoSize = true;
            this.lblFirstDay.Location = new System.Drawing.Point(559, 250);
            this.lblFirstDay.Name = "lblFirstDay";
            this.lblFirstDay.Size = new System.Drawing.Size(101, 17);
            this.lblFirstDay.TabIndex = 6;
            this.lblFirstDay.Text = "Pierwszy dzień";
            // 
            // dateTimePickerLastDay
            // 
            this.dateTimePickerLastDay.Location = new System.Drawing.Point(562, 325);
            this.dateTimePickerLastDay.Name = "dateTimePickerLastDay";
            this.dateTimePickerLastDay.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerLastDay.TabIndex = 7;
            // 
            // lblLastDay
            // 
            this.lblLastDay.AutoSize = true;
            this.lblLastDay.Location = new System.Drawing.Point(559, 305);
            this.lblLastDay.Name = "lblLastDay";
            this.lblLastDay.Size = new System.Drawing.Size(91, 17);
            this.lblLastDay.TabIndex = 8;
            this.lblLastDay.Text = "Ostatni dzień";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(298, 403);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(139, 35);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edytuj";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(562, 151);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 22);
            this.tbLastName.TabIndex = 10;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(562, 97);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 22);
            this.tbFirstName.TabIndex = 11;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(559, 77);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(33, 17);
            this.lblFirstName.TabIndex = 12;
            this.lblFirstName.Text = "Imię";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(559, 131);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(67, 17);
            this.lblLastName.TabIndex = 13;
            this.lblLastName.Text = "Nazwisko";
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
            // TypeOfAbsence
            // 
            this.TypeOfAbsence.HeaderText = "Typ nieobecności";
            this.TypeOfAbsence.Name = "TypeOfAbsence";
            // 
            // FirstDay
            // 
            this.FirstDay.HeaderText = "Pierwszy dzień";
            this.FirstDay.Name = "FirstDay";
            // 
            // LastDay
            // 
            this.LastDay.HeaderText = "Ostatni dzień";
            this.LastDay.Name = "LastDay";
            // 
            // Absences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblLastDay);
            this.Controls.Add(this.dateTimePickerLastDay);
            this.Controls.Add(this.lblFirstDay);
            this.Controls.Add(this.dateTimePickerFirstDay);
            this.Controls.Add(this.lblAbsenceType);
            this.Controls.Add(this.cbAbsenceType);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewAbsences);
            this.Name = "Absences";
            this.Text = "Absences";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAbsences)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAbsences;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbAbsenceType;
        private System.Windows.Forms.Label lblAbsenceType;
        private System.Windows.Forms.DateTimePicker dateTimePickerFirstDay;
        private System.Windows.Forms.Label lblFirstDay;
        private System.Windows.Forms.DateTimePicker dateTimePickerLastDay;
        private System.Windows.Forms.Label lblLastDay;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeOfAbsence;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastDay;
    }
}