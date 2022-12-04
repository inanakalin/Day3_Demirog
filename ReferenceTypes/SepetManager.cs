using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {       
        //naming convention -- Metotlar classlar büyük harfle başlar
        // syntax -- yazım şekilleri
        public void Add (Product product)
        {
            Console.WriteLine("Sepete eklendi : " + product.Name );
        }

        public void Add2 (string name, string info, int price, int instock)
        {
            Console.WriteLine("Sepete eklendi : " + name);
        }
    }
}
