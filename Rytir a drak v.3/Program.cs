using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rytir_a_drak_v._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rytir[] poleRytiru =
            {
                new Rytir("Isis", 9, 3),
                new Rytir("Ilis", 5, 5),
                new Rytir("Ibis", 4, 2),

            };
             
            Drak[] poleDraku = 
            {
                new Drak("Arak",5,3),
                new Drak("Ates",8,2),
                new Drak("Anor",5,5),
                
            };

            Random generatorNahodnychCisel = new Random();
            int nahodneCislo = generatorNahodnychCisel.Next(poleDraku.Length);
            Drak vybranyDrak = poleDraku[nahodneCislo];
            Rytir vybranyRytir = poleRytiru[nahodneCislo];

            while(vybranyDrak.PocetHlav!=0 || vybranyRytir.PocetZivotu!=0)
            {
                nahodneCislo = generatorNahodnychCisel.Next(poleDraku.Length);
                vybranyDrak = poleDraku[nahodneCislo];

                vybranyRytir = poleRytiru[nahodneCislo];
                if(vybranyDrak.PocetHlav == 0)
                {
                    vybranyDrak = poleDraku[nahodneCislo];
                }
                if(vybranyRytir.PocetZivotu==0)
                {
                    vybranyRytir = poleRytiru[nahodneCislo];
                }
                Console.WriteLine("Útočí Drak " + vybranyDrak.Jmeno + " na rytíře " + vybranyRytir.Jmeno);
                vybranyDrak.Utoc(vybranyRytir);
                Console.WriteLine("Útočí Ryríř " + vybranyRytir.Jmeno + " na draka " + vybranyDrak.Jmeno);
                vybranyRytir.Utoc(vybranyDrak);
                Console.WriteLine();

                for (int i = 0; i < poleDraku.Length; i++)
                {
                   if( poleDraku[i].PocetHlav == 0)
                    {
                        Console.WriteLine("Zvítězili rytíři.");
                        Console.ReadLine();
                        return;
                    }
                }

                for (int i = 0; i < poleRytiru.Length; i++)
                {
                    if(poleRytiru[i].PocetZivotu == 0)
                    {
                        Console.WriteLine("Zvítězili draci.");
                        Console.ReadLine();
                        return;
                    }
                }
            }
            

            Console.ReadLine();
        }
    }
}
