using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Day17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("\nLibrary Management System Menu:");
                Console.WriteLine("1. Add a Book");
                Console.WriteLine("2. View All Books");
                Console.WriteLine("3. Search by ID");
                Console.WriteLine("4. Search by Title");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice (1-5): ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Book newBook = new Book();
                        Console.Write("Enter Book ID: ");
                        newBook.Id = int.Parse(Console.ReadLine());
                        Console.Write("Enter Title: ");
                        newBook.Title = Console.ReadLine();
                        Console.Write("Enter Author: ");
                        newBook.Author = Console.ReadLine();
                        Console.Write("Enter Genre: ");
                        newBook.Genre = Console.ReadLine();
                        Console.Write("Is the book available? (true/false): ");
                        newBook.IsAvailable = bool.Parse(Console.ReadLine());

                        library.AddBook(newBook);
                        break;

                    case 2:
                        library.ViewAllBooks();
                        break;

                    case 3:
                        Console.Write("Enter Book ID to search: ");
                        int searchId = int.Parse(Console.ReadLine());
                        library.SearchBookById(searchId);
                        break;

                    case 4:
                        Console.Write("Enter Title to search: ");
                        string searchTitle = Console.ReadLine();
                        library.SearchBookByTitle(searchTitle);
                        break;

                    case 5:
                        Console.WriteLine("Exiting program. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                        break;
                }
            }
        }
    }
}
