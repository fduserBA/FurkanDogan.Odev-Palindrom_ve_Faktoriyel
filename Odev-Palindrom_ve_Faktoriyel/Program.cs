using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_Palindrom_ve_Faktoriyel
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime;
            string devamKontrol;
            do
            {
                Console.WriteLine("Kelimeyi giriniz.");
                kelime = Console.ReadLine();
                while (kelime.Length == 1 || kelime.Length == 2)
                {
                    Console.WriteLine("Lütfen kelimeyi giriniz!");
                    kelime = Console.ReadLine();
                }
                if (kelime.Equals(PalindromKontrol(kelime)))
                {
                    Console.WriteLine("Girdiğiniz kelime palindromdur.");
                }
                else
                {
                    Console.WriteLine("Girdiğiniz kelime palindrom değildir.");
                }
                Console.WriteLine("Tekrar palindrom sorgulaması yapmak istermisin? evet:e hayı:h");
                devamKontrol = Console.ReadLine();
                while (!(devamKontrol == "e" || devamKontrol == "h"))
                {
                    Console.WriteLine("Tekrar palindrom sorgulaması yapmak istermisin? evet:e hayı:h");
                    devamKontrol = Console.ReadLine();
                }


            } while (devamKontrol == "e");


            Console.ReadKey();
        }
        static string PalindromKontrol(string kelime)
        {
            string palindrom = "";
            for (int i = kelime.Length - 1; i >= 0; i--)
            {
                palindrom += kelime[i];
            }
            return palindrom;
        }
    }
}
