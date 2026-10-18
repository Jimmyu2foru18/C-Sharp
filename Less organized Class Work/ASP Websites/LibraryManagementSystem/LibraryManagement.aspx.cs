using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibraryManagement
{
    public partial class LibraryManagement : System.Web.UI.Page
    {
        private List<Book> library = new List<Book>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitializeLibrary();
            }
        }

        private void InitializeLibrary()
        {
            library.Add(new Book("Example: Book 1", "Author 1", "ISBN1", 200, 50));
            PopulateListBox();
        }

        private void PopulateListBox()
        {
            lstLibrary.Items.Clear();
            foreach (Book book in library)
            {
                lstLibrary.Items.Add(book.ToString());
            }
        }

        protected void btnAddBook_Click(object sender, EventArgs e)
        {
            string title = txtBook.Text;
            string author = txtAuthor.Text;
            string isbn = txtISBN.Text;
            int totalPages = int.Parse(txtTotalPages.Text);
            int currentPage = int.Parse(txtCurrentPage.Text);

            BookType bookType = GetSelectedBookType();

            Book newBook;

            if (bookType == BookType.Physical)
            {
                newBook = new Book(title, author, isbn, totalPages, currentPage);
            }
            else if (bookType == BookType.Ebook)
            {
                newBook = new EBook(title, author, isbn, totalPages, currentPage);
            }
            else
            {
                newBook = new AudioBook(title, author, isbn, totalPages, currentPage);
            }

            library.Add(newBook);

            PopulateListBox();
        }

        private BookType GetSelectedBookType()
        {
            if (chkBook.Checked)
                return BookType.Physical;
            else if (chkEbook.Checked)
                return BookType.Ebook;
            else if (chkAudiobook.Checked)
                return BookType.Audiobook;
            else
                throw new InvalidOperationException("No book type selected.");
        }

        protected void btnShowLibrary_Click(object sender, EventArgs e)
        {
            PopulateListBox();
        }

        protected void btnRemoveBook_Click(object sender, EventArgs e)
        {
            if (lstLibrary.SelectedIndex >= 0 && lstLibrary.SelectedIndex < library.Count)
            {
                int selectedIndex = lstLibrary.SelectedIndex;
                library.RemoveAt(selectedIndex);
                PopulateListBox();
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtBook.Text = "";
            txtAuthor.Text = "";
            txtISBN.Text = "";
            txtTotalPages.Text = "";
            txtCurrentPage.Text = "";
        }
    }
}
