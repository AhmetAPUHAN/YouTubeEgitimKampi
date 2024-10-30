using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Kategori ekleme 
            Console.WriteLine("***Menü Sipariş İşlem Paneli**");
            Console.WriteLine();
            Console.WriteLine("----------------------");
            Console.WriteLine("Eklemek istediğiniz kategori adını giriniz: ");
            string newCategoriName = Console.ReadLine();
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GSF8MQK\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True;Encrypt=False ");
            connection.Open();
            SqlCommand command = new SqlCommand("insert into TblCategory(Name) values (@p1)", connection);
            command.Parameters.AddWithValue("@p1", newCategoriName);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Kategori eklendi");
            #endregion
            #region Ürün Ekleme
            string productName;
            decimal productPrice;
            Console.Write("Ürün adı: ");
            productName = Console.ReadLine();
            Console.Write("Ürün Fiyatı: ");
            productPrice=decimal.Parse(Console.ReadLine());
            SqlConnection connection1 = new SqlConnection("Data Source=DESKTOP-GSF8MQK\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True;Encrypt=False ");
            connection.Open();
            SqlCommand command1 = new SqlCommand("insert into TblProduct(Name,Price,Status) values (@p1,@p2,@p3)", connection);
            command1.Parameters.AddWithValue("@p1", productName);
            command1.Parameters.AddWithValue("@p2",productPrice);
            command1.Parameters.AddWithValue("@p3",true);
            command1.ExecuteNonQuery();
            connection1.Close();
            Console.WriteLine("Ürün Eklemesi Başarılı");






            #endregion
            #region Ürün Listeleme
            SqlConnection connection2 = new SqlConnection("Data Source=DESKTOP-GSF8MQK\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True;Encrypt=False ");
            connection2.Open();
            SqlCommand command2 = new SqlCommand("select*from TblProduct", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command2);
            DataTable dataTable= new DataTable();
            adapter.Fill(dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString()+" ");
                }
                Console.WriteLine();
            }
            connection2.Close();




            #endregion
            #region Ürün Silme 
            Console.WriteLine("Silinecek Ürün Id giriniz: ");
            int productId = int.Parse(Console.ReadLine());
            SqlConnection connection3 = new SqlConnection("Data Source=DESKTOP-GSF8MQK\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True;Encrypt=False ");
            connection3.Open();
            SqlCommand command3 = new SqlCommand("delete from TblProduct where productId=@p1", connection);
            command3.Parameters.AddWithValue("@p1", 1004);
            command3.ExecuteNonQuery();
            connection3.Close();
            Console.WriteLine("Ürün silindi.") ;

            #endregion

            #region Ürün Güncelleme
            Console.WriteLine("Güncellenecek ürün Id: ");
            int productId1= int.Parse(Console.ReadLine());
            Console.WriteLine("Güncellenecek Ürün Adı: ") ;
            string productName1=Console.ReadLine();
            Console.WriteLine("Güncellenecek Ürün Fiyatı");
            decimal price = decimal.Parse(Console.ReadLine());

            SqlConnection connection4= new SqlConnection("Data Source=DESKTOP-GSF8MQK\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True;Encrypt=False ");
            connection4.Open();

            SqlCommand command4 = new SqlCommand("Update TblPorduct set name=@p1,price=@p2 where Id=@p3",connection);
            command4.Parameters.AddWithValue("@p1", productName1);
            command4.Parameters.AddWithValue("@p2",price);
            command4.Parameters.AddWithValue("@p3", productId1);
            connection4.Close();

            


            #endregion

            Console.Read();
        }
    }
}
