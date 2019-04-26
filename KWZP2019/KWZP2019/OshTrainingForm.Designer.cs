namespace KWZP2019
{
    partial class OshTrainingForm
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
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnReturnMain = new System.Windows.Forms.Button();
            this.dataGVOshTraining = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblDepartmentName = new System.Windows.Forms.Label();
            this.domainUpDownDepartmentName = new System.Windows.Forms.DomainUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVOshTraining)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(178)))));
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReturn.Location = new System.Drawing.Point(972, 89);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(200, 50);
            this.btnReturn.TabIndex = 1;
            this.btnReturn.Text = "Powrót";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnReturnMain
            // 
            this.btnReturnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(92)))), ((int)(((byte)(178)))));
            this.btnReturnMain.FlatAppearance.BorderSize = 0;
            this.btnReturnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnMain.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReturnMain.Location = new System.Drawing.Point(972, 12);
            this.btnReturnMain.Name = "btnReturnMain";
            this.btnReturnMain.Size = new System.Drawing.Size(200, 50);
            this.btnReturnMain.TabIndex = 2;
            this.btnReturnMain.Text = "Menu Główne";
            this.btnReturnMain.UseVisualStyleBackColor = false;
            this.btnReturnMain.Click += new System.EventHandler(this.btnReturnMain_Click);
            // 
            // dataGVOshTraining
            // 
            this.dataGVOshTraining.AllowUserToAddRows = false;
            this.dataGVOshTraining.AllowUserToDeleteRows = false;
            this.dataGVOshTraining.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGVOshTraining.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGVOshTraining.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGVOshTraining.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGVOshTraining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVOshTraining.Location = new System.Drawing.Point(52, 54);
            this.dataGVOshTraining.Name = "dataGVOshTraining";
            this.dataGVOshTraining.ReadOnly = true;
            this.dataGVOshTraining.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGVOshTraining.Size = new System.Drawing.Size(460, 158);
            this.dataGVOshTraining.TabIndex = 3;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(454, 232);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Pokaż";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblDepartmentName
            // 
            this.lblDepartmentName.AutoSize = true;
            this.lblDepartmentName.Location = new System.Drawing.Point(183, 232);
            this.lblDepartmentName.Name = "lblDepartmentName";
            this.lblDepartmentName.Size = new System.Drawing.Size(72, 13);
            this.lblDepartmentName.TabIndex = 6;
            this.lblDepartmentName.Text = "Nazwa działu";
            // 
            // domainUpDownDepartmentName
            // 
            this.domainUpDownDepartmentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.domainUpDownDepartmentName.Location = new System.Drawing.Point(280, 233);
            this.domainUpDownDepartmentName.Name = "domainUpDownDepartmentName";
            this.domainUpDownDepartmentName.Size = new System.Drawing.Size(120, 16);
            this.domainUpDownDepartmentName.Sorted = true;
            this.domainUpDownDepartmentName.TabIndex = 8;
            this.domainUpDownDepartmentName.Text = "Wybierz dział";
            // 
            // OshTrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.domainUpDownDepartmentName);
            this.Controls.Add(this.lblDepartmentName);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.dataGVOshTraining);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnReturnMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "OshTrainingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OshTrainingForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OshTrainingForm_FormClosed);
            this.Load += new System.EventHandler(this.OshTrainingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVOshTraining)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnReturnMain;
        private System.Windows.Forms.DataGridView dataGVOshTraining;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblDepartmentName;
        private System.Windows.Forms.DomainUpDown domainUpDownDepartmentName;
    }
}