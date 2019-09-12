namespace PhotoOrg
{
    partial class frmProg
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
            this.prgOrg = new System.Windows.Forms.ProgressBar();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblPerc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prgOrg
            // 
            this.prgOrg.Location = new System.Drawing.Point(12, 66);
            this.prgOrg.Name = "prgOrg";
            this.prgOrg.Size = new System.Drawing.Size(317, 33);
            this.prgOrg.TabIndex = 0;
            this.prgOrg.Click += new System.EventHandler(this.PrgOrg_Click);
            // 
            // lblFname
            // 
            this.lblFname.Location = new System.Drawing.Point(12, 20);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(317, 23);
            this.lblFname.TabIndex = 1;
            this.lblFname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPerc
            // 
            this.lblPerc.Location = new System.Drawing.Point(12, 45);
            this.lblPerc.Name = "lblPerc";
            this.lblPerc.Size = new System.Drawing.Size(317, 18);
            this.lblPerc.TabIndex = 2;
            this.lblPerc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmProg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 120);
            this.Controls.Add(this.lblPerc);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.prgOrg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmProg";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Progress";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar prgOrg;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblPerc;
    }
}