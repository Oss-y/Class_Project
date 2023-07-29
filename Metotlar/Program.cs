using Metotlar;
using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args) 
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya elması";
            product1.StokAdedi = 675;

            Product product2 = new Product();
            product2.Adi = "Uzum";
            product2.Fiyati = 10;
            product2.Aciklama = "Siyah uzum";
            product2.StokAdedi = 435;

            Product product3 = new Product();
            product3.Adi = "Karpuz";
            product3.Fiyati = 80;
            product3.Aciklama = "Diyarbakir karpuzu";
            product3.StokAdedi = 453;

            Product[] products = { product1, product2, product3 };

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("Stok Adedi :" + product.StokAdedi);
                Console.WriteLine("_______________________");
            }
            Console.WriteLine("-------Metotlar--------");

            //instance - class örneği oluşturmak
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);
            sepetManager.Add(product3);

            sepetManager.Add2("armut", "yeşil armut", 12, 87);
            sepetManager.Add2("elma", "yeşil elma", 12, 876);
            

            Console.ReadKey();

        }
    }
}

