using LibraryManagement.app.books;
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
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
        }

        void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvBooks.AutoGenerateColumns = false;
                dgvBooks.DataSource = db.BookRepository.GetAllBooks();
            }
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            frmAddOrEditBook faob = new frmAddOrEditBook();
            if (faob.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow != null)
            {
                int bookId = int.Parse(dgvBooks.CurrentRow.Cells[0].Value.ToString());
                frmAddOrEditBook faob = new frmAddOrEditBook();
                faob.bookId = bookId;
                if (faob.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow != null)
            {
                int bookId = int.Parse(dgvBooks.CurrentRow.Cells[0].Value.ToString());
                string bookName = dgvBooks.CurrentRow.Cells[1].Value.ToString();

                using (UnitOfWork db = new UnitOfWork())
                {
                    DialogResult res = MessageBox.Show($"مطمئنید که میخواید {bookName} حذف کنید؟", "حذف کتاب", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (res == DialogResult.Yes)
                    {
                        db.BookRepository.DeleteBook(bookId);
                        db.Save();
                        BindGrid();
                    }

                }

            }
            else
            {
                MessageBox.Show("لطفا یک کتاب رو انتخاب کنید", "حذف کتاب", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
                dgvBooks.DataSource = db.BookRepository.GetBookByFilter(txtSearch.Text);
            }
        }
    }
}
