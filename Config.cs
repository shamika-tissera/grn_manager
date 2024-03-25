using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRN_Manager
{
    public class Config
    {

        // Change the connection string to your own
        private static string connectionString = "Data Source=DESKTOP-5EUBN8Q;Initial Catalog=grn;Persist Security Info=True;User ID=Shamika-SQLServer;Password=root";

        public static string getConnectionString()
        {
            return connectionString;
        }

    }
}
