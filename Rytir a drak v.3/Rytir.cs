using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rytir_a_drak_v._3
{
    public class Rytir
    {
        public string Jmeno;
        public int PocetZivotu;
        public int Sila;

        Random generatorNahodnychCisel = new Random();

        public Rytir(string jmeno)
        {
            this.Jmeno = jmeno;
            this.PocetZivotu = 10;
            Sila = 3;
        }

        public Rytir(string jmeno, int pocetZivotu)
        {
            this.Jmeno = jmeno;
            this.PocetZivotu = pocetZivotu;
            Sila = 3;
        }

        public Rytir(string jmeno, int pocetZivotu, int sila)
        {
            this.Jmeno = jmeno;
            this.PocetZivotu = pocetZivotu;
            this.Sila = sila;
        }

        public bool MuzuBojovat()
        {
            return PocetZivotu > 0;
        }

        public void Utoc(Drak drakNaUtok)
        {
            int nahodneCislo = generatorNahodnychCisel.Next(Sila);
            int zbydeHlav = drakNaUtok.PocetHlav - nahodneCislo;
            if (nahodneCislo == 0)
            {
                Console.WriteLine("Rytíř si dává pauzu.");
            }
            if (zbydeHlav > 0)
            {
                if (zbydeHlav > 4)
                {
                    Console.WriteLine("Drakovi zbylo {0} hlav.", zbydeHlav);
                }
                else if (zbydeHlav < 5 && zbydeHlav > 1)
                {
                    Console.WriteLine("Drakovi zbyly {0} hlavy.", zbydeHlav);
                }
                else if (zbydeHlav == 1)
                {
                    Console.WriteLine("Drakovi zbyla {0} hlava.", zbydeHlav);
                }



            }
            else if (zbydeHlav <= 0 && PocetZivotu > 0)
            {
                zbydeHlav = 0;
                Console.WriteLine("Rytíř porazil draka.");
            }

            drakNaUtok.PocetHlav = zbydeHlav;

        }
    }
}
