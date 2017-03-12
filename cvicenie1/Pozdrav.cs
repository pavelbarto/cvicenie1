using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvicenie1
{
    class Pozdrav
    {
        public void Oslovenie()
        {
            Console.WriteLine("Ahoj ako sa voláš ? ");
            Console.Write("Zadaj svoje meno: ");
            string meno = Console.ReadLine();
            Console.Write("Aký si ? ");
            string vlastnost = Console.ReadLine();
            Console.WriteLine(meno + " je " + vlastnost);
            Console.ReadLine();
        }
    }
}
