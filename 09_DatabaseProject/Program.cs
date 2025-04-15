using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ado.net C#'da veritabanlarına bağlanmak, veri sorgulamak, veri güncellemek ve veriyle etkileşim kurmak için kullanılır.

            Console.WriteLine();
            Console.WriteLine("***** C# Veri Tabanlı Ürün Kategori Bilgi Sistemi *****");
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
          
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine();
            
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber=Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=RUMEYSA\\SQLEXPRESS03;initial Catalog=EgitimKampiDb;integrated security=true");

            // Connect yapınca çıkan MSSQL'deki sunucu adımız = Data Source=RUMEYSA\\SQLEXPRESS03
            // Veritabanı ismimiz = Catalog=EgitimKampiDb
            
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory",connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach(var item in row.ItemArray) 
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
