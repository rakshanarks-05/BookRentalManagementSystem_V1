using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem
{
    public  class Book
    {
        private int BookId {  get; set; }
        private string Title { get; set; }
        private string Author { get; set; }
        private decimal RentalPrice { get; set; }

        public Book(int bookid, string title, string author, decimal rentalPrice)
        {
            BookId = bookid;
            Title = title;
            Author = author;
            RentalPrice = rentalPrice;
        }

        public override string ToString()
        {
            return $"bookId: {BookId}, title: {Title}, author: {Author}, rentalPrice: {RentalPrice}";
        }
    }


}
