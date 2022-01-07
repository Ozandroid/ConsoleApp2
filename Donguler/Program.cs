using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //Array - Diziler

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", 
                "Programlamaya başlangıç için temel kurs",
                "Java", "Python", "c#" };

           

            // Dinamik kod for döngüsü!
            //Birbirine benzeyen işlemleri tekrar etmek için kullanırız.
            //Yaşam döngüsü diyebiliriz.
           // Length ( Eleman sayısı demek ) Yani bu kod var olan tüm elemanları gösterir.
            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);

                Console.WriteLine("for bitti");

                //foreach dizilere uygulanır.
                foreach (string kurs in kurslar)
                {
                    Console.WriteLine(kurs);
                }
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}