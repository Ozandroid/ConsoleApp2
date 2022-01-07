using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        //naming covention
        public void Ekle(Product product)
        {
            Console.WriteLine("Sepete Eklendi : " + product.Adi + product.Fiyati);
        }

        public void Ekle2()
        {

        }

    }
}
