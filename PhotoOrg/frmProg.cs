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
    public partial class frmProg : Form
    {
        int num = -1;
        int now = 0;
        public frmProg()
        {
            InitializeComponent();
        }

        private void PrgOrg_Click(object sender, EventArgs e)
        {

        }

        public void init(int num)
        {
            this.num = num;
            prgOrg.Maximum = num;
        }
        public void update(string fname)
        {
            Application.DoEvents();
            lblFname.Text = fname;
            prgOrg.Value = ++now;
            lblPerc.Text = now.ToString() + " / " + num;
        }
    }
}
