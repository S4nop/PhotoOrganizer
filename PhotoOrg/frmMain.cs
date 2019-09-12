using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoOrg
{
    public partial class frmMain : Form
    {
        string path;
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
            imgPrev.Image = null;
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
            try
            {
                imgPrev.Load(@filepath);
                imgPrev.SizeMode = PictureBoxSizeMode.StretchImage;
            }catch(Exception e)
            {
                MessageBox.Show("사진을 불러오는 중 오류가 발생했습니다");
            }
        }

        private void LstList_MouseClick(object sender, MouseEventArgs e)
        {
            int idx = -1;
            Point point = e.Location;
            idx = lstList.IndexFromPoint(point);

            if(idx != -1)
                showPicture(path + "\\" + lstList.Items[idx].ToString());
        }

    }
}
