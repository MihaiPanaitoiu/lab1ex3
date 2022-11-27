using System;

namespace lab1ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Ex3
             Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
             tastaura
              (google: how to get the last digit of a number
             */

            //Rezolvare 1


            Console.WriteLine("Acest program va afisa ultima cifra a numarului introdus");

            Console.WriteLine("Introduceti numarul:");

            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Ultima cifra este: " + num % 10);



            //Rezolvare 2

            /*
            Console.WriteLine("Acest program va afisa ultima cifra a numarului introdus");

            Console.WriteLine("Introduceti numarul:");

            string num = Console.ReadLine();

            Console.WriteLine("Ultima cifra este: " + num[num.Length - 1]);
            */


        }
    }
}
