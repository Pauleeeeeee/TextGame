using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TextovaHra
{
    public class Hra
    {
        public bool pokracovat = true;
        public void ZapniHru()
        {
            Lokace lokace = new Lokace();
            Bod bod = new Bod(3, 3);

            while (pokracovat)
            {
                Console.Clear();

                Console.WriteLine("Tvoje aktuální lokace je: {0}", lokace.NazevObjektu(lokace.AktualniPoloha(bod.X, bod.Y))); // Vypsání aktuální lokace
                lokace.ReakceNaObjekt(lokace.AktualniPoloha(bod.X, bod.Y)); // Provedení úkonů dle dané aktuální lokace

                Console.WriteLine("Kam se chceš vydat?");

                int doleva = 0;
                int doprava = 0;
                int nahoru = 0;
                int dolu = 0;

                try
                {
                    doleva = lokace.herniProstredi[bod.X - 1, bod.Y];
                }
                catch (IndexOutOfRan­geException ex)
                {
                    doleva = 0;
                }
                try
                {
                    doprava = lokace.herniProstredi[bod.X + 1, bod.Y];

                }
                catch (IndexOutOfRan­geException ex)
                {
                    doprava = 0;
                }
                try
                {
                    nahoru = lokace.herniProstredi[bod.X, bod.Y - 1];
                }
                catch (IndexOutOfRan­geException ex)
                {
                    nahoru = 0;
                }
                try
                {
                    dolu = lokace.herniProstredi[bod.X, bod.Y + 1];
                }
                catch (IndexOutOfRan­geException ex)
                {
                    dolu = 0;
                }

                string mozneSmery = "";

                if (doleva != 0)
                    mozneSmery += " západ";
                if (doprava != 0)
                    mozneSmery += " východ";
                if (nahoru != 0)
                    mozneSmery += " sever";
                if (dolu != 0)
                    mozneSmery += " jih";
                Console.WriteLine("Lze jít těmito směry:" + mozneSmery);

                string prikaz = Console.ReadLine().ToLower(); // Příkaz kudy se chystá hráč jít

                switch (prikaz)
                {
                    case "sever":
                        {
                            if (nahoru != 0)
                            {
                                bod.ZmenaSouradnic(bod.X, bod.Y - 1);
                            }
                            else
                            {
                                Console.WriteLine("Tímto směrem nelze jít!");
                            }
                            break;
                        }
                    case "jih":
                        {
                            if (dolu != 0)
                            {
                                bod.ZmenaSouradnic(bod.X, bod.Y + 1);
                            }
                            else
                            {
                                Console.WriteLine("Tímto směrem nelze jít!");
                            }
                            break;
                        }
                    case "západ":
                        {
                            if (doleva != 0)
                            {
                                bod.ZmenaSouradnic(bod.X - 1, bod.Y);
                            }
                            else
                            {
                                Console.WriteLine("Tímto směrem nelze jít!");
                            }
                            break;
                        }
                    case "východ":
                        {
                            if (doprava != 0)
                            {
                                bod.ZmenaSouradnic(bod.X + 1, bod.Y);
                            }
                            else
                            {
                                Console.WriteLine("Tímto směrem nelze jít!");
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Neplatný příkaz!");
                            break;
                        }
                }
            }
        }
        //public void UkonciHru()
        //{
        //    pokracovat = false;
        //    Console.WriteLine("Hra pro tebe končí, díky!");
        //}
    }
}
