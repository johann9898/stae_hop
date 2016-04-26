using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stae_hop
{
    class Aðferðir
    {
        public Vigur SummaVigra(List<Vigur> VigraListi)
        {
            double x = 0, y = 0;

            foreach (Vigur v in VigraListi)
            {
                x += v.X;
                y += v.Y;
            }

            return new Vigur(x, y);
        }
        public double Innfeldi(Vigur a, Vigur b)
        {
            return a.X * b.X + a.Y * b.Y;
        }
        public double Stefnuhorn(Vigur v)
        {
            double stefnuhorn = 0;
            if (v.X >= 0 && v.Y >=0)
            {
                stefnuhorn = ToDeg(Math.Atan(v.Y / v.X));
            }
            else if (v.X < 0 && v.Y >=0)
            {
                stefnuhorn = 180 - Math.Abs(ToDeg(Math.Atan(v.Y / v.X)));
            }
            else if (v.X < 0 && v.Y < 0)
            {
                stefnuhorn = 180 + Math.Abs(ToDeg(Math.Atan(v.Y / v.X)));
            }
            else
            {
                stefnuhorn = 360 - Math.Abs(ToDeg(Math.Atan(v.Y / v.X)));
            }
            return stefnuhorn;
        }
        public double ToRad(double degrees)
        {
            return degrees / 180 * Math.PI;

        }
        public double ToDeg(double radians)
        {
            return radians * 180 / Math.PI;

        }

    }
}
