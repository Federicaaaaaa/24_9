using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_9
{
    internal class Vector
    {
        public Vector()
        {
            vx = new int();
            vy = new int();
        }

        public int vx { get; set; }
        public int vy { get; set; }

        public Vector Somma(Vector v)
        {
            Vector vR = new Vector();
            vR.vx = vx + v.vx;
            vR.vy = vy + v.vy;
            return vR;
        }

        public static Vector Parse(int vx, int vy)
        {
            Vector v = new Vector();
            v.vx = vx;
            v.vy = vy;
            return v;
        }
    }
}
