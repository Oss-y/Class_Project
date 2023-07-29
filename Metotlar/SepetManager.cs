using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        //naming convention
        //syntax
        public void Add(Product product) 
        {
            Console.WriteLine("Sepete eklendi : " + product.Adi);
        }
        public void Add2(string productAdi,string aciklama, 
            double fiyat, int stokAdedi) 
        {
            Console.WriteLine("Sepete eklendi : " + productAdi);
            Console.WriteLine("Kalan Adet :" + stokAdedi);
        }
    }
}
