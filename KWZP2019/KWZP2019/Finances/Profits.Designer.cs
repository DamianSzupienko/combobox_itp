namespace KWZP2019
{
    partial class Profits
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
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblSpecifytimerange = new System.Windows.Forms.Label();
            this.btnAcceptselectedtime = new System.Windows.Forms.Button();
            this.lvListofrevenues = new System.Windows.Forms.ListView();
            this.lblListofrevenues = new System.Windows.Forms.Label();
            this.btnGenerategeneralreport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(42, 25);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 0;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(312, 25);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 1;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 31);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(24, 13);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "Od:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(282, 31);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(24, 13);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "Do:";
            // 
            // lblSpecifytimerange
            // 
            this.lblSpecifytimerange.AutoSize = true;
            this.lblSpecifytimerange.Location = new System.Drawing.Point(218, 9);
            this.lblSpecifytimerange.Name = "lblSpecifytimerange";
            this.lblSpecifytimerange.Size = new System.Drawing.Size(118, 13);
            this.lblSpecifytimerange.TabIndex = 4;
            this.lblSpecifytimerange.Text = "Określ zakres czasowy:";
            // 
            // btnAcceptselectedtime
            // 
            this.btnAcceptselectedtime.Location = new System.Drawing.Point(15, 51);
            this.btnAcceptselectedtime.Name = "btnAcceptselectedtime";
            this.btnAcceptselectedtime.Size = new System.Drawing.Size(497, 23);
            this.btnAcceptselectedtime.TabIndex = 5;
            this.btnAcceptselectedtime.Text = "Zatwierdź wybrany przedzial";
            this.btnAcceptselectedtime.UseVisualStyleBackColor = true;
            // 
            // lvListofrevenues
            // 
            this.lvListofrevenues.Location = new System.Drawing.Point(15, 97);
            this.lvListofrevenues.Name = "lvListofrevenues";
            this.lvListofrevenues.Size = new System.Drawing.Size(497, 164);
            this.lvListofrevenues.TabIndex = 6;
            this.lvListofrevenues.UseCompatibleStateImageBehavior = false;
            // 
            // lblListofrevenues
            // 
            this.lblListofrevenues.AutoSize = true;
            this.lblListofrevenues.Location = new System.Drawing.Point(139, 81);
            this.lblListofrevenues.Name = "lblListofrevenues";
            this.lblListofrevenues.Size = new System.Drawing.Size(255, 13);
            this.lblListofrevenues.TabIndex = 7;
            this.lblListofrevenues.Text = "Lista przychodów w wybranym przedziale czasowym:";
            // 
            // btnGenerategeneralreport
            // 
            this.btnGenerategeneralreport.Location = new System.Drawing.Point(15, 282);
            this.btnGenerategeneralreport.Name = "btnGenerategeneralreport";
            this.btnGenerategeneralreport.Size = new System.Drawing.Size(497, 23);
            this.btnGenerategeneralreport.TabIndex = 9;
            this.btnGenerategeneralreport.Text = "Generuj raport";
            this.btnGenerategeneralreport.UseVisualStyleBackColor = true;
            // 
            // Profits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 331);
            this.Controls.Add(this.btnGenerategeneralreport);
            this.Controls.Add(this.lblListofrevenues);
            this.Controls.Add(this.lvListofrevenues);
            this.Controls.Add(this.btnAcceptselectedtime);
            this.Controls.Add(this.lblSpecifytimerange);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Name = "Profits";
            this.Text = "Zyski";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblSpecifytimerange;
        private System.Windows.Forms.Button btnAcceptselectedtime;
        private System.Windows.Forms.ListView lvListofrevenues;
        private System.Windows.Forms.Label lblListofrevenues;
        private System.Windows.Forms.Button btnGenerategeneralreport;
    }
}