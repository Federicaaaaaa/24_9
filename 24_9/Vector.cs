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

        public static Vector Parse(string s)
        {
            string[] subs = s.Split(',', ' ');

            
            Vector v = new Vector();
            v.vx = int.Parse(subs[0]);
            v.vy = int.Parse(subs[2]);
            return v;
        }
    }
}
