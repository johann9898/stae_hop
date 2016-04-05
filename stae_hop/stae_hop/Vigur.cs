using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stae_hop
{
    class Vigur
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vigur(double efriTala, double nedriTala)
        {
            X = efriTala;
            Y = nedriTala;
        }
        public double Lengd()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
        public Vigur Þvervigur()
        {
            Vigur temp = new Vigur(-Y, X);
            return temp;
        }
        public Vigur BlandadMargfeldi(int tala)
        {
            return new Vigur(X * tala, Y * tala);
        }
        public double Hallatala()
        {
            return Y / X;
        }
        public Vigur Einingarvigur()
        {
            double efriTala = 0, nedriTala = 0;
            efriTala = 1 / Lengd() * X;
            nedriTala = 1 / Lengd() * Y;
            return new Vigur(efriTala, nedriTala);
        }
        public override string ToString()
        {
            return "x: " + X + ", y: " + Y;
        }
    }
}
