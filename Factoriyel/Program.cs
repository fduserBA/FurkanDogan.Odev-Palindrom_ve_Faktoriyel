using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factoriali alınacak sayıyı giriniz.");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            if (sayi != 0)
            {
                for (int i = 1; i <= sayi; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine(factorial);
            }
            else
            {
                Console.WriteLine(1);
            }

            Console.ReadKey();
        }
    }
}
