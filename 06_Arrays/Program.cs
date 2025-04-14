using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BASIC ARRAY    

            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı];

            //string[]colours = new string[4];
            //colours[0] = "Red";
            //colours[1] = "Blue";
            //colours[2] = "Green";
            //colours[3] = "Yellow";
            //Console.WriteLine(colours[2]);

            //string[]cities= { "Ankara", "İstanbul", "İzmir" };
            //Console.WriteLine(cities[1]);


            #endregion

            #region LISTING  

            //string[] colours = { "Red", "Blue", "Green", "Yellow","Purple","Pink","White"};
            //for (int i = 0; i < colours.Length; i++)
            //{
            //    Console.WriteLine(colours[i]);
            //}

            //-----------------------------------------------------------------------------

            //int[]numbers = { 4,85,96,75,125,635,488,522,7456,2365,1120};

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i]%3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //-----------------------------------------------------------------------------

            //char[]symbols = { 'a', 'b', 'c', '*', '-', '/', 'g', 'h', '?', 'j' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    if (symbols[i] == '*' || symbols[i] == '-' || symbols[i] == '/')
            //    {
            //        Console.WriteLine(symbols[i]);
            //    }
            //}

            //--------------------- Dizideki en büyük elemanı bulma ------------------------    

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int maxNumber = myArray[0];
            //for (int i = 1;i<myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine("Max Number: " + maxNumber);

            //-----------------------------------------------------------------------------

            //string[]persons = { "Ali", "Veli", "Ayşe", "Fatma", "Mehmet", "Ahmet", "Zeynep", "Merve", "Kemal", "Hüseyin" };
            //Console.WriteLine(persons.Length);

            //-----------------------------------------------------------------------------

            //int[] numbers = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //Array.Sort(numbers);
            //Console.WriteLine("Küçükten Büyüğe");
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Console.WriteLine("Tersten Sırala");   
            //Array.Reverse(numbers);
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            // reverse normalde diziyi tersten sıralıyor ama burda küçükten büyüğe sıraladığımız diziye uygulayınca sonuç olarak büyükten küçüğe sıralamış olduk.

            #endregion

            #region ARRAY METHODS

            //--------------------------------İndex Bulma-----------------------------------

            //string[]customers = { "Ali", "Veli", "Ayşe", "Fatma", "Mehmet", "Ahmet", "Zeynep", "Merve", "Kemal", "Hüseyin" };
            //int index = Array.IndexOf(customers, "Mehmet");
            //Console.WriteLine("Mehmetin indexi: " + index);

            //--------------------------------Min Max Eleman Bulma----------------------------
            //int[]numbers = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max());
            //Console.WriteLine("Dizinin en küçük elemanı: " + numbers.Min());

            #endregion

            #region INPUT FROM USER

            //---------------------------String Array----------------------------

            //string[]cities= new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i+1}. şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("Şehirleriniz: ");
            
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //--------------------------Integer Array----------------------------

            //int[]numbers = new int[5];
            //int sum = 0;    
            //Console.WriteLine("Lütfen 5 adet sayı giriniz: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{i+1}. sayıyı giriniz: ");
            //    numbers[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine();
            //Console.WriteLine("Girdiğiniz Sayılar: ");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //    sum=numbers[i]+sum;
            //}
            //Console.WriteLine();
            //Console.WriteLine("Toplam: " + sum);

            //--------------------------------------------------------------------  

            #endregion

            Console.ReadLine();
        }
    }
}
