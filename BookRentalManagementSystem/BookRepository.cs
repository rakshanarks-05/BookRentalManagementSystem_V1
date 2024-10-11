using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookRentalManagementSystem
{
    internal class BookRepository
    {
        public string _connectionstring = "(localdb\\MSSQLocalDB);dtabase=BookRentalManagementSystem;Trust_Connection=true;TrustServerCertificate=true;";

        var connection = new SqlConnection((_connectionstring));

    }
}
