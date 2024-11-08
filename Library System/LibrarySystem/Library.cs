using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    public class Library
    {
       private Book[] books=new Book[100];
       private Book[] BorrowedBooks=new Book[50];
       private int currnetBookCount=0;
       private int currnetBorrwedBookCount=0;
        public void Add(Book book) 
        {
            if (currnetBookCount < books.Length)
            {
                books[currnetBookCount] = book;
                currnetBookCount++;
                Console.WriteLine("Book added succesflly");
            }
            else { Console.WriteLine("Library is full , can not add new book"); }
        }
        public void Remove(Book book)
        {
            Array.IndexOf(books, book);
            currnetBookCount--;
            Console.WriteLine("book removed succesflly");
        }

        public void Display() 
        {
            for (int i = 0; i < currnetBookCount; i++) 
            {
                Console.WriteLine(books[i].Tittle);
            }
        }
        public void BorrowBook(Book book) 
        {
            if (currnetBorrwedBookCount < BorrowedBooks.Length)
            {
                books[currnetBorrwedBookCount] = book;
                currnetBorrwedBookCount++;
                Console.WriteLine("Book Borrwed succesflly");
            }
            else { Console.WriteLine("Sorry Cant borrow more books"); }
        }

    }
}
