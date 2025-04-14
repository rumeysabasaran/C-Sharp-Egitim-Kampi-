using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FOR LOOP

            //For(x;y;z) x:başlangıç y:bitiş z:artış-azalış

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //----------------------------------------------

            //for (int i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //-----------------------------------------------

            //Console.WriteLine("Lütfen ekrana yazılmasını istediğiniz değeri giriniz.");
            //int finishValue=int.Parse(Console.ReadLine());
            //for (int i = 0; i <= finishValue; i++)
            //{
            //     Console.WriteLine("18 Mart Çanakkale Zaferi");
            //}

            #endregion

            #region FOR LOOP WITH DECISION STRUCTURES

            //Console.WriteLine("5'e tam bölünen sayılar");
            //for (int i = 0; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //---------------------------------------------

            //Girilen sayıya kadar olan çift sayıların toplamı
            //int totalValue = 0;
            //int finishValue;
            //Console.Write("Sayı giriniz: ");
            //finishValue = int.Parse(Console.ReadLine());
            //for (int i = 0; i < finishValue; i++)
            //{
            //    if (i %2==0)
            //    {
            //        totalValue += i;
            //    }  
            //}
            //Console.WriteLine("Çift sayıların toplamı: " + totalValue);

            //-----------------------------------------------
            //1 ile 50 arasında 7'ye tam bölünen kaç tane sayı olduğunu bulan kod

            //int count= 0;
            //for (int i = 1; i < 50; i++)
            //{
            //    if (i % 7 == 0)
            //    {
            //        count++;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("1 ve 50 arasında 7'ye bölünebilen sayıların adedi: " + count);

            //-----------------------------------------------


            #endregion

            #region WHILE LOOP

            //While(Şart)
            //{
            //işlemler
            //}

            //girilen sayıya kadar olan sayıların toplamı
            //int i = 1;
            //int finishValue;
            //int total = 0;
            //Console.Write("Bitiş değerini giriniz: ");
            //finishValue=int.Parse(Console.ReadLine());
            //while (i <= finishValue)
            //{
            //total=total+i;
            //    i++;
            //}
            //Console.WriteLine(finishValue+"'ya kadar olan sayıların toplamı: "+ total);
            //-----------------------------------------------------------------------------








            #endregion

            #region EXAMPLE

            // Klavyeden girilen üç basamaklı sayının basamakları toplamını hesaplayan kod

            //Console.Write("Sayı giriniz: ");
            //int number=int.Parse(Console.ReadLine());
            //int ones, tens, hundred;
            //int sum;

            //ones = number % 10;
            //hundred = number / 100;
            //tens = (number / 10) % 10;

            //sum= ones+tens+hundred;

            //Console.WriteLine("SAYI: " + number);
            //Console.WriteLine("Yüzler Basamağı : " + hundred);
            //Console.WriteLine("Onlar Basamağı : "+tens); 
            //Console.WriteLine("Birler Basamağı: " + ones);

            //Console.WriteLine("Toplamları: " + sum);

            #endregion

            Console.ReadKey();
        }
    }
}
