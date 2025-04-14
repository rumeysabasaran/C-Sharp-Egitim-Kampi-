using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar

            //void CustomerList()
            //{
            //    Console.WriteLine("Rumeysa Başaran");
            //    Console.WriteLine("Gülbahar Yaman");
            //    Console.WriteLine("Ceren Bulut");
            //    Console.WriteLine("Şevval Oruç");
            //    Console.WriteLine("Arzu Majidova");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //-----------------------------------------------

            //void sum()
            //{
            //    int x = 1;
            //    int y= 2;
            //    int z = x+y;
            //    Console.WriteLine(z);
            //}
            //sum();

            //------------------------------------------------
            #endregion
            #region String Parametreli Void Metotlar

            //------------------------------------------------

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Rumeysa Başaran");

            //-------------------------------------------------

            //void CustomerCard(string name,string surname)
            //{
            //    Console.WriteLine("Müşteri: "+name+" "+surname); 
            //}
            //CustomerCard("Rumeysa","Başaran");   
            //CustomerCard("Ayşegül","Kaya");   

            //---------------------------------------------------
            #endregion
            #region Integer Parametreli Void Metotlar

            //void Sum(int num1,int num2,int num3)
            //{
            //    int result=num1 + num2 + num3;
            //    Console.WriteLine("Sonuç: "+result);
            //}
            //Sum(3, 5, 7);

            #endregion
            #region Geriye Değer Döndüren Metotlar 

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surname = "Kaya";
            //    return name + " " + surname;
            //}
            //Console.WriteLine(StudentCard());

            #endregion
            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName,string capital,string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + " Başkenti: " + capital + " Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;
            //Console.Write("Ülke adını giriniz: ");
            //x = Console.ReadLine();
            //Console.Write("Başkent adını giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("Bayrak renklerini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            #endregion
            #region Geriye Değer Döndüren Integer Parametreli Metotlar 

            //int Sum(int number1, int number2)
            //{
            //    int result = number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(36, 25));
            //Console.WriteLine(Sum(44, 36));
            //Console.WriteLine(Sum(14, 20));

            #endregion
            #region Örnek

            //    string ExamResult(string student, int exam1, int exam2, int exam3)
            //    {
            //        int result = (exam1 + exam2 + exam3) / 3;
            //        if (result >= 50)
            //        {
            //            return student+ "isimli öğrenci öğrenci sınavı geçti "+ "Ortalama: "+result;
            //        }
            //        else
            //        {
            //            return student + " isimli öğrenci öğrenci sınavı geçemedi " + "Ortalama: " + result;
            //        }
            //    }

            //    string n;
            //    int e1, e2, e3;
            //    Console.Write("Öğrenci adını giriniz: ");
            //    n = Console.ReadLine();
            //    Console.Write("İlk sınav notunu giriniz: ");
            //    e1 = int.Parse(Console.ReadLine());
            //    Console.Write("İkinci sınav notunu giriniz: ");
            //    e2 = int.Parse(Console.ReadLine());
            //    Console.Write("Öğrenci adını giriniz: ");
            //    e3 = int.Parse(Console.ReadLine());

            //    Console.WriteLine(ExamResult(n, e1, e2, e3));
            //    Console.Read();
            //}
            #endregion

        }
    }
}  
    