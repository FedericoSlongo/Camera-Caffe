using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camera_Café
{
    class Macchina
    {
        public double serbatorio = 1000;
        public int ncaffe = 0;
        public void StatoMacchina()
        {
            Console.WriteLine($"Sono stati fatti {ncaffe}\nRimane {serbatorio}ml di acqua");
        }
        public void riempi()
        {
            serbatorio = 1000;
            ncaffe = 0;
        }
        public void prep(bool taz_giga_enorme)
        {
            if (serbatorio < 80)
                if (serbatorio < 50)
                {
                    Console.WriteLine("No water?");
                    return;
                }
            if (taz_giga_enorme)
                serbatorio -= 80;
            else
                serbatorio -= 50;
            ncaffe++;
            Console.WriteLine("Ho fatto un caffè");
        }
    }
}
