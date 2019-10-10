using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program obliczający pole prostokąta");
            Console.WriteLine("Proszę liczbę długość ");
            string x = Console.ReadLine();
            int y, c;
            Console.WriteLine("Prosze podać szerokość");
            string z = Console.ReadLine();
            //
            if ((int.TryParse(x, out y)) && int.TryParse(z, out c) == true)
            { Console.WriteLine("Pole prostokąta wynosi {0}", y * c); }
            else Console.WriteLine("Podana wartość jest błędna");
            Console.ReadKey();

            Console.WriteLine("Kalkulator BMI");
            Console.WriteLine("Prosze podac swoją wagę w kg");
            string waga = Console.ReadLine();
            float wg, wz;
            Console.WriteLine("Prosze podać swój wzrost w metrach");
            string wzrost = Console.ReadLine();
            if (float.TryParse(waga, out wg) == true && (float.TryParse(wzrost, out wz) == true))
            {
                float BMI = wg / (wz * wz);
                Console.WriteLine("Twoje BMI wynosi {0}", BMI);
                Console.WriteLine("Oznacza to że");
                if (BMI < 18.5)
                { Console.WriteLine("Wygłodzenie"); }
                else if (18.5 <= BMI && BMI < 24.99)
                { Console.WriteLine("Waga prawiddłowa"); }
                else Console.WriteLine("Nadwaga");
            }


            Console.WriteLine("1 - Pole kwadratu\n2 - pola koła");
            Console.Write("Wybierz wartość");
            string x1;
            x1 = Console.ReadLine();
            switch (x1)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Pole kwadratu");
                    Console.WriteLine("Prosze podać długość boku");
                    string dl = Console.ReadLine();
                    float dl1;
                    if (float.TryParse(dl, out dl1) == true)
                    { Console.WriteLine("Pole kwadratu wynosi {0}", dl1 * dl1); }
                    else Console.WriteLine("Podałeś błędne dany");


                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Pole koła");
                    Console.WriteLine("Prosze podać promień koła");
                    string r1 = Console.ReadLine();
                    double r;
                    if (double.TryParse(r1, out r) == true)
                    {
                        double Pole = Math.PI * r * r;
                        Console.WriteLine("Pole koła wynosi: {0:##.##}", Pole);
                    }
                    else Console.WriteLine("Podaeś błędne dany");

                    break;
                default:
                    Console.WriteLine("Podaleś błędne dane");
                    break;
            }

            Console.WriteLine("inicjalizacji , warunek,dekrementacja or inkrementacja");


            for (int i = 1; i < +10; i++)
            {
                Console.WriteLine(i + " ");


            }
            Console.WriteLine("");
            //Wyświatl liczb parzyste z przedziału od 5 do 20 w porzadku malejącym

            for (int x = 20; x >= 5; x--)
            {
                if (x % 2 == 0)
                    Console.WriteLine("Liczba {0} jest parzysta", x);

            }
            //wyswiatl choinkę na ekranie  wysokość podaje uzytkownik

            char K = '*';
            Console.WriteLine("Proszę podać wysokośc choinki");
            int p = int.Parse(Console.ReadLine());

            for (int i = 1; i <= p; i++)
            {
                Console.WriteLine("");
                for (int j = 1;  j <= i; j++)
                    Console.Write(K);
            }
            Console.ReadKey();

            
            













       




            



           














        }
    }
}
