using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rytir_a_drak_v._3
{
    public class Drak
    {
        public string Jmeno;
        public int PocetHlav;
        public int Sila;

        Random generatorNahodnychCisel = new Random();

        public Drak(string jmeno)
        {
            this.Jmeno = jmeno;
            PocetHlav = 10;
            Sila = 3;
        }

        public Drak(string jmeno, int pocetHlav)
        {
            this.Jmeno = jmeno;
            this.PocetHlav = pocetHlav;
            Sila = 3;
        }

        public Drak(string jmeno, int pocetHlav, int sila)
        {
            this.Jmeno = jmeno;
            this.PocetHlav = pocetHlav;
            this.Sila = sila;
        }

        public bool MuzuBojovat()
        {
            return PocetHlav > 0;

        }

        public void Utoc(Rytir rytirNaUtok)
        {
            int nahodneCislo = generatorNahodnychCisel.Next(Sila);
            int zbyloZivotu = rytirNaUtok.PocetZivotu - nahodneCislo;
            if (nahodneCislo == 0)
            {
                Console.WriteLine("Drak si dává pauzu.");
            }
            if (zbyloZivotu > 0)
            {
                if (zbyloZivotu >= 5)
                {
                    Console.WriteLine("Rytíři zbylo {0} životů.", zbyloZivotu);
                }
                else if (zbyloZivotu <= 4 && zbyloZivotu > 1)
                {
                    Console.WriteLine("Rytíři zbyly {0} životy.", zbyloZivotu);
                }
                else if (zbyloZivotu == 1)
                {
                    Console.WriteLine("Rytíři zbyl {0} život.", zbyloZivotu);
                }


            }
            else if (zbyloZivotu <= 0 && PocetHlav > 0)
            {
                zbyloZivotu = 0;
                Console.WriteLine("Drak porazil rytíře.");


            }
            rytirNaUtok.PocetZivotu = zbyloZivotu;
        }
    }
}
