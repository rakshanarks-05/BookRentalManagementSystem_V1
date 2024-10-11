using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem
{
    public class PrintedBook : Book
    {
        public int ISBN { get; set; }
        public int NumberOfPages { get; set; }

        public PrintedBook(int iSBN, int numberOfPages,int bookid, string title, string author, decimal rentalPrice)
            :base(bookid, title, author, rentalPrice,iSBN,numberOfPages)
           
        { 
            ISBN = iSBN;
            NumberOfPages = numberOfPages;
        }

        public override string ToString()
        {
            return $"base.ToString(),isbn:{ISBN},numberOfPages:{NumberOfPages}";
        }
    }
}
