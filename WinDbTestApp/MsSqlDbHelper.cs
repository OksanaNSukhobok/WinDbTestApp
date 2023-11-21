using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinDbTestApp
{
    public class MsSqlDbHelper
    {
        public static string DoDbTest()
        {
            string s = " ";

            string strCnn = "Server=(localdb)\\MSSQLLocalDB;Integrated Security=true";
            using (var cnn = new SqlConnection(strCnn))
            {
                var cmd = cnn.CreateCommand();
                cmd.CommandText = "SELECT 1";
                cnn.Open();

                var rdr = cmd.ExecuteReader();

                while (rdr.Read()) 
                {
                    // get the results of each column
                    s += (string)rdr[0].ToString() + " ";
                }
            }

                return s;
        }
    }
}
