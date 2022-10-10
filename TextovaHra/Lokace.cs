using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextovaHra
{
    public class Lokace
    {
        Hra hra = new Hra();
        //public int[,] herniProstredi = new int[5, 5]
        //{
        //    {0, 0, 0, 0, 0},
        //    {0, 0, 0, 0, 0},
        //    {1, 2, 2, 2, 3},
        //    {0, 0, 2, 4, 0},
        //    {0, 0, 0, 0, 0},
        //};

        public int[,] herniProstredi = new int[5, 5]
        {
            {0, 0, 1, 0, 0},
            {0, 0, 2, 0, 0},
            {0, 5, 2, 2, 0},
            {0, 0, 2, 4, 0},
            {0, 0, 3, 0, 0},
        };
        public int AktualniPoloha(int x, int y)
        {
            Bod bod = new Bod(x, y);
            return herniProstredi[x, y];
        }
        public object NazevObjektu(int i)
        {
            HerniObjekt herniObjekt = (HerniObjekt)i;

            return herniObjekt;
        }
        public enum HerniObjekt
        {
            Nic = 0,
            Hrad = 1,
            Les = 2,
            Plaz = 3,
            Dum = 4,
            Prisera = 5
        };
        public void ReakceNaObjekt(int i)
        {
            HerniObjekt herniObjekt = (HerniObjekt)i;
            switch (herniObjekt)
            {
                case (HerniObjekt)1:
                    {
                        Console.WriteLine("\nStojíš před okovanou branou gotického hradu, která je zřejmě jediným vchodem do pevnosti. Klíčová dírka je pokryta pavučinami, což vzbuzuje dojem, že je budova opuštěná.\n");
                        break;
                    }
                case (HerniObjekt)2:
                    {
                        Console.WriteLine("\nJsi na lesní cestě, která se klikatí až za obzor, kde mizí v siluetě zapadajícího slunce. Ticho podvečerního lesa občas přeruší zpěv posledních ptáků.\n");
                        break;
                    }
                case (HerniObjekt)3:
                    {
                        Console.WriteLine("\nHladina je v bezvětří jako zrcadlo. Kousek od tebe je dřevěná plošina se stavidlem.\n");
                        break;
                    }
                case (HerniObjekt)4:
                    {
                        Console.WriteLine("\nStojíš před svým rodným domem, cítíš vůni čerstvě nasekaného dřeva, která se line z hromady vedle vstupních dveří.\n");
                        break;
                    }
                case (HerniObjekt)5:
                    {
                        Console.WriteLine("\nNarazil si na hrůzostrašnou příšeru! Bohužel byla moc rychlá na to, abys ji dokázal utéct a zabila tě. Tímto pro tebe hra končí.\n");
                        break;
                    }
            }
        }
    }
}
