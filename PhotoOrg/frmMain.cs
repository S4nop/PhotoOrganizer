using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace PhotoOrg
{
    public partial class frmMain : Form
    {
        string path;
        frmPrev prv = null;
        frmProg prg = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnSelFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            path = dialog.SelectedPath;
            if (path != "") {
                getFileList(false);
                unlockAll();
                MessageBox.Show(lstList.Items.Count + "개의 사진(동영상)을 불러왔습니다");
            }
        }

        private void init()
        {
            lstList.Items.Clear();
        }
        private void getFileList(bool pickMod)
        {
            if (path == null) return;
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(path);
            init();
            foreach (System.IO.FileInfo File in di.GetFiles())
            {
                if (File.Extension.ToLower().CompareTo(".jpg") == 0 
                    || File.Extension.ToLower().CompareTo(".png") == 0
                    || File.Extension.ToLower().CompareTo(".bmp") == 0
                    || File.Extension.ToLower().CompareTo(".mp4") == 0
                    || File.Extension.ToLower().CompareTo(".avi") == 0
                    || File.Extension.ToLower().CompareTo(".mov") == 0
                    || File.Extension.ToLower().CompareTo(".jpeg") == 0)
                {
                    String FileNameOnly = File.Name;
                    if (pickMod)
                    {
                        fileInf fInf = getFileInf(path + "\\" + FileNameOnly);
                        string[] fData = dtMan.Value.ToString().Split(" ".ToCharArray())[0].Split("-".ToCharArray());

                        if (!(fInf.getYear().Equals(fData[0]) && fInf.getMonth().Equals(fData[1]) && fInf.getDate().Equals(fData[2]))) continue;
                    }

                    lstList.Items.Add(FileNameOnly);
                }
            }
            
        }

        private void showPicture(string filepath)
        {
            if (prv == null)
            {
                prv = new frmPrev();
                prv.Show();
            }
            prv.showPhoto(@filepath);
        }

        private void BtnOrg_Click(object sender, EventArgs e)
        {

        }

        private void LstList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int idx = -1;
            Point point = e.Location;
            idx = lstList.IndexFromPoint(point);

            if (idx != -1)
                showPicture(path + "\\" + lstList.Items[idx].ToString());

        }

        private void setSize()
        {
            while (Width > 300) --Width;
            while (Width < 571) ++Width;
        }

        private void BtnYear_Click(object sender, EventArgs e)
        {
            categorize(1);
        }
        private void BtnMonth_Click(object sender, EventArgs e)
        {
            categorize(2);
        }
        private void BtnDay_Click(object sender, EventArgs e)
        {
            categorize(3);
        }

        private void mov2Folder(string targ, string loc)
        {
            if (Directory.Exists(loc) == false) Directory.CreateDirectory(loc);

            File.Move(path + "\\" + targ, loc + "\\" + targ);
        }


        private fileInf getFileInf(string targ)
        {
            var info = new FileInfo(targ);
            string[] dateInf = info.LastWriteTime.ToString().Split(" ".ToCharArray())[0].Split("-".ToCharArray());

            return new fileInf(dateInf[0], dateInf[1], dateInf[2]);
        }


        private void categorize(int mod)
        {
            prg = new frmProg();
            lockAll();
            prg.Show();
            prg.init(lstList.Items.Count);
            foreach (string file in lstList.Items)
            {
                prg.update(file);
                fileInf finf = getFileInf(path + "\\" + file);
                string dest = mod == 1 ? finf.getYear() : 
                    mod == 2 ? finf.getYear() + "-" + finf.getMonth() : 
                    finf.getYear() + "-" + finf.getMonth() + "-" + finf.getDate();

                mov2Folder(file, path + "\\" + dest);
            }
            prg.Close();
            unlockAll();
            lstList.Items.Clear();
        }

        private void lockAll()
        {
            btnYear.Enabled = false;
            btnMonth.Enabled = false;
            btnDay.Enabled = false;
            btnSelFolder.Enabled = false;
            lstList.Enabled = false;
            dtMan.Enabled = false;
            btnMan.Enabled = false;
        }
        private void unlockAll()
        {
            btnYear.Enabled = true;
            btnMonth.Enabled = true;
            btnDay.Enabled = true;
            btnSelFolder.Enabled = true;
            lstList.Enabled = true;
            dtMan.Enabled = true;
            btnMan.Enabled = true;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            getFileList(true);
        }

        private void BtnMan_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            string svPath = dialog.SelectedPath;
            if (svPath != "")
            {
                svPhotos(svPath);
            }
        }

        private void svPhotos(string dest)
        {
            foreach(string fName in lstList.Items)
            {
                File.Move(path + "\\" + fName, dest + "\\" + fName);
            }
            getFileList(false);
        }
    }

    class fileInf
    {
        private string year;
        private string month;
        private string date;

        public fileInf(string year, string month, string date)
        {
            this.year = year;
            this.month = month;
            this.date = date;
        }

        public string getYear()
        {
            return year;
        }

        public string getMonth()
        {
            return month;
        }

        public string getDate()
        {
            return date;
        }

    }
}
