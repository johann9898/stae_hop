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
           
            Aðferðir adferd = new Aðferðir();
            double tala1 = 0;
            double tala2 = 0;
            double tala3 = 0;
            double tala4 = 0;
            double positive1 = 0;
            double positive2 = 0;
            double answer = 0;
            double answer2 = 0;
            double answer3 = 0;
            
            
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


                        Vigur v2 = new Vigur(tala1, tala2);
                        Console.WriteLine();

                        Console.WriteLine("Stefnuhorn Vígurinn er " + adferd.Stefnuhorn(v2));
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Veldu Tölu við X-ás Fyrstu Stefnuhorn: ");
                        tala1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Veldu Tölu við Y-ás Fyrstu Stefnuhorn: ");
                        tala2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Veldu Tölu við X-ás Annari Stefnuhorn: ");
                        tala3 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("Veldu Tölu við Y-ás Annari Stefnuhorn: ");
                        tala4 = Convert.ToDouble(Console.ReadLine());
                        positive1 = Math.Atan(tala2 / tala1) * 180 / Math.PI;
                        positive2 = Math.Atan(tala4 / tala3) * 180 / Math.PI;

                        answer = Math.Abs(positive1);
                        answer2 = Math.Abs(positive2);

                        answer3 = answer + answer2;

                       

                        if(positive1 < positive2)
                        {
                            answer3 = answer3 * -1;
                        }
                        if (positive1 > positive2)
                        {
                            answer3 = answer3 * 1;
                        }
                        Console.WriteLine();
                        Console.WriteLine("Stefnuhorn Vígurinn er " + answer3);
                        Console.ReadKey();
                        break;
                    case 3:
                        int teljari = 1;
                        double x = 0;
                        double y = 0;
                        List<Vigur> vigraListi = new List<Vigur>();
                        while (true)
                        {
                            Console.WriteLine("Vigur "+ teljari);
                            Console.Write("Efri tala: ");
                            x = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Neðri tala: ");
                            y = Convert.ToDouble(Console.ReadLine());
                            vigraListi.Add(new Vigur(x, y));
                            Console.WriteLine("\nHalda áfram? j/n");
                            string s;
                            if (((s = Console.ReadLine()) != String.Empty) && s[0] == 'n')
                            {
                                break;
                            }
                            teljari++;
                        }
                        foreach (Vigur v in vigraListi)
                        {
                            Console.WriteLine("\nVigurinn " + v);
                            Console.WriteLine("Lengd vigurs: " + v.Lengd());
                            Console.WriteLine("Hallatala vigurs: " + v.Hallatala());
                            Console.WriteLine("Þvervigur: " + v.Þvervigur());
                        }

                        break;

                    case 4:
                        Aðferðir adferdir = new Aðferðir();
                        Vigur v1 = new Vigur(5,8);
                        Console.WriteLine(adferdir.Stefnuhorn(v1));

                        Vigur v3 = new Vigur(3,9);
                        Console.WriteLine(adferdir.Stefnuhorn(v3));

                        Console.WriteLine(adferdir.ToDeg(adferdir.Stefnuhorn(v3) - adferdir.Stefnuhorn(v1)));
                        Console.ReadKey();
                        break;
                }

            } while (true);

            Console.ReadKey();

        }
    }
}
