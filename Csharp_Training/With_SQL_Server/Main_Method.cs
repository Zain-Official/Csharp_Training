using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace Csharp_Training.With_SQL_Server
{
    class Main_Method
    {
        static void Main(string[] args)
        {
            SqlConnection conn=null;

            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-N43NUMQ\ZAIN_SINDHI;Initial Catalog=Practice; Integrated Security=true;");
                conn.Open();
                Console.WriteLine("Connection Connected Successfully......!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                    Console.WriteLine("Connection Closed Successfully.....!!!!!!!");
                }

            }
        }
    }
}
