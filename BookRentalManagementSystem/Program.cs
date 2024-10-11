using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bookrepository = new BookRepository();
            var bookmanager = new BookManager();
            bool exit = false;

            while (exit)
            {
                Console.Clear();
                Console.WriteLine("\n......Book Rental Management System:");
                Console.WriteLine("1. Add a Book:");
                Console.WriteLine("2. View All Books:");
                Console.WriteLine("3. Update a Book:");
                Console.WriteLine("4. Delete a Book:");
                Console.WriteLine("5.  Exit:");
                Console.WriteLine("Choose an option:");
                string.option = Console.ReadLine();



                switch (option)
                {
                    case "1":
                        console.Write("Enter a Title");
                        string title = BookRepository.CapitalizeTitle(Console.ReadLine());
                        Console.WriteLine("Enter a Author");
                        string author=Console.ReadLine();
                        Console.WriteLine("Enter book id  to update");
                        decimal rentalprice = bookmanager.ValidateBookRental();
                        bookrepository.Createbook(title, author, rentalprice);


                        break;


                    case "2":
                        Console.Clear();
                        bookrepository.GetAll();
                        Console.WriteLine();


                        break;



                    case "3":
                        Console.Clear();

                        Console.WriteLine("Enter Id to update");
                        int updateid=int.Parse(Console.ReadLine());
                        console.Write("Enter a Title");
                        string newtitle = BookRepository.CapitalizeTitle(Console.ReadLine());
                        Console.WriteLine("Enter a Author");
                        string newauthor = Console.ReadLine();
                        Console.WriteLine("Enter a rentalprice");
                        decimal rentalprice = bookmanager.ValidateBookRental();
                        bookrepository.Createbookupdateid,(newtitle, newauthor, newrentalprice);

                        break;









                }

            }
        }
        public string CapitalizeTitle(string title)
        {
            var words=title.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();

            }
            return words[0];
            










    }
}
