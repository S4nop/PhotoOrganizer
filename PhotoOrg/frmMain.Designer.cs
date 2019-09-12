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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lstList = new System.Windows.Forms.ListBox();
            this.btnSelFolder = new System.Windows.Forms.Button();
            this.panAuto = new System.Windows.Forms.Panel();
            this.btnMan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtMan = new System.Windows.Forms.DateTimePicker();
            this.btnYear = new System.Windows.Forms.Button();
            this.btnDay = new System.Windows.Forms.Button();
            this.btnMonth = new System.Windows.Forms.Button();
            this.panAuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstList
            // 
            this.lstList.FormattingEnabled = true;
            this.lstList.ItemHeight = 12;
            this.lstList.Location = new System.Drawing.Point(12, 12);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(262, 400);
            this.lstList.TabIndex = 0;
            this.lstList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstList_MouseDoubleClick);
            // 
            // btnSelFolder
            // 
            this.btnSelFolder.Location = new System.Drawing.Point(12, 417);
            this.btnSelFolder.Name = "btnSelFolder";
            this.btnSelFolder.Size = new System.Drawing.Size(262, 34);
            this.btnSelFolder.TabIndex = 2;
            this.btnSelFolder.Text = "폴더 선택";
            this.btnSelFolder.UseVisualStyleBackColor = true;
            this.btnSelFolder.Click += new System.EventHandler(this.BtnSelFolder_Click);
            // 
            // panAuto
            // 
            this.panAuto.Controls.Add(this.btnMan);
            this.panAuto.Controls.Add(this.label2);
            this.panAuto.Controls.Add(this.label1);
            this.panAuto.Controls.Add(this.dtMan);
            this.panAuto.Controls.Add(this.btnYear);
            this.panAuto.Controls.Add(this.btnDay);
            this.panAuto.Controls.Add(this.btnMonth);
            this.panAuto.Location = new System.Drawing.Point(280, 12);
            this.panAuto.Name = "panAuto";
            this.panAuto.Size = new System.Drawing.Size(269, 442);
            this.panAuto.TabIndex = 5;
            // 
            // btnMan
            // 
            this.btnMan.Enabled = false;
            this.btnMan.Location = new System.Drawing.Point(0, 201);
            this.btnMan.Name = "btnMan";
            this.btnMan.Size = new System.Drawing.Size(268, 40);
            this.btnMan.TabIndex = 7;
            this.btnMan.Text = "추출하기";
            this.btnMan.UseVisualStyleBackColor = true;
            this.btnMan.Click += new System.EventHandler(this.BtnMan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "직접 추출";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "자동 분류";
            // 
            // dtMan
            // 
            this.dtMan.Enabled = false;
            this.dtMan.Location = new System.Drawing.Point(0, 177);
            this.dtMan.Name = "dtMan";
            this.dtMan.Size = new System.Drawing.Size(265, 21);
            this.dtMan.TabIndex = 4;
            this.dtMan.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // btnYear
            // 
            this.btnYear.Enabled = false;
            this.btnYear.Location = new System.Drawing.Point(0, 15);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(268, 40);
            this.btnYear.TabIndex = 3;
            this.btnYear.Text = "1년 단위로 분류";
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.BtnYear_Click);
            // 
            // btnDay
            // 
            this.btnDay.Enabled = false;
            this.btnDay.Location = new System.Drawing.Point(0, 107);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(268, 40);
            this.btnDay.TabIndex = 2;
            this.btnDay.Text = "1일 단위로 분류";
            this.btnDay.UseVisualStyleBackColor = true;
            this.btnDay.Click += new System.EventHandler(this.BtnDay_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.Enabled = false;
            this.btnMonth.Location = new System.Drawing.Point(0, 61);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(268, 40);
            this.btnMonth.TabIndex = 0;
            this.btnMonth.Text = "1개월 단위로 분류";
            this.btnMonth.UseVisualStyleBackColor = true;
            this.btnMonth.Click += new System.EventHandler(this.BtnMonth_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 463);
            this.Controls.Add(this.panAuto);
            this.Controls.Add(this.btnSelFolder);
            this.Controls.Add(this.lstList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Photo Organizer";
            this.panAuto.ResumeLayout(false);
            this.panAuto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstList;
        private System.Windows.Forms.Button btnSelFolder;
        private System.Windows.Forms.Panel panAuto;
        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Button btnMan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtMan;
    }
}

