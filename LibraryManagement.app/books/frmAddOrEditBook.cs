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

namespace LibraryManagement.app.books
{
    public partial class frmAddOrEditBook : Form
    {
        public int bookId = 0;
        public frmAddOrEditBook()
        {
            InitializeComponent();
        }

        bool IsInputsEmpty(string name, string writerName, string subject, string date)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(writerName)
            || string.IsNullOrWhiteSpace(subject) || string.IsNullOrWhiteSpace(date)
            || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(writerName) ||
            string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(date))
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
            using (UnitOfWork db = new UnitOfWork())
            {
                if (!IsInputsEmpty(txtName.Text, txtWriter.Text, txtSubject.Text, txtDate.Text))
                {
                    tb_Books book = new tb_Books()
                    {
                        bookName = txtName.Text,
                        bookWriter = txtWriter.Text,
                        bookSubject = txtSubject.Text,
                        bookPublishDate = txtDate.Text
                    };

                    if(bookId == 0)
                    {
                        db.BookRepository.InsertBook(book);
                        MessageBox.Show("کتاب جدید افزوده شد", "افزودن کتاب", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                    else if(bookId != 0)
                    {
                        book.bookID = bookId;
                        db.BookRepository.UpdateBook(book);
                        MessageBox.Show("کتاب ویرایش شد", "ویرایش کتاب", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    db.Save();
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("لطفا همه‌ی فیلدا رو پر کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void frmAddOrEditBook_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (bookId != 0)
                {
                    this.Text = "ویرایش کتاب";
                    lblTitle.Text = "ویرایش کتاب   ";
                    btnAdd.Text = "ویرایش";

                    var book = db.BookRepository.GetBookById(bookId);

                    txtName.Text = book.bookName;
                    txtWriter.Text = book.bookWriter;
                    txtSubject.Text = book.bookSubject;
                    txtDate.Text =book.bookPublishDate;
                }
            }
        }
    }
}
