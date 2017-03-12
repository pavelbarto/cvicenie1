using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvicenie1
{
    class DruhaMocnica
    {
        public void Mocnina()
        {
            Console.WriteLine("Zadaj číslo: ");
            string s = Console.ReadLine();
            int a = int.Parse(s);
            a = a * a;
            Console.WriteLine("Výsledok :" + a);
            Console.ReadKey();
        }
    }
}
