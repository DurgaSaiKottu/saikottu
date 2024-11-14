using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Books
    {
        public string BookName;
        public string AuthorName;
        public string bookName
        {
            get { return BookName; }
            set { BookName = value; }
        }
        public string authorName
        {
            get { return AuthorName; }
            set { AuthorName = value; }
        }

        public Books(string BookName, string AuthorName)
        {
            this.BookName = BookName;
            this.AuthorName = AuthorName;
        }

        public void Display()
        {
            Console.WriteLine("Book Name : " + BookName);
            Console.WriteLine("Author Name : " + AuthorName);
        }
    }
    class BookShelf
    {
        Books[] data = new Books[5];

        public Books this[int i]
        {
            get { return data[i]; }
            set { data[i] = value; }
        }

        static void Main(string[] args)
        {
            BookShelf bookShelf = new BookShelf();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Book " + (i + 1) + " Details");
                Console.WriteLine("Enter Book " + (i + 1) + " Name : ");
                string bookname = Console.ReadLine();
                Console.WriteLine("Enter Book " + (i + 1) + " AuthorName : ");
                string authorname = Console.ReadLine();
                bookShelf[i] = new Books(bookname, authorname);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Book " + (i + 1) + " Details : ");
                bookShelf[i].Display();
            }
            Console.Read();
        }
    }
}
