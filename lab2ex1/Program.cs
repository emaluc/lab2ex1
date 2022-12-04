using System;

namespace lab2ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti un program care va afisa suma cifrelor unui numar n, n fiind
             citit de la tastatura.*/

            Console.WriteLine("Scrieti un numar:");

            int x = int.Parse(Console.ReadLine());
            int y;
            int z = 0;

            while (x > 0)
            {
                y = x % 10;
                z = z + y;
                x = x / 10;
            }
            Console.WriteLine("Suma cifrelor este: " + z);
            
        }
    }
}
