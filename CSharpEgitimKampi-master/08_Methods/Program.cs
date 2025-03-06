using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar
            //()
            //2 adet methot vardır  
            // Geriye değer döndürmeyen metotlar
            //customer--z Listele ekle sil güncelle...
            //void olarak tanımlanır

            //void  CustomerList()
            //{
            //    Console.WriteLine("Ali yıldız");
            //    Console.WriteLine("Yılmaz yıldı");
            //    Console.WriteLine("Mehmet Kazdı");
            //    Console.WriteLine("Çınar  Çimen");

            //}

            //CustomerList();



            #endregion

            #region Geriye Değer Döndürmeyen  stringparametreli metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Mehmet "); ****


            //void CustomerCard(string name,string surName)
            //{
            //    Console.WriteLine("Müşteri: "+name+" "+surName);
            //}
            //CustomerCard("Ahmet", "Yıldız");
            //CustomerCard("Selim", "Yavuz");


            #endregion

            #region Geriye değer döndürmeyen int parametreli metotlar
            //void sum(int number1, int number2, int number3)
            //{
            //    int result =number1+ number2+number3;
            //    Console.WriteLine(result);
            //}
            //sum(4, 5, 6);


            #endregion

            #region ** Geriye Değer Döndüren Metotlar ** 

            //string CustomerName() { return "Buse Jankart"; }


            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Kaya";

            //    return name+" "+ surName;

            //}

            //Console.WriteLine(StudentCard());
            #endregion



            #region ** Geriye Değer Döndüren String Paremetreli Metotlar ** 
            //string CountryCard(string CountryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke " + CountryName + " Başkent:" + capital + "- Bayrak Rengi " + flagColor;

            //    return cardInfo;
            //}


            //string x, y, z;
            //Console.WriteLine("Ülke Adını Giriniz:");
            //x=Console.ReadLine();

            //Console.WriteLine("Başkenti Giriniz:");
            //y=Console.ReadLine();

            //Console.WriteLine("Bayrak Rengini Giriniz:");
            //z=Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı-Beyaz"));
            #endregion


            #region ** Geriye Değer Döndüren İnt Paremetreli Metotlar **

            int Sum (int number1, int number2)
            {
                int result = number1 + number2;
                return result;
            }

            Console.WriteLine(Sum(11, 98));
            Console.WriteLine(Sum(22, 33));
            Console.WriteLine(Sum(33, 44));
            Console.WriteLine(Sum(12, 32));
            Console.WriteLine(Sum(23, 98534));


            #endregion
            Console.ReadLine();
        }
    }
}
