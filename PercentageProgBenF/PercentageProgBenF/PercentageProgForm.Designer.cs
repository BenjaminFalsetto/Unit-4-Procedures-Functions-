namespace PercentageProgBenF
{
    partial class frmPercentageProg
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
            this.btncCalculatePercentage = new System.Windows.Forms.Button();
            this.lblEnterLevel = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncCalculatePercentage
            // 
            this.btncCalculatePercentage.Location = new System.Drawing.Point(105, 50);
            this.btncCalculatePercentage.Name = "btncCalculatePercentage";
            this.btncCalculatePercentage.Size = new System.Drawing.Size(75, 39);
            this.btncCalculatePercentage.TabIndex = 0;
            this.btncCalculatePercentage.Text = "Calculate Percentage";
            this.btncCalculatePercentage.UseVisualStyleBackColor = true;
            this.btncCalculatePercentage.Click += new System.EventHandler(this.btncCalculatePercentage_Click);
            // 
            // lblEnterLevel
            // 
            this.lblEnterLevel.AutoSize = true;
            this.lblEnterLevel.Location = new System.Drawing.Point(112, 111);
            this.lblEnterLevel.Name = "lblEnterLevel";
            this.lblEnterLevel.Size = new System.Drawing.Size(61, 13);
            this.lblEnterLevel.TabIndex = 2;
            this.lblEnterLevel.Text = "Enter Level";
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(92, 145);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(100, 20);
            this.txtLevel.TabIndex = 1;
            // 
            // frmPercentageProg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblEnterLevel);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.btncCalculatePercentage);
            this.Name = "frmPercentageProg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Percentage Program Benjamin Falsetto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncCalculatePercentage;
        private System.Windows.Forms.Label lblEnterLevel;
        private System.Windows.Forms.TextBox txtLevel;
    }
}

