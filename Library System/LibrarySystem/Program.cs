using LibrarySystem;
using System;

namespace MyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to the library system");
            Library library = new Library();
            Console.WriteLine("Are you librarian or regular user (L/R)");
            char userType = Console.ReadLine().ToUpper()[0];


            if (userType == 'L')
            {
                Console.WriteLine("Enter your name");
                string librarianName = Console.ReadLine();
                Librarian l1 = new Librarian(librarianName);
                Console.WriteLine($"Welcome {l1.Name}");
                while (true)
                {
                    Console.WriteLine("Please choose to add book (A)/ Remove book(R) / Display book(d )");
                    char choice = Console.ReadLine().ToUpper()[0];
                    switch (choice)
                    {
                        case 'A':
                            Console.WriteLine("Enter the book details");
                            Console.WriteLine("Enter the Book name");
                            string bookName = Console.ReadLine();
                            Console.WriteLine("Enter the Book Author");
                            string bookAuthor = Console.ReadLine();
                            Console.WriteLine("Enter the Book Year");
                            int bookYear = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book();
                            {
                                book.Tittle = bookName;
                                book.Auther = bookAuthor;
                                book.Year = bookYear;
                            }
                            l1.AddBook(book, library);
                            break;

                        case 'R':
                            Console.WriteLine("Enter the book details to remove");
                            Console.WriteLine("Enter the Book name");
                            bookName = Console.ReadLine();
                            Console.WriteLine("Enter the Book Author");
                            bookAuthor = Console.ReadLine();
                            Console.WriteLine("Enter the Book Year");
                            bookYear = Convert.ToInt32(Console.ReadLine());
                            book = new Book();
                            {
                                book.Tittle = bookName;
                                book.Auther = bookAuthor;
                                book.Year = bookYear;
                            }
                            l1.AddBook(book, library);
                            break;

                        case 'D':
                            Console.WriteLine("The book list :");
                            l1.DisplayBook(library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;

                    }
                }
            }



            else if (userType == 'R')
            {
                Console.WriteLine("Welcom user, Enter your name");
                string Name = Console.ReadLine();
                LibraryUser u1 = new LibraryUser(Name);
                Console.WriteLine($"Welcome {u1.Name}");
                while (true)
                {
                    Console.WriteLine("Please choose to Display book(D) or Borrow Book (B)");
                    char choice = Console.ReadLine().ToUpper()[0];
                    switch (choice)
                    {
                        case 'D':
                            Console.WriteLine("The book list :");
                            u1.DisplayBook(library);
                            break;
                        case 'A':
                            Console.WriteLine("Enter the book You want to borrow");
                            string bookName = Console.ReadLine();
                            string bookAuthor = Console.ReadLine();
                            int bookYear = Convert.ToInt32(Console.ReadLine());
                            Book book = new Book();
                            {
                                book.Tittle = bookName;
                                book.Auther = bookAuthor;
                                book.Year = bookYear;
                            }
                            u1.BorrowBook(book, library);
                            break;
                        default:
                            Environment.Exit(0);
                            break;

                    }
                }
            }
            else
            {
                Console.WriteLine("Please entenr correct value (L or R)");
            }
                

            

        }
    }
}