using LibraryManagement.DataLayar;
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
    public partial class frmAddStatus : Form
    {
        public frmAddStatus()
        {
            InitializeComponent();
        }

        bool IsInputsEmpty(string name, string lastName, string bookName, string borrwDate, string returnDate)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(lastName)
            || string.IsNullOrWhiteSpace(bookName) || string.IsNullOrWhiteSpace(borrwDate)
            || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(lastName) ||
            string.IsNullOrEmpty(bookName) || string.IsNullOrEmpty(borrwDate) ||
            string.IsNullOrWhiteSpace(returnDate) || string.IsNullOrEmpty(returnDate))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!IsInputsEmpty(txtName.Text, txtLastName.Text, txtBookName.Text, txtBorrowDate.Text, txtReturnDate.Text))
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    tb_BooksStatus1 bs = new tb_BooksStatus1()
                    {
                        
                        memberName = txtName.Text,
                        memberLastName = txtLastName.Text,
                        bookName = txtBookName.Text,
                        borrowDate = txtBorrowDate.Text,
                        returnDate = txtBorrowDate.Text

                    };
                    db.BookStatusRepository.Insert(bs);
                    MessageBox.Show("وضعیت جدید افزوده شد", "افزودن وضعیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.Save();
                    DialogResult = DialogResult.OK;
                }
            } else
            {
                MessageBox.Show("لطفا همه‌ی فیلدا رو پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("مطمئنید که میخواید این صفحه رو ببندید؟", "بستن", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
