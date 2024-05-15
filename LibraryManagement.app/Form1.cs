using LibraryManagement.app.borrowings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnMembers_Click(object sender, EventArgs e)
        {
            frmMembers fm = new frmMembers();
            fm.ShowDialog();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            frmBooks fb = new frmBooks();
            fb.ShowDialog();
        }

        private void btnBookStatus_Click(object sender, EventArgs e)
        {
            frmBookStatus fbs = new frmBookStatus();
            fbs.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin fl = new frmLogin();
            if(fl.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("خوش آمدید", "ورود به برنامه", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Show();
                lblTime.Text = DateTime.Now.ToLocalTime().ToString();
            }
            else
            {
                Application.Exit();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLocalTime().ToString();
        }

        private void btnBookStatus_Click_1(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("میخواید از برنامه خارج شید؟", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void btnLoginSetting_Click(object sender, EventArgs e)
        {
            frmLogin fl = new frmLogin();
            fl.isEditing = true;
            fl.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmAbout fa = new frmAbout();
            fa.ShowDialog();

        }
    }
}
