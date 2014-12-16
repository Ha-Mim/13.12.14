using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookInfoUI
{
    public partial class BookInfo : Form
    {
        public BookInfo()
        {
            InitializeComponent();
        }

        private string ISBN = "";
        private string bookDetails = "";
        Hashtable bookInfo = new Hashtable();
        private void addButton_Click(object sender, EventArgs e)
        {
           
            ISBN = ISBNAddTextBox.Text;
            bookDetails = bookDetailsAddTextBox.Text;
            if (bookInfo.Contains(ISBN))
            {
                MessageBox.Show("ISBN already been used");
            }
            else
            {
     
            bookInfo.Add(ISBN,bookDetails);
            }
            ISBNAddTextBox.Text = string.Empty;
            bookDetailsAddTextBox.Text = string.Empty;

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            
            if (bookInfo.Contains(ISBNSearchTextBox.Text))
            {
                string bookName = Convert.ToString(bookInfo[ISBNSearchTextBox.Text]);
                bookDetailsSearchTextBox.Text = bookName;
            }
            else
            {
                MessageBox.Show("There is no entry with this ISBN");
            }
        }

        
    }
}
