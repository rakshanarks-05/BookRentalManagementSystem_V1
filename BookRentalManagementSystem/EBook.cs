using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem
{
    public class EBook : Book
    {
       public int FileSize {  get; set; }
       public string Format {  get; set; }

        public EBook(string format,int filesize, int bookid, string title, string author, decimal rentalPrice) 
            :base(format, bookid, title, author, rentalPrice)
        {
            this.Format = format;
        }

        public override string ToString()
        {
            return $"base.ToString(),format:{Format}, filesize:{FileSize}";
        }
    }
}
