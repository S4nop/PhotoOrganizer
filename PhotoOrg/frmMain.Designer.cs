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
            this.btnSelFolder = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnMan = new System.Windows.Forms.Button();
            this.panAuto = new System.Windows.Forms.Panel();
            this.btnMonth = new System.Windows.Forms.Button();
            this.btnWeek = new System.Windows.Forms.Button();
            this.btnDay = new System.Windows.Forms.Button();
            this.btnYear = new System.Windows.Forms.Button();
            this.panAuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstList
            // 
            this.lstList.FormattingEnabled = true;
            this.lstList.ItemHeight = 12;
            this.lstList.Location = new System.Drawing.Point(12, 12);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(262, 364);
            this.lstList.TabIndex = 0;
            this.lstList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstList_MouseDoubleClick);
            // 
            // btnSelFolder
            // 
            this.btnSelFolder.Location = new System.Drawing.Point(12, 382);
            this.btnSelFolder.Name = "btnSelFolder";
            this.btnSelFolder.Size = new System.Drawing.Size(262, 34);
            this.btnSelFolder.TabIndex = 2;
            this.btnSelFolder.Text = "폴더 선택";
            this.btnSelFolder.UseVisualStyleBackColor = true;
            this.btnSelFolder.Click += new System.EventHandler(this.BtnSelFolder_Click);
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(12, 422);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(127, 33);
            this.btnAuto.TabIndex = 3;
            this.btnAuto.Text = "자동 분류";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.BtnAuto_Click);
            // 
            // btnMan
            // 
            this.btnMan.Location = new System.Drawing.Point(147, 422);
            this.btnMan.Name = "btnMan";
            this.btnMan.Size = new System.Drawing.Size(127, 33);
            this.btnMan.TabIndex = 4;
            this.btnMan.Text = "수동 분류";
            this.btnMan.UseVisualStyleBackColor = true;
            // 
            // panAuto
            // 
            this.panAuto.Controls.Add(this.btnYear);
            this.panAuto.Controls.Add(this.btnDay);
            this.panAuto.Controls.Add(this.btnWeek);
            this.panAuto.Controls.Add(this.btnMonth);
            this.panAuto.Location = new System.Drawing.Point(280, 12);
            this.panAuto.Name = "panAuto";
            this.panAuto.Size = new System.Drawing.Size(269, 442);
            this.panAuto.TabIndex = 5;
            // 
            // btnMonth
            // 
            this.btnMonth.Location = new System.Drawing.Point(1, 46);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(268, 40);
            this.btnMonth.TabIndex = 0;
            this.btnMonth.Text = "1개월 단위로 분류";
            this.btnMonth.UseVisualStyleBackColor = true;
            // 
            // btnWeek
            // 
            this.btnWeek.Location = new System.Drawing.Point(1, 92);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(268, 40);
            this.btnWeek.TabIndex = 1;
            this.btnWeek.Text = "1주일 단위로 분류";
            this.btnWeek.UseVisualStyleBackColor = true;
            // 
            // btnDay
            // 
            this.btnDay.Location = new System.Drawing.Point(1, 138);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(268, 40);
            this.btnDay.TabIndex = 2;
            this.btnDay.Text = "1일 단위로 분류";
            this.btnDay.UseVisualStyleBackColor = true;
            // 
            // btnYear
            // 
            this.btnYear.Location = new System.Drawing.Point(1, 0);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(268, 40);
            this.btnYear.TabIndex = 3;
            this.btnYear.Text = "1년 단위로 분류";
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.BtnYear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 463);
            this.Controls.Add(this.panAuto);
            this.Controls.Add(this.btnMan);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnSelFolder);
            this.Controls.Add(this.lstList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Photo Organizer";
            this.panAuto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstList;
        private System.Windows.Forms.Button btnSelFolder;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnMan;
        private System.Windows.Forms.Panel panAuto;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Button btnWeek;
        private System.Windows.Forms.Button btnMonth;
    }
}

