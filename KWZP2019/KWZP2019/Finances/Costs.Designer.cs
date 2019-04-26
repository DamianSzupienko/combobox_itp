namespace KWZP2019
{
    partial class Costs
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
            this.lblSelectdepartmentanddate = new System.Windows.Forms.Label();
            this.btnApprovechoice = new System.Windows.Forms.Button();
            this.cbDepartmentsList = new System.Windows.Forms.ListBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblTotalcostfordepartment = new System.Windows.Forms.Label();
            this.tbTotalcostfordepartment = new System.Windows.Forms.TextBox();
            this.btnAddinvoice = new System.Windows.Forms.Button();
            this.btnGeneratedetailedreport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectdepartmentanddate
            // 
            this.lblSelectdepartmentanddate.AutoSize = true;
            this.lblSelectdepartmentanddate.Location = new System.Drawing.Point(143, 9);
            this.lblSelectdepartmentanddate.Name = "lblSelectdepartmentanddate";
            this.lblSelectdepartmentanddate.Size = new System.Drawing.Size(250, 13);
            this.lblSelectdepartmentanddate.TabIndex = 20;
            this.lblSelectdepartmentanddate.Text = "Wybierz dział (lub całe przedsiębiorstwo) oraz datę:";
            // 
            // btnApprovechoice
            // 
            this.btnApprovechoice.Location = new System.Drawing.Point(24, 74);
            this.btnApprovechoice.Name = "btnApprovechoice";
            this.btnApprovechoice.Size = new System.Drawing.Size(478, 23);
            this.btnApprovechoice.TabIndex = 22;
            this.btnApprovechoice.Text = "Zatwierdź wybór";
            this.btnApprovechoice.UseVisualStyleBackColor = true;
            // 
            // cbDepartmentsList
            // 
            this.cbDepartmentsList.FormattingEnabled = true;
            this.cbDepartmentsList.Location = new System.Drawing.Point(212, 25);
            this.cbDepartmentsList.Name = "cbDepartmentsList";
            this.cbDepartmentsList.Size = new System.Drawing.Size(120, 17);
            this.cbDepartmentsList.TabIndex = 23;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(174, 48);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 24;
            // 
            // lblTotalcostfordepartment
            // 
            this.lblTotalcostfordepartment.AutoSize = true;
            this.lblTotalcostfordepartment.Location = new System.Drawing.Point(21, 117);
            this.lblTotalcostfordepartment.Name = "lblTotalcostfordepartment";
            this.lblTotalcostfordepartment.Size = new System.Drawing.Size(204, 13);
            this.lblTotalcostfordepartment.TabIndex = 25;
            this.lblTotalcostfordepartment.Text = "Zsumowane koszta dla danego podmiotu:";
            // 
            // tbTotalcostfordepartment
            // 
            this.tbTotalcostfordepartment.Location = new System.Drawing.Point(231, 114);
            this.tbTotalcostfordepartment.Name = "tbTotalcostfordepartment";
            this.tbTotalcostfordepartment.Size = new System.Drawing.Size(143, 20);
            this.tbTotalcostfordepartment.TabIndex = 26;
            // 
            // btnAddinvoice
            // 
            this.btnAddinvoice.Location = new System.Drawing.Point(24, 158);
            this.btnAddinvoice.Name = "btnAddinvoice";
            this.btnAddinvoice.Size = new System.Drawing.Size(478, 23);
            this.btnAddinvoice.TabIndex = 27;
            this.btnAddinvoice.Text = "Dodaj fakturę";
            this.btnAddinvoice.UseVisualStyleBackColor = true;
            // 
            // btnGeneratedetailedreport
            // 
            this.btnGeneratedetailedreport.Location = new System.Drawing.Point(24, 223);
            this.btnGeneratedetailedreport.Name = "btnGeneratedetailedreport";
            this.btnGeneratedetailedreport.Size = new System.Drawing.Size(478, 50);
            this.btnGeneratedetailedreport.TabIndex = 29;
            this.btnGeneratedetailedreport.Text = "Generuj raport";
            this.btnGeneratedetailedreport.UseVisualStyleBackColor = true;
            // 
            // Costs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 331);
            this.Controls.Add(this.btnGeneratedetailedreport);
            this.Controls.Add(this.btnAddinvoice);
            this.Controls.Add(this.tbTotalcostfordepartment);
            this.Controls.Add(this.lblTotalcostfordepartment);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cbDepartmentsList);
            this.Controls.Add(this.btnApprovechoice);
            this.Controls.Add(this.lblSelectdepartmentanddate);
            this.Name = "Costs";
            this.Text = "Koszty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSelectdepartmentanddate;
        private System.Windows.Forms.Button btnApprovechoice;
        private System.Windows.Forms.ListBox cbDepartmentsList;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTotalcostfordepartment;
        private System.Windows.Forms.TextBox tbTotalcostfordepartment;
        private System.Windows.Forms.Button btnAddinvoice;
        private System.Windows.Forms.Button btnGeneratedetailedreport;
    }
}