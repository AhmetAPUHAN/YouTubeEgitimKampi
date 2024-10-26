using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ado.net
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GSF8MQK\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True;Encrypt=False ");
            connection.Open();
            SqlCommand command = new SqlCommand("select*from TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write
                        (item.ToString());
                }
                Console.WriteLine();
            }







            #endregion

            Console.Read();
        }
    }
}
