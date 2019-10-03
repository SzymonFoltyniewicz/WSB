using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nazwa_1
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.Write("WSB");
            Console.WriteLine("Nowa linia");

            Console.Write("Proszę podać swoje imię");

            string name = Console.ReadLine();
            //string to komenda pytania//
            
            
            Console.Write("Masz na imię:");
            Console.WriteLine(name);
            //Typ danych to string//
            int age = 20;
            Console.WriteLine(age);
            uint number = 10;
            //uint może zostać zapisane z minusem
            //typ float
            float z = 12.55F;
            //+konkatenacja 
            Console.WriteLine("Zmienna Z wynosi" + z);

            Console.WriteLine("Program obliczający pole prostokąta");

            Console.WriteLine("Proszę podać długość");

            string zmienna1 = Console.ReadLine();
            int dl1 = int.Parse(zmienna1);
            //parse zamienia wyraz na liczby//

            Console.WriteLine("Proszę podac szerokość");
            string zmienna2 = Console.ReadLine();
            int szer = int.Parse(zmienna2);
            //float x = float.Parse(Console.readline()); aby wyeliminować string//
            int obwod = (2 * dl1 + 2 * szer);
            Console.WriteLine("Obwód wynosi:" + obwod);
            //  x*= bokB jest to równoznaczne z x= x * bokB


            int x, y = 10, z;
            // int zmienna = 10;//
            int zmienna = new int()


            

        

            Console.ReadKey();
            
        }
    }
}
