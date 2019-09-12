namespace PhotoOrg
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstList = new System.Windows.Forms.ListBox();
            this.imgPrev = new System.Windows.Forms.PictureBox();
            this.btnSelFolder = new System.Windows.Forms.Button();
            this.btnOrg = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgPrev)).BeginInit();
            this.SuspendLayout();
            // 
            // lstList
            // 
            this.lstList.FormattingEnabled = true;
            this.lstList.ItemHeight = 12;
            this.lstList.Location = new System.Drawing.Point(12, 12);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(329, 376);
            this.lstList.TabIndex = 0;
            this.lstList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LstList_MouseClick);
            // 
            // imgPrev
            // 
            this.imgPrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgPrev.Location = new System.Drawing.Point(347, 12);
            this.imgPrev.Name = "imgPrev";
            this.imgPrev.Size = new System.Drawing.Size(262, 232);
            this.imgPrev.TabIndex = 1;
            this.imgPrev.TabStop = false;
            // 
            // btnSelFolder
            // 
            this.btnSelFolder.Location = new System.Drawing.Point(347, 250);
            this.btnSelFolder.Name = "btnSelFolder";
            this.btnSelFolder.Size = new System.Drawing.Size(262, 44);
            this.btnSelFolder.TabIndex = 2;
            this.btnSelFolder.Text = "폴더 선택";
            this.btnSelFolder.UseVisualStyleBackColor = true;
            this.btnSelFolder.Click += new System.EventHandler(this.BtnSelFolder_Click);
            // 
            // btnOrg
            // 
            this.btnOrg.Location = new System.Drawing.Point(347, 299);
            this.btnOrg.Name = "btnOrg";
            this.btnOrg.Size = new System.Drawing.Size(262, 43);
            this.btnOrg.TabIndex = 3;
            this.btnOrg.Text = "사진 정리";
            this.btnOrg.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(347, 346);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(262, 43);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "종료";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 398);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOrg);
            this.Controls.Add(this.btnSelFolder);
            this.Controls.Add(this.imgPrev);
            this.Controls.Add(this.lstList);
            this.Name = "frmMain";
            this.Text = "Photo Organizer";
            ((System.ComponentModel.ISupportInitialize)(this.imgPrev)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstList;
        private System.Windows.Forms.PictureBox imgPrev;
        private System.Windows.Forms.Button btnSelFolder;
        private System.Windows.Forms.Button btnOrg;
        private System.Windows.Forms.Button btnExit;
    }
}

