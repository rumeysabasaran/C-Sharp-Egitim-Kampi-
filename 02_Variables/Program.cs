using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Variables
            //Console.OutputEncoding = System.Text.Encoding.Unicode;
            ////double number;
            ////number = 3.5;
            ////Console.WriteLine(number);

            //Console.WriteLine("*****Fiyat Listesi*****");
            //Console.WriteLine();
            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Elma Birim Fiyatı:" + applePrice +"₺");
            //Console.WriteLine("---- Portakal Birim Fiyatı:" + orangePrice+"₺");
            //Console.WriteLine("---- Çilek Birim Fiyatı:" + strawberryPrice + "₺");
            //Console.WriteLine("---- Patates Birim Fiyatı:" + potatoPrice + "₺");
            //Console.WriteLine("---- Domates Birim Fiyatı:" + tomatoPrice + "₺");

            //Console.WriteLine();

            //double appleGram,orangeGram, strawberryGram, potatoGram, tomatoGram;
            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("Alınan Ürün: Elma - " + " Birim Fiyat: "+applePrice+" - Gramaj: " +appleGram+ " -" + " Toplam Tutar: "+appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - " + " Birim Fiyat: "+orangePrice+" - Gramaj: " +orangeGram+ " -" + " Toplam Tutar: "+appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek - " + " Birim Fiyat: "+strawberryPrice+" - Gramaj: " +strawberryGram+ " -" + " Toplam Tutar: "+strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - " + " Birim Fiyat: "+potatoPrice+" - Gramaj: " +potatoGram+ " -" + " Toplam Tutar: "+potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - " + " Birim Fiyat: "+tomatoPrice+" - Gramaj: " +tomatoGram+ " -" + " Toplam Tutar: "+tomatoTotalPrice);

            //double shoppingTotalPrice=appleTotalPrice+orangeTotalPrice+strawberryTotalPrice+potatoTotalPrice+tomatoTotalPrice;
            //Console.WriteLine("Alışveriş Toplam Tutar: "+shoppingTotalPrice);



            #endregion

            #region Char Variables

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Keyboard Input - String Variables

            //Console.WriteLine("***** Başaran Hava Yolları Yolcu Bilgisi *****");
            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;
            //Console.Write("Yolcu Adı : ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname= Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict= Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity= Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge= Console.ReadLine();

            //Console.Write("TC Kimlik Numara: ");
            //passengerIdentityNumber= Console.ReadLine();

            //Console.Write("--------------------------------------");
            //Console.WriteLine();
            //Console.Write("Yolcu Ad-Soyad: "+passengerName +" - "+ passengerSurname +" / Yolcu Kimlik Numarası: "+ passengerIdentityNumber+" / Yolcu Yaşı: " +passengerAge+ " / Yolcu İkamet: "+passengerDistrict+" / "+passengerCity);

            #endregion

            #region Integer Input from Keyboard and Conversions

            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoeCount,computerCount,chairCount,tvCount;
            //  Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = (shoeCount * shoePrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice);

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: "+totalPrice);






            #endregion

            #region Floating-Point Transictions from Keyboard

            //double exam1, exam2, exam3, result;
            //Console.Write("Lütfen birinci sınav notunu giriniz: ");
            //exam1=double.Parse(Console.ReadLine()); Console.Write("Lütfen ikinci sınav notunu giriniz: ");
            //exam2=double.Parse(Console.ReadLine()); Console.Write("Lütfen üçüncü sınav notunu giriniz: ");
            //exam3=double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3)/3;
            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: "+result);




            #endregion

            #region Char Input from Keyboard
            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender=char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyet: "+gender);
            #endregion

            Console.ReadKey();
        }
    }
}
