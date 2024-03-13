using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libak
{
    class Program
    {
        static void Kiir(int[] t, string cim)
        {
            Console.WriteLine(cim);
            foreach (int szam in t)
            {
                Console.Write($"{szam}");
            }
        }
        static void Kiir_eredmenyek(int hany_kilo, double roka_atlag, string volt_harom)
        {
            Console.WriteLine($"\nA róka libáinak súlya: {hany_kilo}");
            Console.WriteLine($"A róka libáinak súlyának átlaga: {roka_atlag}");
            Console.WriteLine($"{volt_harom}a róka legalább háromkilós libát lopott");
        }

        static int Osszegez(int[] t)
        {
            int osszeg = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] <= 3)
                {
                    osszeg += t[i];
                }
            }
            return osszeg;

        }
        static double Atlag(int[] t)
        {
            int osszeg = 0;
            int db = 0;

            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] <= 3)
                {
                    db++;
                    osszeg += t[i];
                }
            }
            double atlag = (double)osszeg / db;
            return atlag;
        }
        static int Megszamolas(int[] t)
        {
            int db = 0;
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i] <= 3)
                {
                    db++;
                }
            }
            return db;
        }
        static bool Eldontes(int[] t)
        {
            bool van = false;
            int i = 0;
            while (i < t.Length && !(t[i] >= 3))
            {
                if (i < t.Length)
                {
                    van = true;
                }
            }
            return van;
        }
        static void Main(string[] args)
        {
            /*
                         * LIBÁK

            A róka libát lop a faluból. A libák súlyát – pontosabban tömegét – listában adjuk meg. A farkas a dűlőútnál várja a rókát, és a három kilónál nagyobb libákat elveszi – a piciket nagylel�kűen otthagyja a rókának.
            libak = [1,5,2,3,4]

            a. Hány kiló libát ehet meg a róka?
            b. Átlagosan hány kilósak a rókának maradt libák?
            c1. Előfordult-e olyan, hogy a róka legalább háromkilós libát lopott?
            c2. Előfordult-e olyan, hogy a róka kisebb libát hozott, mint az előző napon?
            d. Hányadik napon sikerült a rókának először legalább háromkilós libát lopnia?
            e. Melyik a róka első legalább háromkilós libája?
            f. Hány libát tarthat meg a róka?
            g. Mekkora a legkisebb liba, amit a farkas elvesz a rókától?

             * */
            //1.Input
            int[] libak = { 1, 5, 2, 3, 4 };
            //2.Calc
            //a. Hány kiló libát ehet meg a róka?
            int osszes_kilo_liba = Osszegez(libak);
            double rokanal_maradt_libak_atlaga = Atlag(libak);

            // b. Átlagosan hány kilósak a rókának maradt libák?
            int hany_db_libat_ehet_meg_a_roka = Megszamolas(libak);

            //c1. Előfordult-e olyan, hogy a róka legalább háromkilós libát lopott?
            bool volt_legalabb_harom_kilos_liba = Eldontes(libak);
            string volt_legalabb_harom_kilos_liba_szoveg = "Nem fordult elő";
            if (volt_legalabb_harom_kilos_liba)
            {
                string volt_legalabb_harom_kilos_liba_szoveg = "Elő fordult";
            }
            //3.Output
            Kiir(libak, "a libák súlyai");
            Kiir_eredmenyek(osszes_kilo_liba, rokanal_maradt_libak_atlaga,volt_legalabb_harom_kilos_liba_szoveg);
            Console.WriteLine("Nyomjad");
            Console.ReadKey();
        }
    }
}