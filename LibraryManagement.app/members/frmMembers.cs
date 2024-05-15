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
    public partial class frmMembers : Form
    {
        public frmMembers()
        {
            InitializeComponent();
        }
        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvMembers.AutoGenerateColumns = false;
                dgvMembers.DataSource = db.MemberRepository.GetAllMembers();
            }
        }
        private void frmMembers_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if(dgvMembers.CurrentRow != null)
            {
                int memberId = int.Parse(dgvMembers.CurrentRow.Cells[0].Value.ToString());
                string fullName = dgvMembers.CurrentRow.Cells[1].Value.ToString() + " " + dgvMembers.CurrentRow.Cells[2].Value.ToString();

                using (UnitOfWork db = new UnitOfWork())
                {
                    DialogResult res = MessageBox.Show($"مطمئنید که میخواید {fullName} حذف کنید؟", "حذف عضو", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if(res == DialogResult.Yes)
                    {
                        db.MemberRepository.DeleteMember(memberId);
                        db.Save();
                        BindGrid();
                    }
                   
                }

            } else
            {
                MessageBox.Show("لطفا یک عضو رو انتخاب کنید", "حذف عضو", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            frmAddOrEditMember faoe = new frmAddOrEditMember();
            if(faoe.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            if(dgvMembers.CurrentRow != null)
            {
                int memberId = int.Parse(dgvMembers.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEditMember faoe = new frmAddOrEditMember();
                faoe.memberId = memberId;
                if (faoe.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvMembers.DataSource = db.MemberRepository.GetMemberByFilter(txtSearch.Text);
            }
        }
    }
}
