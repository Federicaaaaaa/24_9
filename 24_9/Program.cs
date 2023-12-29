using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = Vector.Parse("2, 2");
            Vector v2 = Vector.Parse("3, 3");
            Vector v3 = Vector.Parse("4, 4");

            Vector vS = v1.Somma(v2);
            Console.WriteLine("{0}; {1}", v1.vx, v1.vy);
            Console.WriteLine("{0}; {1}", v2.vx, v2.vy);
            Console.WriteLine("{0}; {1}", vS.vx, vS.vy);

            Console.ReadLine();
        }
    }
}
