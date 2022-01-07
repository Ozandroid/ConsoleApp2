using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Metotlar bizim için tekrar tekrar kullanıbilirliği sağlayan kod bloklarıdır.
            // iskelet kod >
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakır karpuzu";

            //Urun array oluşturma kodu!
            Product[] products = new Product[] {product1,product2};

            foreach (Product product in products)
            {
                
                
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("------------");

            }

            Console.WriteLine("-------Metotlar------");
            //intance - class örneği oluşturmak
            //encapsulation - kapsülleme
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2()

        }
    }
}
