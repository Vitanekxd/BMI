using System;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            double c;

            Console.Clear();
            Console.WriteLine("Klakulačka BMI");
            Console.WriteLine("--------------");

            Console.WriteLine("zadej výšku(cm):");
            a = Console.ReadLine();
            int vyska = int.Parse(a);

            Console.WriteLine("Zadej hmotnost: ");
            b = Console.ReadLine();
            int hmotnost = int.Parse(b);

            c = (vyska / 100) * (vyska / 100);

            Console.WriteLine("Tvoje BMI je " + c);
            Console.ReadLine();
        }
    }
}