using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Foreach(Değişken türü,Değişken adı,In,Liste,Koleksiyon veya Dizinin Adı)
            //4 parametre içeriyor.İlk parametre değişken türü,ikinci parametre değişken adı,üçüncü parametre In ve dördüncü parametre ise liste, koleksiyon veya dizinin adı.

            #region Foreach Loop

            //string[] cities = { "Ankara", "İstanbul", "İzmir", "Adana", "Bursa", "Milano" };
            //foreach (string city in cities)
            //{
            //    Console.WriteLine(city);
            //}

            //----------------------------------- DİZİ LİSTELEME -----------------------------------------

            //int[] numbers = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}

            //------------------------------------- DİZİ TOPLAM -----------------------------------------

            //int[] numbers2 = { 45, 78, 985, 635, 74, 11, 22, 33, 41, 205, 6578, 10394 };

            //int total = 0;

            //foreach (int i in numbers2)
            //{
            //    total += i;
            //}
            //Console.WriteLine("Toplam: " + total);

            //------------------------------------ LİSTE YAPISI ------------------------------------------

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,8
            //};

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //------------------------------KELİMEYİ HARFLERİNE AYIRMA ------------------------------------

            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}

            //---------------------------------------------------------------------------------------------



            #endregion

            #region SAMPLE EXAM SYSTEM

            Console.Write("***** C# EĞİTİM KAMPI SINAV UYGULAMASI *****");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Sınıftaki öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine();
            Console.Write("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
             
            //Öğrenci isimlerini ve sınav ortalamalarını tutacak dizileri oluşturma
            string[]studentNames= new string[studentCount];
            double[]studentExamAverage= new double[studentCount];

            for(int i=0;i<studentCount;i++)
            {
                Console.Write($"{i+1}. Öğrencinin Adını Giriniz: ");
                studentNames[i] = Console.ReadLine();
                Console.WriteLine();

                double totalExam = 0;

                for(int j=0;j<3;j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j+1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExam += value;
                }
                Console.WriteLine();
                studentExamAverage[i] = totalExam / 3;

            }

            //Öğrencilerin ortalaması ve geçip geçmedikleri bilgisi

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]} isimli öğrencinin sınav ortalaması: {studentExamAverage[i]} ve durumu: {(studentExamAverage[i] >= 50 ? "Geçti" : "Kaldı")}");
                Console.WriteLine();
            }

            #endregion

            Console.ReadLine();



        }
    }
}
