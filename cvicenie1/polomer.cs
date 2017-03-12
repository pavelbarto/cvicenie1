using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvicenie1
{
    class Polomer
    {
        public void Obsah ()
        {
            Console.WriteLine("Zadaj polomer kruhu (cm): ");
            string s = Console.ReadLine();
            float a = float.Parse(s);
            float obvod = 2 * Convert.ToSingle(Math.PI) * a;
            float obsah = Convert.ToSingle(Math.PI) * a * a;
            Console.Write­Line("Obvod kruhu je: " + obvod + " cm");
            Console.Write­Line("Obsah kruhu je: " + obsah + " cm2");
            Console.ReadKey();

        }
    }
}
