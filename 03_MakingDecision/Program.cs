using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF EXAMPLE 1
            //Console.Write("Lütfen şifreyi giriniz: ");
            //string password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru girildi.");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış girildi.");
            //}
            //Console.ReadKey();
            #endregion

            #region IF EXAMPLE 2
            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı.");
            //}
            //else
            //{ 
            //    Console.Write("Hatalı Bilgi Girildi");
            //}
            //Console.ReadKey();
            #endregion

            #region IF EXAMPLE 3
            //int number;
            //Console.Write("Sayıyı Giriniz: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı Doğru.");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Yanlış.");
            //}
            //Console.ReadLine();
            #endregion

            #region IF EXAMPLE 4

            //int exam1, exam2,exam3,average;
            //string result="Hata!";
            //Console.Write("İlk sınav notunu giriniz: ");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("İkinci sınav notunu giriniz: ");
            //exam2=int.Parse(Console.ReadLine());
            //Console.Write("Üçüncü sınav notunu giriniz: ");
            //exam3=int.Parse(Console.ReadLine());

            //average=(exam1+exam2+exam3)/3;
            //Console.WriteLine("Sınavların ortalaması: " + average);

            //if (average > 0 & average<=50)
            //{
            //   result="Sonuç Vasat";
            //}
            //if (average>50 & average <=70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if (average > 84 )
            //{
            //    result = "Sonuç Çok İyi";
            //}
            //Console.WriteLine("SINAV SONUCU : " +result);
            //Console.ReadLine() ;
            #endregion

            #region IF EXAMPLE 5

            //string city;
            //Console.Write("Şehir Giriniz: ");
            //city=Console.ReadLine();
            //if (city == "adana"| city == "bursa"| city == "ankara"|city =="trabzon")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}
            //Console.ReadLine();
            #endregion

            #region IF EXAMPLE 6
            //Console.Write("LÜtfen kullanıcı adını giriniz: ");
            //string username=Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("Bu kullanıcı adı kabul edilemez.");
            //}
            //else
            //{
            //    Console.Write("Hoş geldiniz.");
            //}
            //Console.Read();

            #endregion

            #region MODULUS OPERATION
            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            //int number1=int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.sayıyı giriniz: ");
            //int number2=int.Parse(Console.ReadLine());
            //int result=number1%number2;
            //Console.Write("1.sayının 2.sayıya bölümünden kalan: "+result);
            //Console.ReadLine();
            #endregion

            #region MOD-2
            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("Sayı çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı tektir");
            //}
            //Console.ReadLine();
            #endregion

            #region SWITCH CASE
            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber=int.Parse(Console.ReadLine());
            //switch (monthNumber)
            //{
            //    case 1:Console.Write("Ocak"); break;
            //    case 2:Console.Write("Şubat"); break;
            //    case 3:Console.Write("Mart"); break;
            //    case 4:Console.Write("Nisan"); break;
            //    case 5:Console.Write("Mayıs"); break;
            //    case 6:Console.Write("Haziran"); break;
            //    case 7:Console.Write("Temmuz"); break;
            //    case 8:Console.Write("Ağustos"); break;
            //    case 9:Console.Write("Eylül"); break;
            //    case 10:Console.Write("Ekim"); break;
            //    case 11:Console.Write("Kasım"); break;
            //    case 12:Console.Write("Aralık"); break;
            //    default:Console.Write("Hatalı Veri Girişi!");break;
            //}
            //Console.ReadLine();
            #endregion

            #region CALCULATOR
            //char symbol;
            //Console.Write("1.sayıyı giriniz: ");
            //int number1=int.Parse(Console.ReadLine());
            //Console.Write("2.sayıyı giriniz: ");
            //int number2=int.Parse(Console.ReadLine());
            //Console.Write("Yapmak istediğiniz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());
            //int result;

            //switch (symbol)
            //{
            //    case'+': result = number1 + number2;
            //             Console.WriteLine("Toplam: " + result);break;
            //    case'-': result = number1 - number2;
            //             Console.WriteLine("Fark: " + result); break;
            //    case'*': result = number1 * number2;
            //             Console.WriteLine("Çarpım: " + result); break;
            //    case '/':result = number1 / number2;
            //             Console.WriteLine("Bölüm: " + result); break;
            //    default:Console.WriteLine("HATALI VERİ GİRİŞİ");break;
            //}
            //Console.ReadLine();
            #endregion
        }
    }
}