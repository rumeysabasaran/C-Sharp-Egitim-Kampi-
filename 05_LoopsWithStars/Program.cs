using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region RIGHT TRIANGLE

            //dik üçgen oluşturan kod
            //int height;
            //Console.Write("Üçgenin yüksekliğini giriniz: ");
            //height=int.Parse(Console.ReadLine());
            //for (int i = 1; i <= height; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region RIGHT ARROW
            //TABAN TABANA İKİ DİK ÜÇGEN (SAĞA DOĞRU OK)
            //int height;
            //Console.Write("Üçgenin yüksekliğini giriniz: ");
            //height = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= height; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = height-1 ; i>=1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region DIAMOND

            //int n = 5;

            //// Üst Kısım (Elmasın üst yarısı)
            //for (int i = 1; i <= n; i++)
            //{
            //    // Boşlukları yazdırma
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    // Yıldızları yazdırma
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    // Yeni satıra geçme
            //    Console.WriteLine();
            //}

            //// Alt Kısım (Elmasın alt yarısı)
            //for (int i = n - 1; i >= 1; i--)
            //{
            //    // Boşlukları yazdırma
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    // Yıldızları yazdırma
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }

            //    // Yeni satıra geçme
            //    Console.WriteLine();
            //}

            //// Kullanıcıdan çıkış için bekleme


            #endregion

            #region PYRAMID

            //int n = 7;
            //for (int i = 1; i < n; i++)
            //{
            //    for (int j = n-i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region UPSIDE-DOWN PYRAMID

            int n = 5;
            for (int i=n; i>=0; i--)
            {
                //boşluklar
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                //yıldızlar
                for (int k=1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }



            #endregion

            Console.Read();
            }
        }
    }
