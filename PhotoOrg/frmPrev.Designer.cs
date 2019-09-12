namespace PhotoOrg
{
    partial class frmPrev
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
            this.imgPrev = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrev)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPrev
            // 
            this.imgPrev.Location = new System.Drawing.Point(3, 3);
            this.imgPrev.Name = "imgPrev";
            this.imgPrev.Size = new System.Drawing.Size(313, 294);
            this.imgPrev.TabIndex = 0;
            this.imgPrev.TabStop = false;
            // 
            // frmPrev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 298);
            this.Controls.Add(this.imgPrev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrev";
            this.ShowIcon = false;
            this.Text = "Preview";
            this.Load += new System.EventHandler(this.FrmPrev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgPrev)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPrev;
    }
}