using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stae_hop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tala1 = 0;
            double tala2 = 0;
            double tala3 = 0;
            double tala4 = 0;

            double answer = 0;
            int val = 0;
            

            do
            {
                Console.Clear();
                Console.WriteLine("1. Einn StefnuHorn");
                Console.WriteLine("2. Tveir StefnuHorn");
                Console.Write("Veldu: ");
                val = Convert.ToInt32(Console.ReadLine());
               

                switch (val)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("Veldu Tölu við X-ás: ");
                        tala1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Veldu Tölu við Y-ás: ");
                        tala2 = Convert.ToDouble(Console.ReadLine());

                        answer = Math.Atan(tala1 / tala2) * 180 / Math.PI; //Ekki rétt aðferð

                        Console.WriteLine("Stefnuhorn Vígurinn er " + answer);
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Veldu Tölu við X-ás: ");
                        tala1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Veldu Tölu við Y-ás: ");
                        tala2 = Convert.ToDouble(Console.ReadLine());
                        answer = Math.Atan(tala1 / tala2) * 180 / Math.PI;
                        Console.WriteLine("Stefnuhorn Vígurinn er " + answer);
                        Console.ReadKey();
                        break;
                }

            } while (val != 3);

            Console.ReadKey();

        }
    }
}
