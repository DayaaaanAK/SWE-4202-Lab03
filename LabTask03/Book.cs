using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask03
{
    internal class Book
    {
        private int book_id;
        private string book_name;
        private string book_author;
        private string book_publisher;
        private int book_quantity;

        public void setBookID(int BookID)
        {
            this.book_id = BookID;
        }
        public void setBookName(string BookName)
        {
            this.book_name = BookName;
        }
        public void setBookAuthor(string BookAuthor)
        {
            this.book_author = BookAuthor;
        }
        public void setBookPublisher(string BookPublisher)
        {
            this.book_publisher = BookPublisher;
        }
        public void setBookQuantity(int BookQuantity)
        {
            this.book_quantity = BookQuantity;
        }

        public int getBookID()
        {
            return this.book_id;
        }
        public string getBookName()
        {
            return this.book_name;
        }
        public string getBookAuthor()
        {
            return this.book_author;
        }
        public string getBookPublisher()
        {
            return this.book_publisher;
        }
        public int getBookQuantity()
        {
            return this.book_quantity;
        }
        public void decrease()
        {
            this.book_quantity--;
        }
    }
}
