using LibraryManagement.DataLayar;
using LibraryManagement.DataLayar.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement.app
{
    public partial class frmAddOrEditMember : Form
    {
        public int memberId = 0;
        public frmAddOrEditMember()
        {
            InitializeComponent();
        }

       

        bool IsInputsEmpty(string name, string lastName, string phone, string date)
        {
            if(string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastName)
            || string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(date)
            || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastName) ||
            string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(date))
            {
                return true;
            } else
            {
                return false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           using (UnitOfWork db = new UnitOfWork())
            {
                if (!IsInputsEmpty(txtName.Text, txtLname.Text, txtPhone.Text, txtDate.Text))
                {
                    tb_Members member = new tb_Members()
                    {
                        memberName = txtName.Text,
                        memberLastName = txtLname.Text,
                        memberPhone = txtPhone.Text,
                        membershipDate = txtDate.Text
                    };

                    if(memberId == 0)
                    {
                        db.MemberRepository.InsertMember(member);
                        MessageBox.Show("عضو جدید افزوده شد", "افزودن عضو", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if(memberId != 0)
                    {
                        member.memberID = memberId;
                        db.MemberRepository.UpdateMember(member);
                        MessageBox.Show("عضو ویرایش شد", "ویرایش عضو", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    db.Save();
                    DialogResult = DialogResult.OK;
                    
                } else
                {
                    MessageBox.Show("لطفا همه‌ی فیلدا رو پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("مطمئنید که میخواید این صفحه رو ببندید؟", "بستن", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmAddOrEditMember_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (memberId != 0)
                {
                    this.Text = "ویرایش عضو";
                    lblTitle.Text = "ویرایش عضو   ";
                    btnAdd.Text = "ویرایش";

                    var member = db.MemberRepository.GetMemberById(memberId);

                    txtName.Text = member.memberName;
                    txtLname.Text = member.memberLastName;
                    txtPhone.Text = member.memberPhone;
                    txtDate.Text = member.membershipDate;
                }
            }
        }
    }
}
