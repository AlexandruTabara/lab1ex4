using System;

namespace lab1ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex 4
                Scrieti un program care va afisa semnul unui numar citit de la tastatura
                • Daca numarul este pozitiv, va afisa “+”
                • Daca numarul este negativ, va afisa “-”
                • Daca numarul este 0, va afisa “0” */

            Console.WriteLine("Intoduceti un numar: ");
            int numarSpecial = int.Parse(Console.ReadLine());

            if (numarSpecial > 0)
            {
                Console.WriteLine("+");
            }
            else if (numarSpecial < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("0");
            }



            
        }
    }
}
