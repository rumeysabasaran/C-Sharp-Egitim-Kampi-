using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    class Program
    {
        static void Main(string[] args)
        {
            //CRUD-Create-Read-Update-Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");

            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName=Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source= RUMEYSA\\SQLEXPRESS03; initial catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory(CategoryName) values(@p1)",connection);
            //command.Parameters.AddWithValue("@p1",categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori başarılı bir şekilde eklendi");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Eklemek istediğiniz ürün adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Eklemek istediğiniz ürün fiyatı: ");
            //productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=RUMEYSA\\SQLEXPRESS03;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (productName,productPrice,productStatus) values (@productName,@productPrice,@productStatus)",connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice",productPrice);
            //command.Parameters.AddWithValue("@productStatus",true);

            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Ürün eklemesi başarılı");

            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=RUMEYSA\\SQLEXPRESS03;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * from TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command); // /veritabanı ile DataTable arasında veri transferini sağlar.
            //DataTable dataTable = new DataTable(); // Veritabanından alınan verileri geçici olarak tutmak için kullanılır.SqlDataAdapter ile doldurulabilir.
            //adapter.Fill(dataTable); // Veritabanından veriyi alır ve DataTable nesnesine doldurur.

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün Id: ");
            //int productId=int.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=RUMEYSA\\SQLEXPRESS03;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();

            //SqlCommand command=new SqlCommand("delete from TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId",productId); //SQL komutun içinde geçen parametreli ifadeye bir değer atamak için kullanılır.


            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.Write("Ürün başarıyla silindi.");







            #endregion

            #region Ürün Güncelleme İşlemi 

            Console.Write("Güncellenecek Ürün Id: ");
            int productId = int .Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı: ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source= RUMEYSA\\SQLEXPRESS03; initial catalog=EgitimKampiDb;integrated security=true");

            connection.Open();

            SqlCommand command=new SqlCommand("update TblProduct Set productName=@productName,productPrice=@productPrice where productId=@productId",connection);

            command.Parameters.AddWithValue("@productName",productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId",productId);
            command.ExecuteNonQuery();

            connection.Close();

            Console.Write("Güncelleme başarıyla gerçekleştirildi");

            #endregion

            Console.Read();
        }
    }
}
