using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            Console.WriteLine("*******Yemek Kategorileri********");
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Başlangıçlar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5-Tatlılar");
            Console.WriteLine("6-İçecekler\n");
            #endregion

            #region StringDeğişkenler

            //string
            //degisken_turu degisken_adi;
            //string name;
            //name = "Rumeysa";
            //Console.Write(name);

            string customerName; //camelcase
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Rumeysa";
            customerSurname = "Başaran";
            customerPhone = "+90 190 719 07 19";
            customerEmail = "fenerbahce@gmail.com";
            district = "Kadıköy";
            city = "İstanbul";

            Console.WriteLine("********Rezervasyon Kartı********");
            Console.WriteLine();
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: "+customerPhone);
            Console.WriteLine("Email Adresi: "+ customerEmail);
            Console.WriteLine("Adres: "+district+ "/" + city);
            Console.WriteLine() ;
            Console.WriteLine("*********************************");

            Console.WriteLine();
            customerName = "Büşra";
            customerSurname = "Başaran";
            customerPhone = "+90 161 616 16 16";
            customerEmail = "basaran@gmail.com";
            district = "Gürsu";
            city = "Bursa";
            Console.WriteLine("********Rezervasyon Kartı********");
            Console.WriteLine();
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email Adresi: " + customerEmail);
            Console.WriteLine("Adres: " + district + "/" + city);
            Console.WriteLine();
            Console.WriteLine("*********************************");

            #endregion

            #region IntegerDeğişkenler
            //int
            //int number;
            //number = 0;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int iceteaPrice = 35;
            int waterPrice = 10;
            int pizzaPrice = 150;
            int friesPrice = 50;
            int lemonadePrice = 30;

            Console.WriteLine();
            Console.WriteLine("***** Restoran Menü Fiyatı *****");
            Console.WriteLine();
            Console.WriteLine("Hamburger Fiyatı: " + hamburgerPrice);
            Console.WriteLine("Ice Tea Fiyatı: " + iceteaPrice + " TL");
            Console.WriteLine("Su Fiyatı: " + waterPrice + " TL");
            Console.WriteLine("Pizza Fiyatı: " + pizzaPrice + " TL");
            Console.WriteLine("Kızartma Fiyatı: " + friesPrice + "TL");
            Console.WriteLine("Limonata Fiyatı: " + lemonadePrice + " TL");
            Console.WriteLine();
            Console.WriteLine("********************************");

            int hamburgerCount;
            int iceteaCount;
            int waterCount;
            int pizzaCount;
            int friesCount;
            int lemonadeCount;
            int totalHamburgerPrice = 0;
            int totalIceteaPrice= 0;
            int totalWaterPrice = 0;
            int totalPizzaPrice = 0;
            int totalFriesPrice= 0;
            int totalLemonadePrice = 0;
            int total = 0;
            

            hamburgerCount = 3;
            iceteaCount = 3;
            waterCount = 3;
            pizzaCount = 1;
            friesCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalIceteaPrice= iceteaPrice * iceteaCount;
            totalWaterPrice = waterPrice * waterCount;
            totalPizzaPrice= pizzaPrice * pizzaCount;
            totalFriesPrice = friesPrice * friesCount;
            totalLemonadePrice= lemonadePrice * lemonadeCount;
            total=totalHamburgerPrice+totalIceteaPrice+totalWaterPrice+totalPizzaPrice+totalFriesPrice+totalLemonadePrice;
            
            Console.WriteLine();
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice);
            Console.WriteLine("Ice Tea Tutarı: "+iceteaCount*iceteaPrice);
            Console.WriteLine("Su Tutarı: " + waterCount * waterPrice);
            Console.WriteLine("Pizza Tutarı: " +pizzaCount*pizzaPrice);
            Console.WriteLine("Kızartma Tutarı: "+friesCount*friesPrice);
            Console.WriteLine("Limonata Tutarı: "+lemonadeCount*lemonadePrice);
            Console.WriteLine();
            Console.WriteLine("Toplam Ödenecek Tutar: " + total);
            #endregion

            Console.Read();
        }
    }
}
