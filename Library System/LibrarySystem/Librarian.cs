using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Librarian:User
    {
       public int EmployeeNumber { get; set; }
        public Librarian(string name)
        {
            base.Name = name;
        }

        public void AddBook(Book newBook,Library library) 
        {
            //logic body
            library.Add(newBook);
        }
        public void RemoveBook(Book newbook,Library library)
        {
            //logic body
            library.Remove(newbook);

        }

    }
}
