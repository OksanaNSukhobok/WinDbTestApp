using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace WinDbTestApp
{
    public class SqLiteDbHelper
    {
        public static string DoDbTest()
        {
            string s = " ";

            string strCnn = @"Data Source=""C:\Work\C#\WinDbTestApp\SqLite\dbtest.db"";Version=3;";
            using (var cnn = new SQLiteConnection(strCnn))
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
