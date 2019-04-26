namespace KWZP2019
{
    partial class SalariesSummary
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
            this.lblAmounttopay = new System.Windows.Forms.Label();
            this.lblGrantingbonus = new System.Windows.Forms.Label();
            this.btnAcceptchangesandsave = new System.Windows.Forms.Button();
            this.lblSelectemployee = new System.Windows.Forms.Label();
            this.lblAddbonus = new System.Windows.Forms.Label();
            this.lbAmounttopay = new System.Windows.Forms.CheckedListBox();
            this.tbAmountbonus = new System.Windows.Forms.TextBox();
            this.btnApprove = new System.Windows.Forms.Button();
            this.lblAmountbonus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAmounttopay
            // 
            this.lblAmounttopay.AutoSize = true;
            this.lblAmounttopay.Location = new System.Drawing.Point(9, 9);
            this.lblAmounttopay.Name = "lblAmounttopay";
            this.lblAmounttopay.Size = new System.Drawing.Size(225, 13);
            this.lblAmounttopay.TabIndex = 3;
            this.lblAmounttopay.Text = "Kwoty należne za ubiegły okres rozliczeniowy:";
            // 
            // lblGrantingbonus
            // 
            this.lblGrantingbonus.AutoSize = true;
            this.lblGrantingbonus.Location = new System.Drawing.Point(243, 9);
            this.lblGrantingbonus.Name = "lblGrantingbonus";
            this.lblGrantingbonus.Size = new System.Drawing.Size(105, 13);
            this.lblGrantingbonus.TabIndex = 6;
            this.lblGrantingbonus.Text = "Przyznawanie premii:";
            // 
            // btnAcceptchangesandsave
            // 
            this.btnAcceptchangesandsave.Location = new System.Drawing.Point(243, 296);
            this.btnAcceptchangesandsave.Name = "btnAcceptchangesandsave";
            this.btnAcceptchangesandsave.Size = new System.Drawing.Size(276, 25);
            this.btnAcceptchangesandsave.TabIndex = 14;
            this.btnAcceptchangesandsave.Text = "Zaakceptuj i zapisz zmiany";
            this.btnAcceptchangesandsave.UseVisualStyleBackColor = true;
            // 
            // lblSelectemployee
            // 
            this.lblSelectemployee.AutoSize = true;
            this.lblSelectemployee.Location = new System.Drawing.Point(243, 31);
            this.lblSelectemployee.Name = "lblSelectemployee";
            this.lblSelectemployee.Size = new System.Drawing.Size(256, 13);
            this.lblSelectemployee.TabIndex = 20;
            this.lblSelectemployee.Text = "Zaznacz odpowiedniego pracownika (pracowników),";
            // 
            // lblAddbonus
            // 
            this.lblAddbonus.AutoSize = true;
            this.lblAddbonus.Location = new System.Drawing.Point(243, 44);
            this.lblAddbonus.Name = "lblAddbonus";
            this.lblAddbonus.Size = new System.Drawing.Size(276, 13);
            this.lblAddbonus.TabIndex = 21;
            this.lblAddbonus.Text = "wprowadź kwotę premii, a następnie wybierz \"zatwierdź\".";
            // 
            // lbAmounttopay
            // 
            this.lbAmounttopay.FormattingEnabled = true;
            this.lbAmounttopay.Location = new System.Drawing.Point(12, 31);
            this.lbAmounttopay.Name = "lbAmounttopay";
            this.lbAmounttopay.Size = new System.Drawing.Size(222, 289);
            this.lbAmounttopay.TabIndex = 22;
            // 
            // tbAmountbonus
            // 
            this.tbAmountbonus.Location = new System.Drawing.Point(335, 99);
            this.tbAmountbonus.Name = "tbAmountbonus";
            this.tbAmountbonus.Size = new System.Drawing.Size(100, 20);
            this.tbAmountbonus.TabIndex = 23;
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(246, 125);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(273, 23);
            this.btnApprove.TabIndex = 24;
            this.btnApprove.Text = "Zatwierdź";
            this.btnApprove.UseVisualStyleBackColor = true;
            // 
            // lblAmountbonus
            // 
            this.lblAmountbonus.AutoSize = true;
            this.lblAmountbonus.Location = new System.Drawing.Point(351, 83);
            this.lblAmountbonus.Name = "lblAmountbonus";
            this.lblAmountbonus.Size = new System.Drawing.Size(70, 13);
            this.lblAmountbonus.TabIndex = 25;
            this.lblAmountbonus.Text = "Kwota premii:";
            // 
            // SalariesSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 331);
            this.Controls.Add(this.lblAmountbonus);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.tbAmountbonus);
            this.Controls.Add(this.lbAmounttopay);
            this.Controls.Add(this.lblAddbonus);
            this.Controls.Add(this.lblSelectemployee);
            this.Controls.Add(this.btnAcceptchangesandsave);
            this.Controls.Add(this.lblGrantingbonus);
            this.Controls.Add(this.lblAmounttopay);
            this.Name = "SalariesSummary";
            this.Text = "Podlicz wypłaty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAmounttopay;
        private System.Windows.Forms.Label lblGrantingbonus;
        private System.Windows.Forms.Button btnAcceptchangesandsave;
        private System.Windows.Forms.Label lblSelectemployee;
        private System.Windows.Forms.Label lblAddbonus;
        private System.Windows.Forms.CheckedListBox lbAmounttopay;
        private System.Windows.Forms.TextBox tbAmountbonus;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Label lblAmountbonus;
    }
}