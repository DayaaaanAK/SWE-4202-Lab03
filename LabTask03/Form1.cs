using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTask03
{
    public partial class Form1 : Form
    {
        List<User> users_list = new List<User>();
        List<Book> book_list = new List<Book>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_User_OnClick(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(User_ID_Input.Text);
            string username = User_Name_Input.Text;
            string useraddress = User_Address_Input.Text;

            User temp_user = new User();
            temp_user.setName(username);
            temp_user.setAddress(useraddress);
            temp_user.setID(userid);

            users_list.Add(temp_user);

            MessageBox.Show("User has been added successfully");

            User_ID_Input.Text = String.Empty;
            User_Name_Input.Text = String.Empty;
            User_Address_Input.Text = String.Empty;
        }

        private void Add_Book_OnClick(object sender, EventArgs e)
        {
            int bookid = Convert.ToInt32(Book_ID.Text);
            string bookname =Book_Name.Text;
            string bookauthor =Book_Author.Text;
            string bookpublisher =Book_Publisher.Text;
            int bookquantity =Convert.ToInt32(Book_Quantity.Text);

            Book temp_book = new Book();
            temp_book.setBookName(bookname);
            temp_book.setBookQuantity(bookquantity);
            temp_book.setBookID(bookid);
            temp_book.setBookAuthor(bookauthor);
            temp_book.setBookPublisher(bookpublisher);

            book_list.Add(temp_book);

            MessageBox.Show("Book has been added successfully");

            Book_ID.Text = String.Empty;
            Book_Name.Text = String.Empty;
            Book_Author.Text = String.Empty;
            Book_Publisher.Text = String.Empty;
            Book_Quantity.Text = String.Empty;
        }

        private void Show_Book_History_OnClick(object sender, EventArgs e)
        {
            int check_id = Convert.ToInt32(Book_ID_History.Text);
            for(int i=0; i<book_list.Count; i++)
            {
                if (check_id == book_list[i].getBookID())
                {
                    Book_ID_Output.Text = Convert.ToString(book_list[i].getBookID());
                    Book_Name_Output.Text = book_list[i].getBookName();
                    Book_Author_Output.Text = book_list[i].getBookAuthor();
                    Book_Publisher_Output.Text = book_list[i].getBookPublisher();
                    Book_Quantity_Output.Text = Convert.ToString(book_list[i].getBookQuantity());
                }
            }
            Book_ID_History.Text = String.Empty;

        }

        private void Borrow_OnClick(object sender, EventArgs e)
        {
            int borrow_user_id = Convert.ToInt32(User_ID_Borrow.Text);
            int borrow_book_id = Convert.ToInt32(Book_ID_Borrow.Text);

            for(int i = 0; i < users_list.Count; i++)
            {
                if (borrow_user_id == users_list[i].getUserID())
                {
                    users_list[i].setBook(borrow_book_id);
                    for(int j=0; j<book_list.Count; j++)
                    {
                        if (borrow_book_id == book_list[i].getBookID())
                        {
                            book_list[i].decrease();
                        }
                    }
                }
            }
        }

        private void ShowUserHistory_OnClick(object sender, EventArgs e)
        {
            User_History_Output.Items.Clear();
            int userid = Convert.ToInt32(User_ID_History.Text);
            for (int i = 0; i<users_list.Count; i++)
            {
                if(userid == users_list[i].getUserID())
                {
                   
                }
            }
        }
    }
}
