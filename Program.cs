using System;

namespace Zajęcia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Napisz program ktory za pomocą instrukcji do while dla danych wartości zmieniających się w przedziale od 0 do 15 oblicza wartość funkcji y = 4x

            //int   x = 1;
            //int suma= 0;

            //do
            //{
            //    y = 4 * x;
            //    Console.WriteLine("x ={0}\ty = {1}", x, y);
            //        x++;
            //} while (x <= 15);

            //Napisz program znajdujący się powyżej za pomocą pętli while

            //while(x<=15)
            //{ y = x * 4;
            //Console.WriteLine("x={0}\ty = {1}",x,y);
            //    x++;
            //}

            //napisz program który za pomocą instrukcji while dla danych wartości x zmieniających się w przedziale od 1 do 50 obliczy ich sumę 

            //while (x <= 50)
            //{
            //    suma += x;
            //    x ++;
            //}
            //Console.WriteLine("Suma wynosi {0}", suma);
            //napisz program który za pomocą pętli for sumuje liczby nieparzyste z przedziału od 1 do 10 
            //int suma = 0;
            //for (int x = 1; x <=10 ; x++)
            //{
            //    if (x % 2 == 0)

            //        suma += x;

            //}
            //Console.WriteLine("Suma liczb parzystych {0}", suma);

            //int  n = 10, row , cow;
            //row = 1;

            //do
            //{
            //    cow = 1;    

            //    do
            //    {

            //        Console.Write


            //       (row * cow + "\t");
            //        cow++;


            //    } while (cow <= n);
            //    row++;
            //    Console.WriteLine();

            //} while (row  <= n);
            //Napisz program który wywietli duże litery alfaabetu od a do z i od z do a z wykoszystaniem pętli for


            //for (char x = 'A'; x <= 'Z'; x++)
            //{
            //    if (x < 'Z')
            //        Console.Write(x + ",");
            //    else
            //        Console.Write(x + ".");
            //}

            //        int i = 1;
            //        for (; i <= 10; i++)
            //        {
            //            if (i == 3 || i == 6 || i == 7)
            //                break;
            //            else
            //                Console.Write("{0} ", i);

            //        }


            //Napisz program który w 10-cio elementowej tablicy jednowymiarowej umieszcza liczby całkowite od 1 do 10
            int n = 10, i;
            //deklaracja tablicy typpu całkowitego o rozmiarze n =10

            int[] tab = new int[n];

            for (i = 0; i < tab.Length; i++)
            { tab[i] = i; }

            for (i = 0; i < tab.Length; i++)
                Console.WriteLine(tab[i]);
            //Napis program w 5cio elementowej tablicy jednowymiarowej o nazwie colors umieszcza nazwy kolorów podane przez użytkownika i wyświetl kolory w formaci kolror 1, kolro2 

            string[] colors = new string[5];
            string color;
            for (i = 0; i < colors.Length; i++)
            {
                Console.Write("Podaj ulubiony kolor:");
                color = Console.ReadLine();
                colors[i] = color;
            }
            Console.Clear();
            Console.WriteLine("Ulubione kolory:");
            int x = 0, count






        }
    }   
}
