using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem
{
    public  class Book
    {
        private string Bookid {  get; set; }
        private string Title { get; set; }
        private string Author { get; set; }
        private decimal RentalPrice { get; set; }
    }
}
