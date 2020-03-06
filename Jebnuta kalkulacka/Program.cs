using System;

namespace Kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {   bool sprMoznost = true, pokracuj = true;
            int moznost = 0;
            float vysledek = 0;

            while (pokracuj)
            {
                    
                Console.WriteLine("Obycejna kalkulacka, kde pouzivame switch");
                Console.WriteLine("Prvni cislo: ");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("Druhe cislo: ");
                float b = float.Parse(Console.ReadLine());
                if (b == 0)
                {
                    Console.WriteLine("Nemuzes delit nulou, proto nevol tuto moznost!");
                }
                while (sprMoznost)
                {
                    sprMoznost = false;              
                
                    Console.WriteLine("Zvol moznost operace, kterou chces provest: ");
                    Console.WriteLine("1 - Secti");
                    Console.WriteLine("2 - Odecti");
                    Console.WriteLine("3 - Vynasob");
                    Console.WriteLine("4 - Vydel");
                    Console.WriteLine("5 - Ukoncit?");
                    moznost = int.Parse(Console.ReadLine());
                    vysledek = 0;
                    switch (moznost)
                    {
                        case 1:
                            vysledek = a + b;
                        break;

                        case 2:
                            vysledek = a - b;
                        break;

                        case 3:
                            vysledek = a * b;
                        break;

                        case 4:
                            vysledek = a / b;
                        break;

                        case 5:
                            Environment.Exit(0);
                        break;

                        default:
                            sprMoznost = true;
                        break;         
                    }
                }
                if ((b == 0) && (moznost == 4))
                    Console.WriteLine("Tak hele debilku, nulou se proste delit neda, chapes to???");
                else
                    Console.WriteLine("Vysledek je: " + vysledek);
                    Console.ReadKey();
            }         
             
        }   

    }
}
