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
        public frmMain()
        {
            InitializeComponent();
        }

        private void BtnSelFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();
            path = dialog.SelectedPath;
            if (path != "") getFileList();
        }

        private void init()
        {
            lstList.Items.Clear();
        }
        private void getFileList()
        {
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(path);
            init();
            foreach (System.IO.FileInfo File in di.GetFiles())
            {
                if (File.Extension.ToLower().CompareTo(".jpg") == 0 
                    || File.Extension.ToLower().CompareTo(".png") == 0
                    || File.Extension.ToLower().CompareTo(".bmp") == 0)
                {
                    String FileNameOnly = File.Name;

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

        private void BtnAuto_Click(object sender, EventArgs e)
        {
            setSize();
        }

        private void BtnYear_Click(object sender, EventArgs e)
        {
            foreach (string file in lstList.Items)
            {

            }
        }

        private void mov2Folder(string targ, string loc)
        {
            if (Directory.Exists(loc) == false) Directory.CreateDirectory(loc);

            File.Move(@targ, @loc);
        }
    }
}
