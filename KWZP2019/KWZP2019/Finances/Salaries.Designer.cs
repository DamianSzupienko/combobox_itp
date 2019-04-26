namespace KWZP2019
{
    partial class Salaries
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
            this.lblDay = new System.Windows.Forms.Label();
            this.dtpDay = new System.Windows.Forms.DateTimePicker();
            this.lblPayoutlist = new System.Windows.Forms.Label();
            this.lbNamesurname = new System.Windows.Forms.ListBox();
            this.tbSearchbyemployee = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.tbPaymentforselectedmonth = new System.Windows.Forms.TextBox();
            this.lblPaymentforselectedmonth = new System.Windows.Forms.Label();
            this.btnCountpayments = new System.Windows.Forms.Button();
            this.tbTotalpayments = new System.Windows.Forms.TextBox();
            this.lblTotalpayments = new System.Windows.Forms.Label();
            this.gbByemployee = new System.Windows.Forms.GroupBox();
            this.lblSearchbyemployee = new System.Windows.Forms.Label();
            this.gbByemployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(9, 23);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(37, 13);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "Dzień:";
            // 
            // dtpDay
            // 
            this.dtpDay.Location = new System.Drawing.Point(55, 17);
            this.dtpDay.Name = "dtpDay";
            this.dtpDay.Size = new System.Drawing.Size(191, 20);
            this.dtpDay.TabIndex = 1;
            // 
            // lblPayoutlist
            // 
            this.lblPayoutlist.AutoSize = true;
            this.lblPayoutlist.Location = new System.Drawing.Point(12, 65);
            this.lblPayoutlist.Name = "lblPayoutlist";
            this.lblPayoutlist.Size = new System.Drawing.Size(67, 13);
            this.lblPayoutlist.TabIndex = 3;
            this.lblPayoutlist.Text = "Lista wypłat:";
            // 
            // lbNamesurname
            // 
            this.lbNamesurname.FormattingEnabled = true;
            this.lbNamesurname.Location = new System.Drawing.Point(12, 81);
            this.lbNamesurname.Name = "lbNamesurname";
            this.lbNamesurname.Size = new System.Drawing.Size(200, 173);
            this.lbNamesurname.TabIndex = 4;
            // 
            // tbSearchbyemployee
            // 
            this.tbSearchbyemployee.Location = new System.Drawing.Point(19, 38);
            this.tbSearchbyemployee.Name = "tbSearchbyemployee";
            this.tbSearchbyemployee.Size = new System.Drawing.Size(260, 20);
            this.tbSearchbyemployee.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(19, 64);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(260, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "WYSZUKAJ";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(121, 104);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(158, 20);
            this.tbName.TabIndex = 7;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(121, 130);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.ReadOnly = true;
            this.tbSurname.Size = new System.Drawing.Size(158, 20);
            this.tbSurname.TabIndex = 8;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 107);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 13);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Imię:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(16, 133);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(56, 13);
            this.lblSurname.TabIndex = 10;
            this.lblSurname.Text = "Nazwisko:";
            // 
            // tbPaymentforselectedmonth
            // 
            this.tbPaymentforselectedmonth.Location = new System.Drawing.Point(121, 185);
            this.tbPaymentforselectedmonth.Name = "tbPaymentforselectedmonth";
            this.tbPaymentforselectedmonth.ReadOnly = true;
            this.tbPaymentforselectedmonth.Size = new System.Drawing.Size(158, 20);
            this.tbPaymentforselectedmonth.TabIndex = 11;
            // 
            // lblPaymentforselectedmonth
            // 
            this.lblPaymentforselectedmonth.AutoSize = true;
            this.lblPaymentforselectedmonth.Location = new System.Drawing.Point(118, 169);
            this.lblPaymentforselectedmonth.Name = "lblPaymentforselectedmonth";
            this.lblPaymentforselectedmonth.Size = new System.Drawing.Size(145, 13);
            this.lblPaymentforselectedmonth.TabIndex = 12;
            this.lblPaymentforselectedmonth.Text = "Wypłata za wybrany miesiąc:";
            // 
            // btnCountpayments
            // 
            this.btnCountpayments.Location = new System.Drawing.Point(12, 260);
            this.btnCountpayments.Name = "btnCountpayments";
            this.btnCountpayments.Size = new System.Drawing.Size(500, 23);
            this.btnCountpayments.TabIndex = 13;
            this.btnCountpayments.Text = "PODLICZ WYPŁATY";
            this.btnCountpayments.UseVisualStyleBackColor = true;
            // 
            // tbTotalpayments
            // 
            this.tbTotalpayments.Location = new System.Drawing.Point(180, 299);
            this.tbTotalpayments.Name = "tbTotalpayments";
            this.tbTotalpayments.ReadOnly = true;
            this.tbTotalpayments.Size = new System.Drawing.Size(158, 20);
            this.tbTotalpayments.TabIndex = 14;
            // 
            // lblTotalpayments
            // 
            this.lblTotalpayments.AutoSize = true;
            this.lblTotalpayments.Location = new System.Drawing.Point(102, 302);
            this.lblTotalpayments.Name = "lblTotalpayments";
            this.lblTotalpayments.Size = new System.Drawing.Size(72, 13);
            this.lblTotalpayments.TabIndex = 15;
            this.lblTotalpayments.Text = "Suma wypłat:";
            // 
            // gbByemployee
            // 
            this.gbByemployee.Controls.Add(this.btnSearch);
            this.gbByemployee.Controls.Add(this.lblSearchbyemployee);
            this.gbByemployee.Controls.Add(this.tbSearchbyemployee);
            this.gbByemployee.Controls.Add(this.lblPaymentforselectedmonth);
            this.gbByemployee.Controls.Add(this.tbName);
            this.gbByemployee.Controls.Add(this.tbPaymentforselectedmonth);
            this.gbByemployee.Controls.Add(this.tbSurname);
            this.gbByemployee.Controls.Add(this.lblSurname);
            this.gbByemployee.Controls.Add(this.lblName);
            this.gbByemployee.Location = new System.Drawing.Point(218, 43);
            this.gbByemployee.Name = "gbByemployee";
            this.gbByemployee.Size = new System.Drawing.Size(294, 211);
            this.gbByemployee.TabIndex = 16;
            this.gbByemployee.TabStop = false;
            this.gbByemployee.Text = "Według pracownika:";
            // 
            // lblSearchbyemployee
            // 
            this.lblSearchbyemployee.AutoSize = true;
            this.lblSearchbyemployee.Location = new System.Drawing.Point(19, 22);
            this.lblSearchbyemployee.Name = "lblSearchbyemployee";
            this.lblSearchbyemployee.Size = new System.Drawing.Size(129, 13);
            this.lblSearchbyemployee.TabIndex = 2;
            this.lblSearchbyemployee.Text = "Wyszukaj po pracowniku:";
            // 
            // salaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 331);
            this.Controls.Add(this.lblTotalpayments);
            this.Controls.Add(this.tbTotalpayments);
            this.Controls.Add(this.btnCountpayments);
            this.Controls.Add(this.lbNamesurname);
            this.Controls.Add(this.lblPayoutlist);
            this.Controls.Add(this.dtpDay);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.gbByemployee);
            this.Name = "salaries";
            this.Text = "Wypłaty";
            this.gbByemployee.ResumeLayout(false);
            this.gbByemployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.DateTimePicker dtpDay;
        private System.Windows.Forms.Label lblPayoutlist;
        private System.Windows.Forms.ListBox lbNamesurname;
        private System.Windows.Forms.TextBox tbSearchbyemployee;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox tbPaymentforselectedmonth;
        private System.Windows.Forms.Label lblPaymentforselectedmonth;
        private System.Windows.Forms.Button btnCountpayments;
        private System.Windows.Forms.TextBox tbTotalpayments;
        private System.Windows.Forms.Label lblTotalpayments;
        private System.Windows.Forms.GroupBox gbByemployee;
        private System.Windows.Forms.Label lblSearchbyemployee;
    }
}