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
    public partial class frmPrev : Form
    {
        public frmPrev()
        {
            InitializeComponent();
        }

        private void FrmPrev_Load(object sender, EventArgs e)
        {

        }

        public void showPhoto(string targ)
        {
            try
            {
                imgPrev.Load(@targ);
                imgPrev.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch(Exception e)
            {
                MessageBox.Show("사진을 불러오는 중 오류가 발생했습니다");
            }
        }
    }
}
