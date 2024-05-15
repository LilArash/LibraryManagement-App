using LibraryManagement.DataLayar.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.app
{
    public partial class frmLogin : Form
    {
        public bool isEditing = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUserName.Text))
                {
                    MessageBox.Show("لطفا همه فیلدا رو پر کنید", "ورود به برنامه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (isEditing)
                    {
                        var login = db.LoginRepository.GetAll().First();
                        login.username = txtUserName.Text;
                        login.password = txtPassword.Text;
                        db.LoginRepository.Update(login);
                        db.Save();
                        Application.Restart();
                    }
                    else
                    {
                        if (db.LoginRepository.GetAll(l => l.username == txtUserName.Text && l.password == txtPassword.Text).Any())
                        {
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("نام کاربری یا گذرواژه نادرسته", "ورود به برنامه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (isEditing)
            {
                this.Text = "تنظیمات ورود";
                btnLogin.Text = "ذخیره";
                using (UnitOfWork db = new UnitOfWork())
                {
                    var login = db.LoginRepository.GetAll().First();
                    txtPassword.Text = login.password;
                    txtUserName.Text = login.username;
                }
            }
        }
    }
}
