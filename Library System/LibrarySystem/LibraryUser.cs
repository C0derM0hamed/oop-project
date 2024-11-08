using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class LibraryUser:User
    {
      public Librarycard card {  get; set; }

        public LibraryUser(string name)
        {
           Name = name;
        }

        public void DisplayBook() 
        {
        //add logic
        }
        public void BorrowBook(Book book,Library library) 
        {
        library.BorrowBook(book);
        }

    }
}
