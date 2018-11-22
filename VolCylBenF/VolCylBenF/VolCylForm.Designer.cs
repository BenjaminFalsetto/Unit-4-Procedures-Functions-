namespace VolCylBenF
{
    partial class frmVolCyl
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
            this.nudRadius = new System.Windows.Forms.NumericUpDown();
            this.lblEnterRadius = new System.Windows.Forms.Label();
            this.lblEnterHeight = new System.Windows.Forms.Label();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAns = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // nudRadius
            // 
            this.nudRadius.Location = new System.Drawing.Point(82, 47);
            this.nudRadius.Name = "nudRadius";
            this.nudRadius.Size = new System.Drawing.Size(120, 20);
            this.nudRadius.TabIndex = 0;
            // 
            // lblEnterRadius
            // 
            this.lblEnterRadius.AutoSize = true;
            this.lblEnterRadius.Location = new System.Drawing.Point(108, 31);
            this.lblEnterRadius.Name = "lblEnterRadius";
            this.lblEnterRadius.Size = new System.Drawing.Size(68, 13);
            this.lblEnterRadius.TabIndex = 1;
            this.lblEnterRadius.Text = "Enter Radius";
            // 
            // lblEnterHeight
            // 
            this.lblEnterHeight.AutoSize = true;
            this.lblEnterHeight.Location = new System.Drawing.Point(109, 100);
            this.lblEnterHeight.Name = "lblEnterHeight";
            this.lblEnterHeight.Size = new System.Drawing.Size(66, 13);
            this.lblEnterHeight.TabIndex = 2;
            this.lblEnterHeight.Text = "Enter Height";
            // 
            // nudHeight
            // 
            this.nudHeight.Location = new System.Drawing.Point(82, 116);
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(120, 20);
            this.nudHeight.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(105, 165);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(96, 204);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(92, 13);
            this.lblAns.TabIndex = 6;
            this.lblAns.Text = "Answer goes here";
            // 
            // frmVolCyl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.nudHeight);
            this.Controls.Add(this.lblEnterHeight);
            this.Controls.Add(this.lblEnterRadius);
            this.Controls.Add(this.nudRadius);
            this.Name = "frmVolCyl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Volume of a Cylinder Benjamin Falsetto";
            this.Load += new System.EventHandler(this.frmVolCyl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudRadius;
        private System.Windows.Forms.Label lblEnterRadius;
        private System.Windows.Forms.Label lblEnterHeight;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAns;
    }
}

