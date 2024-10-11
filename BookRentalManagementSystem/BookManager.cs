using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem
{
    public class BookManager
    {
        public List<Book> books = new List<Book>();

        public void CreateBook(string title, string author, decimal rentalprice)
        {
            var book = new Book((books.Count + 1), title, author, rentalprice);
            books.Add(book);
            Console.WriteLine("\n Books added successfully......");
            return;
        }

        public void ReadBooks()
        {
            Console.WriteLine("\n.....BookList.....");
            if (books.Count > 0)
            {
                foreach (var book in books)
                {
                    Console.WriteLine($"BookId:{book.BookId},Title:{book.Title},Author:{book.Author},RentalPrice{book.RentalPrice}");

                }
            }
            else
            {
                Console.WriteLine("\n.....Books Not Found....");
            }
        }
        public void UpdateBooks(int updateid, string newtitle, string newauthor, decimal newrentalprice)
        {
            var book = books.Where(b => b.BookId == updateid)
                .FirstOrDefault();
            Console.WriteLine(updateid);
            if (book != null)
            {
               
                book.Title = newtitle;
                book.Author = newauthor;
                book.Rentalprice = newrentalprice;
                Console.WriteLine("\n...Book updated successfully......");




            } else {
                Console.WriteLine("...Books not Found....");
            }

            
        }

        public void DeleteBooks(int bookid)
        {
            var book= books.Find(b=>b.Equals(bookid));
            Console.WriteLine(bookid);
            if (book != null)
            {
                Console.WriteLine("\n....Book deleted successfully.....");

            }
            else
            {
                Console.WriteLine("\n....Books not Found");
            }
        }

        //public string ValidateBookRental()
    }
}
