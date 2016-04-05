using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stae_hop
{
    class MargirVigrar
    {
        private List<Vigur> VigraListi { get; set; }
        public MargirVigrar(List<Vigur> vigrarnir)
        {
            VigraListi = vigrarnir;
        }

        public Vigur Summa()
        {
            double x = 0, y = 0;

            foreach (Vigur v in VigraListi)
            {
                x += v.X;
                y += v.Y;
            }

            return new Vigur(x, y);
        }
    }
}
