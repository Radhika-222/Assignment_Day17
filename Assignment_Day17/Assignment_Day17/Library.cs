using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Day17
{
    public class Library
    {
        private List<Book> books=new List<Book>();
        
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book added successfully!");
        }
        public void ViewAllBooks()
        {
            foreach(var book in books)
            {
                Console.WriteLine($"Id: {book.Id}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, IsAvailable: {book.IsAvailable}");

            }

        }

        public void SearchBookById(int Id)
        {
            var book = books.Find(b => b.Id == Id);
            if(book!=null)
            {
                Console.WriteLine($"Id: {book.Id}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, IsAvailable: {book.IsAvailable}");
            }
            else
            {
                Console.WriteLine("Book not found!");
            }
        }
        public void SearchBookByTitle(string title)
        {
            var book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if(book!=null)
            {
                Console.WriteLine($"Id: {book.Id}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, IsAvailable: {book.IsAvailable}");
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }
    }
}
