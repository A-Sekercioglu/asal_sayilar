using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asal_sayılar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 100 ; i++) //burada i değeri 0 sayısına eşittir ve i 100 den küçükse i sayısına 1 ekle
            { 
             if((i % 2 == 0 && i>2) || (i % 3 == 0 && i > 3) || (i % 5 == 0 && i > 5) || (i % 7 == 0 && i > 7))//eğer i sayısı 2, 3, 5, 7 sayılarına tam bölünebilik o sayılardan büyükse i sayısını ekrana yaz
                {
                    Console.WriteLine(i);
                }
                else//eğer i sayısı 2, 3, 5, 7 sayılarına tam bölünebilik o sayılardan büyük değil ise hiçbirşey yapma 
                { }
            }
            Console.ReadKey();//klavyeden harf girilmesini bekle



        }
    }
}
