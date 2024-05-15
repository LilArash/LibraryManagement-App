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

namespace LibraryManagement.app.borrowings
{
    public partial class frmBookStatus : Form
    {
        public frmBookStatus()
        {
            InitializeComponent();
        }

        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvStatus.AutoGenerateColumns = false;
                dgvStatus.DataSource = db.BookStatusRepository.GetAll();
            }
        }
        private void frmBookStatus_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnAddStatus_Click(object sender, EventArgs e)
        {
            frmAddStatus fas = new frmAddStatus();
            if(fas.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnDeleteStatus_Click(object sender, EventArgs e)
        {
            int statusId = int.Parse(dgvStatus.CurrentRow.Cells[0].Value.ToString());
            
            using (UnitOfWork db = new UnitOfWork())
            {
                DialogResult res = MessageBox.Show("از حذف این وضعیت مطمئنید؟", "حذف وضعیت", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dgvStatus.CurrentRow != null)
                {
                    if (res == DialogResult.Yes)
                    {
                        db.BookRepository.DeleteBook(statusId);
                        db.Save();
                        BindGrid();
                    }
                }
                else
                {
                    MessageBox.Show("لطفا یک مورد رو انتخاب کنید", "حذف وضعیت", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
