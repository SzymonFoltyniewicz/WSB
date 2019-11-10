using System;

namespace Kalkulator
{
    class Program
    {   
        static void Sort(int[] tablica)
        {
            int n = tablica.Length;
            do
            {
                for(int i = 0; i < n - 1; i++)
                {
                    if (tablica[i] > tablica[i + 1])
                    {
                        int idm = tablica[i];
                        tablica[i] = tablica[i + 1];
                        tablica[i + 1] = idm;
                    }
                }
                n--;
            } while (n > 1);
            
        }
        static int Power(int sil)
        {
            int j = 1;
 
            for (int i = 1; i <= sil; i++)
            {
                j *= i;
            }
            return j;
        }
        static int Bin(int bin)
        {
            int d = 0;
            double c = bin;
            while (c >= 1)
            {
                c /= 2;
                c = Math.Floor(c);
                d++;
            }
            int[] bintab = new int[d];
            int k = 0;
            while (k < d)
            {
                int j = bin % 2;
                bintab[k] = j;
                bin /= 2;
                k++;

            }
            Console.WriteLine("\n");
            string v = "0";
            for (int i = d - 1; i >= 0; i--)
            {
              if (bintab[i] == 0)
                {
                    v += "0";
                }
              else
                {
                    v += "1";
                }
            }
            int g = int.Parse(v);
            return g;


        }
        static void Main(string[] args) 
        {
            string wyj = "Wynik przekracza możliwości kalkulatora, zajrzyj do instrukcji.";
            string wart,name,col;
            int zakres, wyk = 0, wyk2 = 0, wyk0 = 1;
            Console.WriteLine("Proszę podać imię, lub pseudonim :)");
            Console.WriteLine("Można pominąć tą opcję wciskając klawisz ENTER");
            Console.WriteLine("\n");
            while (true) 
            {
                try
                {
                    name = Console.ReadLine();
                    break;
                }
                catch(OutOfMemoryException)
                {
                    Console.WriteLine("Niewystarczająca ilość pamięci, spróbuj ponownie");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Instrukcja jest pustam spróbuj ponownie");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nieprawidłowy format,spróbuj ponownie");
                }
                Console.WriteLine("\n");
            }
            while (wyk0 == 1)
            {
                Console.WriteLine("Proszę wprowadzić numer który jest przyporządkowany do koloru ");
                Console.WriteLine("w którym ma funkcjonować program");
                Console.WriteLine("1 - Kolor czerwony");
                Console.WriteLine("2 - Kolor niebieski");
                Console.WriteLine("3 - Kolor żółty");
                Console.WriteLine("4 - Kolor domyślny");
                col = Console.ReadLine();
                Console.Clear();


                switch (col)
                {
                    case "1":
                        {
                            Console.WriteLine("Program będzie kontynuowany w kolorze czerwonym");
                            Console.ForegroundColor = ConsoleColor.Red;
                            wyk0--;
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("Program będzie kontynuowany w kolorze niebieskim");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            wyk0--;
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Program będzie kontynuowany w kolorze żółtym");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            wyk0--;
                            break;
                        }
                    case "4":
                        {
                            Console.WriteLine("Program będzie kontynuowany w kolorze domyślnym");
                            wyk0--;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("-----------------------------------------------------------");
                            Console.WriteLine("||NIEPRAWIDŁOWA WARTOŚĆ. PROSZĘ WYBRAĆ JEDEN Z NUMERÓW!!!||");
                            Console.WriteLine("-----------------------------------------------------------");
                            break;
                        }

                }
            }
                Console.WriteLine("\n");
                Console.WriteLine("Wciśnij dowolny klawisz, aby kontynuować");
                Console.ReadKey();
                Console.Clear();
           
            while (wyk < 5) 
            { 
            
           
                Console.WriteLine("\n");
                Console.WriteLine("\t\t\tWITAJ {0}", name);
                Console.WriteLine("\t\tOTO KALKULATOR LICZB CAŁOWITYCH");
                Console.WriteLine("\n");
                Console.WriteLine("Proszę podać ilość liczb które mają zostać poddane działaniom");
            while (true) 
            {
                try
                {
                    zakres = int.Parse(Console.ReadLine());
                        if (zakres == 1)
                        {
                            Console.WriteLine("Nie można przeprowadzić operacji ");
                            Console.WriteLine("na jednej liczbie,potrzebne są przynajmniej dwie");
                        }
                        else break;

                }
                catch (OverflowException)
                {
                    Console.WriteLine("Podana liczba jest za duża, spróbuj pownownie");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nieprawidłowy format, spróbuj ponownie");
                    Console.WriteLine("Wymagana jest liczba całkowita");
                }
                catch(OutOfMemoryException)
                {
                    Console.WriteLine("Niewystarczająca ilośc pamięci.Spróbuj ponownie");
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Pusta instrukcja");
                }
                
            }
                Console.Clear();

            int[] tablica =new int[zakres];
                
            while (true)
            {
                try
                {
                    for (int i = 0; i < zakres; i++)
                    {
                            Console.WriteLine("Podaj liczbę nr.{0}", i + 1);
                        tablica[i] = int.Parse(Console.ReadLine());
                    }
                    break;
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Pusta instrukcja");
                }
                catch (OutOfMemoryException)
                {
                    Console.WriteLine("Niewystarczająca ilośc pamięci. Spróbuj ponownie");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Podana liczba jest za duża, spróbuj pownownie");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nieprawidłowy format, spróbuj ponownie");
                    Console.WriteLine("Wymagana jest liczba całkowita");
                }
            }
                Console.Clear();


                while (wyk2 < 1)
                {
                    Console.WriteLine("\t\tKALKULATOR LICZB CAŁKOWITYCH");
                    Console.WriteLine("\t\tWitaj ponownie {0} oto menu główne", name);
                    if (DateTime.Now.Minute < 10)
                    {
                        Console.WriteLine("\t\t\tJest godzina {0}:0{1}", DateTime.Now.Hour, DateTime.Now.Minute);
                    }
                    else
                    {
                        Console.WriteLine("\t\t\tJest godzina {0}:{1}", DateTime.Now.Hour, DateTime.Now.Minute);
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine("Prosze podać numer instrukcji jaką ma zrealizować program");
                    Console.WriteLine("\n");
                    Console.WriteLine("1 - Dzielenie liczb");
                    Console.WriteLine("2 - Mnożenie liczb");
                    Console.WriteLine("3 - Dodawanie liczb");
                    Console.WriteLine("4 - Odejmowanie liczb");
                    Console.WriteLine("5 - Reszta z dzielenia");
                    Console.WriteLine("6 - Intrukcja obsługi");
                    Console.WriteLine("7 - Aby wyświetlić, dla przypomnienia podane wcześniej liczby w kolejności,");
                    Console.WriteLine("w której zostały wprowadzone");
                    Console.WriteLine("8 - Aby wyświetlić podane wcześniej liczby w rosnącej kolejności");
                    Console.WriteLine("9 - Aby wyświetlić liczby pierwsze zawierające się we wporwadzonych liczbach");
                    Console.WriteLine("10 - Aby wyświetlić silnię podanych liczb(jeśli jest to możliwe)");
                    Console.WriteLine("11 - Aby wyświetlić wprowadzone liczby w systemie binarnym");
                    Console.WriteLine("12 -  Jeśli chcesz wprowadzić inne liczby");
                    Console.WriteLine("13 - Aby opuścić program");
                    if (zakres == 2 || zakres == 3)
                    {
                        Console.WriteLine("Opcja specjalna - wprowadź '14' aby zobaczyć ciekawostkę");
                    }
                    
                    wart = Console.ReadLine();
                    Console.Clear();
                    int dok=tablica[0];
                    double dok2 = tablica[0];
                    int[] tablicasort = new int[zakres];
                    for (int i = 0; i < zakres; i++)
                    {
                        tablicasort[i] = tablica[i];
                    }
                    Sort(tablicasort);
                    


                    
                    switch (wart)
                    {
                        case "1":
                                {

                                Console.Clear();
                                    try
                                    {
                                        for (int i = 1; i < zakres; i++)
                                        {

                                            dok2 /= tablica[i];
                                        }
                                    }
                                    catch (DivideByZeroException)
                                    {
                                        Console.WriteLine("Nie można dzielić przez zero");
                                    }
                                    catch (OutOfMemoryException)
                                    {
                                        Console.WriteLine("Niewystarczająca ilośc pamięci");
                                    }
                                    catch (OverflowException)
                                    {
                                        Console.WriteLine("Za duża liczba, zajrzyj do instrukcji");
                                    }
                                    Console.WriteLine("\tWynik dzielenia to: {0}", dok2); 
                                Console.WriteLine("\n");
                                Console.WriteLine("Czy chcesz wykonać kolejne działanie?") ;
                                Console.WriteLine("Wprowadź 'T' - Jeśli chcesz wykonać kolejne działanie");
                                Console.WriteLine("Wprowadź 'N' - Jeśli chcesz opuścić program");
                                string ans = Console.ReadLine();
                                Console.Clear();
                                if (ans == "N")
                                {
                                    Console.WriteLine("Wciśnij dowolny klawisz aby zakończyć, do zobaczenia!");
                                    Console.ReadKey();
                                    wyk2++; wyk = 5;
                                }
                                Console.Clear();
                                break;
                                }
                        case "2":
                            {
                                Console.Clear();
                                try
                                {
                                    for (int i = 1; i < zakres; i++)
                                    {

                                        dok *= tablica[i];

                                    }
                                }
                                catch (OutOfMemoryException)
                                {
                                    Console.WriteLine(wyj);
                                }
                                catch (OverflowException)
                                {
                                    Console.WriteLine(wyj);
                                }
                                    Console.WriteLine("\tWynik mnożenia to: {0}", dok);
                                Console.WriteLine("\n");
                                Console.WriteLine("Czy chcesz wykonać kolejne działanie?");
                                Console.WriteLine("Wprowadź 'T' - Jeśli chcesz wykonać kolejne działanie");
                                Console.WriteLine("Wprowadź 'N' - Jeśli chcesz opuścić program");
                                string ans = Console.ReadLine();
                                Console.Clear();
                                if (ans == "N")
                                {
                                    Console.WriteLine("Wciśnij dowolny klawisz aby zakończyć, do zobaczenia!");
                                    Console.ReadKey();
                                    wyk2++; wyk = 5;
                                }
                                Console.Clear();
                                break;
                            }
                        case "3":
                            {
                                Console.Clear();
                                    try
                                    {
                                        for (int i = 1; i < zakres; i++)
                                        {

                                            dok += tablica[i];

                                        }
                                    }
                                    catch (OverflowException)
                                    {
                                        Console.WriteLine(wyj);
                                    }
                                    catch (OutOfMemoryException)
                                    {
                                        Console.WriteLine(wyj);
                                    }
                                    
                                Console.WriteLine("\tWynik dodawania to: {0}", dok);
                                Console.WriteLine("\n");
                                Console.WriteLine("Czy chcesz wykonać kolejne działanie?");
                                Console.WriteLine("Wprowadź 'T' - Jeśli chcesz wykonać kolejne działanie");
                                Console.WriteLine("Wprowadź 'N' - Jeśli chcesz opuścić program");
                                string ans = Console.ReadLine();
                                Console.Clear();
                                if (ans == "N")
                                {
                                    Console.WriteLine("Wciśnij klawisz dowolny klawisz aby zakończyć, do zobaczenia!");
                                    Console.ReadKey();
                                    wyk2++; wyk = 5;
                                }
                                Console.Clear();
                                break;
                            }
                        case "4":
                            {
                                Console.Clear();
                                    try
                                    {
                                        for (int i = 1; i < zakres; i++)
                                        {
                                            dok -= tablica[i];
                                        }
                                    }
                                    catch (OverflowException)
                                    {
                                        Console.WriteLine("Wynik wykracza poza możliwości kalkulatorazajrzyj do instrukcji");
                                    }
                                    catch (OutOfMemoryException)
                                    {
                                        Console.WriteLine("Niewystarczająca ilośc pamięci, zajrzyj do instrukcji");
                                    }
                                    
                                Console.WriteLine("\tWynik odejmowania to: {0}", dok);
                                Console.WriteLine("\n");
                                Console.WriteLine("Czy chcesz wykonać kolejne działanie?");
                                Console.WriteLine("Wprowadź 'T' - Jeśli chcesz wykonać kolejne działanie");
                                Console.WriteLine("Wprowadź 'N' - Jeśli chcesz opuścić program");
                                string ans = Console.ReadLine();
                                Console.Clear();
                                if (ans == "N")
                                {
                                    Console.WriteLine("Wciśnij dowolny klawisz aby zakończyć, do zobaczenia!");
                                    Console.ReadKey();
                                    wyk2++; wyk = 5;
                                }
                                Console.Clear();
                                break;
                            }
                        case "5":
                            {
                                Console.Clear();
                           
                                    for (int i = 1; i < zakres; i++)
                                    {
                                            dok2 %= tablica[i];
                                    }
                                
                                Console.WriteLine("\tReszta z dzielenia to: {0}", dok2);
                                Console.WriteLine("\n");
                                Console.WriteLine("Czy chcesz wykonać kolejne działanie?");
                                Console.WriteLine("Wprowadź 'T' - Jeśli chcesz wykonać kolejne działanie");
                                Console.WriteLine("Wprowadź 'N' - Jeśli chcesz opuścić program");
                                string ans = Console.ReadLine();
                                Console.Clear();
                                if (ans == "N")
                                {
                                    Console.WriteLine("Wciśnij dowolny klawisz aby zakończyć, do zobaczenia!");
                                    Console.ReadKey();
                                    wyk2++; wyk = 5;
                                }
                                Console.Clear();
                                break;
                            }
                        case "6":
                            {
                                Console.Clear();
                                Console.WriteLine("Aby wykonać działanie za pomoca kalulatora należy potępować zgonie z");
                                Console.WriteLine("instrukcjami wyświetlającymi się na ekranie.");
                                Console.WriteLine("\n");
                                Console.WriteLine("\t\t\tUWAGI");
                                Console.WriteLine("1.Kalkulator wykonuje tylko działania na liczbach całkowitych, ale jest w stanie ");
                                Console.WriteLine("zwrócić wynik niecałkowity z pewnym ograniczonym rozwnięciem dziesiętnym");
                                Console.WriteLine("\n");
                                Console.WriteLine("2.Liczby są poddawane działaniom w takiej kolejności w jakiej");
                                Console.WriteLine("zostały wprowadzone.");
                                Console.WriteLine("(Aby poznać ich kolejność, wybierz '7' na panelu głównym)");
                                Console.WriteLine("\n");
                                Console.WriteLine("3.Najwyższy wynik przeprowadzonego działania liczby to: 2 147 483 647");
                                Console.WriteLine("A najniższy: −2 147 483 648 ");
                                Console.WriteLine("Nieco większy zakres obowiązuje przy operacjach takich jak");
                                Console.WriteLine("'reszta z dzielenia' i 'dzielenie'.");
                                Console.WriteLine("4.Jeśli kalkulator podał nieprawidłowy wynik to jest to spowodowane");
                                Console.WriteLine("punktem 3.");
                                Console.WriteLine("\n");
                                Console.WriteLine("Czy chcesz wykonać działanie?");
                                Console.WriteLine("Wprowadź 'T' - Jeśli chcesz wykonać działanie");
                                Console.WriteLine("Wprowadź 'N' - Jeśli chcesz opuścić program");
                                Console.WriteLine("\n");
                                Console.WriteLine("\t\t\t\t\tWykonał: Szymon Foltyniewicz");
                                
                                string ans = Console.ReadLine();
                                Console.Clear();
                                if (ans == "N")
                                {
                                    Console.WriteLine("Wciśnij dowolny klawisz aby zakończyć, do zobaczenia!");
                                    Console.ReadKey();
                                    wyk2++; wyk = 5;
                                }
                                Console.Clear();
                                break;
                            }
                        case "7":
                            {
                                Console.Clear();
                                Console.WriteLine("\t\tTo liczby w kolejności w jakiej zostały wprowadzone");
                                for (int i = 0; i < zakres; i++)
                                {
                                    Console.WriteLine("Oto liczba nr.{0}\t{1}", i + 1, tablica[i]);
                                }
                                Console.WriteLine("\n");
                                Console.WriteLine("Czy chcesz wykonać kolejne działanie?");
                                Console.WriteLine("Wprowadź 'T' - Jeśli chcesz wykonać kolejne działanie");
                                Console.WriteLine("Wprowadź 'N' - Jeśli chcesz opuścić program");
                                string ans = Console.ReadLine();
                                Console.Clear();
                                if (ans == "N")
                                {
                                    Console.WriteLine("Wciśnij dowolny klawisz aby zakończyć, do zobaczenia!");
                                    Console.ReadKey();
                                    wyk2++; wyk = 5;
                                }
                                Console.Clear();
                                break;
                            }
                        case "8":
                            {
                                Console.Clear();
                                Console.WriteLine("\t\tOto wprowadzone liczby w kolejności rosnącej");
                                for (int i = 0; i < zakres; i++)
                                {
                                    Console.WriteLine("nr.{0} = {1}", i + 1, tablicasort[i]);
                                }
                                Console.WriteLine("\n");
                                Console.WriteLine("Czy chcesz wykonać na nich działanie?");
                                Console.WriteLine("Wprowadź 'T' - Jeśli chcesz wykonać działanie");
                                Console.WriteLine("Wprowadź 'N' - Jeśli chcesz opuścić program");
                                string ans = Console.ReadLine();
                                Console.Clear();
                                if (ans == "N")
                                {
                                    Console.WriteLine("Wciśnij dowolny klawisz aby zakończyć, do zobaczenia!");
                                    Console.ReadKey(); 
                                    wyk2++; wyk = 5; 
                                }
                                Console.Clear();
                                break;

                            }
                        case "9":
                            {
                                Console.Clear();
                                Console.WriteLine("\t\tOto liczby pierwsze znajdujące się w podanych liczbach");
                                Console.WriteLine("\n");
                                Console.WriteLine("Liczby podane są w kolejności rosnącej");
                                Console.WriteLine("\n");
                                for (int g = 0; g < zakres; g++)
                                {
                                    Console.WriteLine("Dla liczby nr.{0}({1}):", g+1,tablicasort[g]);
                                    int[] tablicapir = new int[tablicasort[g] + 1];
                                    int zakres1 = (tablicapir.Length - 1);
                                    for (int i = 1; i <= zakres1; i++)
                                    {
                                        tablicapir[i] = i;
                                    }
                                    int dokad = (int)Math.Floor(Math.Sqrt(zakres1));
                                    for (int i = 2; i <= dokad; i++)
                                    {
                                        if (tablicapir[i] != 0)
                                        {
                                            int j = i + i;
                                            while (j <= zakres1)
                                            {
                                                (tablicapir[j]) = 0;
                                                j += i;
                                            }
                                        }
                                    }
                                    for (int i = 0; i < tablicapir.Length; i++)
                                    {
                                        if (tablicapir[i] != 0)
                                        {
                                            Console.Write(tablicapir[i] + "\t");
                                        }
                                    }
                                    for (int i = 0; i < tablicapir.Length; i++)
                                    {
                                        tablicapir[i] = 0;
                                    }
                                    Console.WriteLine("\n");
                                }
                                Console.WriteLine("\n");
                                Console.WriteLine("Czy chcesz wykonać działanie na wprowadzonych liczbach?");
                                Console.WriteLine("Wprowadź 'T' - Jeśli chcesz wykonać działanie");
                                Console.WriteLine("Wprowadź 'N' - Jeśli chcesz opuścić program");
                                string ans = Console.ReadLine();
                                Console.Clear();
                                if (ans == "N")
                                {
                                    Console.WriteLine("Wciśnij dowolny klawisz aby zakończyć do zobaczenia!");
                                    Console.ReadKey();
                                    wyk2++; wyk = 5;
                                }
                                Console.Clear();
                                break;

                            }
                        case "10":
                            {
                                Console.Clear();
                                Console.WriteLine("Oto silnia wprowadzonych liczb");
                                Console.WriteLine("\n");


                                
                                        for (int i = 0; i < zakres; i++) 
                                {
                                    try
                                    {

                                        int sil = tablica[i];
                                        Console.WriteLine("Dla liczby nr.{0}({1}) silnia wynosi:", i + 1, sil);

                                            Console.WriteLine(Power(sil));

                                    }
                                    catch (OverflowException)
                                    {
                                        Console.WriteLine("Wynik wykracza poza możliwości kalkulatora");
                                        Console.WriteLine("Zajrzyj do instrukcji");
                                    }
                                    catch (OutOfMemoryException)
                                    {
                                        Console.WriteLine(wyj);
                                    }
                                }
                                
                                Console.WriteLine("\n");
                                Console.WriteLine("Czy chcesz wykonać działanie na wprowadzonych liczbach?");
                                Console.WriteLine("Wprowadź 'T' - Jeśli chcesz wykonać działanie");
                                Console.WriteLine("Wprowadź 'N' - Jeśli chcesz opuścić program");
                                string ans = Console.ReadLine();
                                Console.Clear();
                                if (ans == "N")
                                {
                                    Console.WriteLine("Wciśnij dowolny klawisz aby zakończyć, do zobaczenia!");
                                    Console.ReadKey();
                                    wyk2++; wyk = 5;
                                }
                                Console.Clear();
                                break;
                            }
                        case "11":
                            {
                                Console.Clear();
                                Console.WriteLine("\t\t\tOto binarne odpowiedniki wprowadzonych liczb");
                                Console.WriteLine("\n");
                                for (int i = 0; i < zakres; i++)
                                {
                                    int bin = tablica[i];
                                    Console.WriteLine("Odpowienik binarny liczby nr.{0} ({1}): {2}", i + 1, tablica[i],Bin(bin));

                                }
                                Console.WriteLine("\n");
                                Console.WriteLine("Czy chcesz wykonać działanie na wprowadzonych liczbach?");
                                Console.WriteLine("Wprowadź 'T' - Jeśli chcesz wykonać działanie");
                                Console.WriteLine("Wprowadź 'N' - Jeśli chcesz opuścić program");
                                string ans = Console.ReadLine();
                                Console.Clear();
                                if (ans == "N")
                                {
                                    Console.WriteLine("Wciśnij dowolny klawisz aby zakończyć, do zobaczenia!");
                                    Console.ReadKey();
                                    wyk2++; wyk = 5;
                                }
                                Console.Clear();
                                break;
                            }
                        case "12":
                            {
                                Console.Clear();
                                wyk2++;
                                break;
                            }
                        case "13":
                            {
                                Console.Clear();
                                Console.WriteLine("Wciśnij dowolny klawisz aby zakończyć, do zobaczenia!");
                                Console.ReadKey();
                                wyk2++;
                                wyk = 5;
                                break;
                            }
                        case "14":
                            {
                                int i=0;
                                while(i < 2)
                                {
                                    if (zakres > 3)
                                    {
                                        i++;
                                        i++;
                                    }
                                    Console.WriteLine("\t\t\t OTO CIEKAWOSTKA");
                                    Console.WriteLine("\n");
                                    if (zakres == 2)
                                    {
                                        Console.WriteLine("Pole prostokąta utworzonego z podanych przez Ciebie liczb");
                                        Console.WriteLine("Wynosiłoby {0}cm/kw", tablica[0] * tablica[1]);
                                        Console.WriteLine("\n");
                                        Console.WriteLine("A jego obwód wynosiłby {0}cm", ((tablica[0]) * 2 + (tablica[1] * 2)));
                                        i++;
                                    }
                                    else if(zakres == 3)
                                    {
                                        Console.WriteLine("Gdyby podane liczby tworzyły trójkąt to jego obwód");
                                        Console.WriteLine("wynosiłby {0}cm", tablica[0] + tablica[1] + tablica[2]);
                                        i++;
                                    }
                                    if (i == 1)
                                    {
                                        Console.WriteLine("\n");
                                        Console.WriteLine("Czy chcesz wykonać na nich działanie?");
                                        Console.WriteLine("Wprowadź 'T' - Jeśli chcesz wykonać działanie");
                                        Console.WriteLine("Wprowadź 'N' - Jeśli chcesz opuścić program");
                                        string ans = Console.ReadLine();
                                        Console.Clear();
                                        if (ans == "N")
                                        {
                                            Console.WriteLine("Wciśnij dowolny klawisz aby zakończyć, do zobaczenia!");
                                            Console.ReadKey();
                                            wyk2++; wyk = 5;
                                        }
                                        i++;
                                        Console.Clear();
                                    }
                                    
                                }
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("========================================================");
                                Console.WriteLine("||Podana wartość jest spoza przedstawionego zakresu!!!||");
                                Console.WriteLine("========================================================");
                                break;
                            }
                    }
                }
                wyk2--;
            }
        }
    }
}
