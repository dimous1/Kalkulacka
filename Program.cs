using System;

namespace Kalkulacka2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Vyber si cislo 1: " );
            int cislo = int.Parse(Console.ReadLine());

            Console.WriteLine("Vyber si hodnotu: ");
            string operace = Console.ReadLine();

            Console.WriteLine("Vyber si cislo 2: ");
            int cislo2 = int.Parse(Console.ReadLine());


            double vysledek = 0;


            if (operace == "+") 
            {
                vysledek = cislo + cislo2;
            }

            else if (operace == "-")
            {
                vysledek = cislo - cislo2;
            }

            else if (operace == ":")
            {
                vysledek = cislo / cislo2;

            }

            else if (operace == "*")
            {
                vysledek = cislo * cislo2;
            }


            else
            {
                Console.WriteLine("Spatna hodnota. Zkus +, -, :, *");
            }

            Console.WriteLine("vysledek je: " + vysledek);
            double odmocnina = Math.Sqrt(vysledek);
            double zaokrouhleni = Math.Round(odmocnina, 3);
           
            Console.WriteLine("odmocnina z vysledku: " + zaokrouhleni);

            Console.ReadKey();

            

        }
    }
}
