using System;

namespace Zadanie_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Obliczający pole prostokąta");
            //Nagłówek
            Console.WriteLine("Proszę o podanie długości prostokąta");
            int x = int.Parse(Console.ReadLine());
            //Pierwsza zmienna
            Console.WriteLine("Proszę o podanie szerokości prostokąta");

            int y = int.Parse(Console.ReadLine());
            //Druga zmienna
            Console.WriteLine("Pole prostokąta wynosi:" + (x * y) + "cm/kw");
            //Obliczenie końcowe
            Console.ReadKey();
        }
    }
}
