using System;


namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            #region base
            Console.WriteLine("Baza danych firmy XYZ");
            Console.WriteLine("Ile osób ma zostać wprowadzonych do bazy?");
            uint length;
            while (true)
            {
                if (uint.TryParse(Console.ReadLine(), out length) == true)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Prosze podać prawidłową wartość (liczbę całkowitą dodatnią)");
                }
            }
            Console.Clear();
            string[] parameters = new string[5] { "IMIĘ", "NAZWISKO", "NUMER", "WYDZIAŁ", "SPECJALIZACJE" };
            //tablica parametrowa
                    string[,] tablica = new string[length, 5];
            //tablica danych(5 to liczba pól )
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j == 0)
                    {
                        Console.WriteLine("Prosze podać {0} pracownika nr.{1}", parameters[j],i+1);
                        tablica[i, j] = Console.ReadLine();
                        //case z imieniem
                    }
                    else if (j == 2)
                    {
                        //case z numerem telefonu
                        while (true)
                        {
                            Console.WriteLine("Prosze podac numer kontaktowy(bez kierunkowego)");
                            string a = Console.ReadLine();
                            Console.Clear();
                            if (a.Length != 9)
                            {
                                Console.WriteLine("Numer musi być 9-cio cyfrowy, spróbuj ponownie");
                            }
                            if (a.Length == 9)
                            {
                                tablica[i, j] = a;
                                break;
                            }
                        }
                    }
                    else
                    {
                        string a;
                        Console.WriteLine("Proszę podać {0} pracownika {1}", parameters[j], tablica[i, 0]);
                        if (j == 1)
                        {
                            tablica[i, j] = Console.ReadLine();
                        }
                        if (j == 3)//wydziały
                        {
                            Console.WriteLine("Wydziały naszej firmy to: Technologiczny,Zarządzania,Finansowy");
                            while (true)
                            {
                                a = Console.ReadLine();
                                Console.Clear();
                                if (a == "Technologiczny")//nie można zastosowąc alternatywy do typu string :(
                                {
                                    tablica[i, j] = a;
                                    break;
                                }
                                if (a == "Zarządzania")
                                {
                                    tablica[i, j] = a;
                                    break;
                                }
                                if (a == "Finansowy")
                                {
                                    tablica[i, j] = a;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Nieprawidłowy wydział, w naszej firmie istnieją tylko:");
                                    Console.WriteLine("Technologiczny,Zarządzania,Finansowy");
                                    Console.WriteLine("Spróbuj pownownie");
                                }
                            }
                        }
                        if (j == 4)//specjalizacje
                        {
                            Console.WriteLine("Dostepne specjalizacje na");
                            if (tablica[i, 3] == "Technologiczny")
                            {
                                Console.WriteLine("Wydział Technologiczny to:");
                                Console.WriteLine("Atomowa,Kwantowa,Komputerowa");
                                while (true)
                                {
                                    a = Console.ReadLine();
                                    Console.Clear();
                                    if (a == "Atomowa")//nie można zastosowąc alternatywy do typu string :(
                                    {
                                        tablica[i, j] = a;
                                        break;
                                    }
                                    if (a == "Kwantowa")
                                    {
                                        tablica[i, j] = a;
                                        break;
                                    }
                                    if (a == "Komputerowa")
                                    {
                                        tablica[i, j] = a;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nieprawidłowa specjalizacja,dla tego wydziału istnieje tylko:");
                                        Console.WriteLine("Atomowa,Kwantowa,Komputerowa");
                                        Console.WriteLine("Spróbuj pownownie.");
                                    }
                                }
                            }
                            if (tablica[i, 3] == "Zarządzania")
                            {
                                Console.WriteLine("Wydział Zarządzania to:");
                                Console.WriteLine("Coaching,Nadzór,Kierownictwo");
                                while (true)
                                {
                                    a = Console.ReadLine();
                                    Console.Clear();
                                    if (a == "Coaching")//nie można zastosowąc alternatywy do typu string :(
                                    {
                                        tablica[i, j] = a;
                                        break;
                                    }
                                    if (a == "Nadzór")
                                    {
                                        tablica[i, j] = a;
                                        break;
                                    }
                                    if (a == "Kierownictwo")
                                    {
                                        tablica[i, j] = a;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nieprawidłowa specjalizacja,dla tego wydziału istnieje tylko:");
                                        Console.WriteLine("Coaching,Nadzór,Kierownictwo");
                                        Console.WriteLine("Spróbuj pownownie.");
                                    }
                                }
                            }
                            if (tablica[i, 3] == "Finansowy")
                            {
                                Console.WriteLine("Wydział Finansowy to:");
                                Console.WriteLine("Finanse,Rachunkowość,Marketing");
                                while (true)
                                {
                                    a = Console.ReadLine();
                                    Console.Clear();
                                    if (a == "Finanse")//nie można zastosowąc alternatywy do typu string :(
                                    {
                                        tablica[i, j] = a;
                                        break;
                                    }
                                    if (a == "Rachunkowość")
                                    {
                                        tablica[i, j] = a;
                                        break;
                                    }
                                    if (a == "Marketing")
                                    {
                                        tablica[i, j] = a;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Nieprawidłowa specjalizacja,dla tego wydziału istnieje tylko:");
                                        Console.WriteLine("Finanse,Rachunkowość,Marketing");
                                        Console.WriteLine("Spróbuj pownownie.");
                                    }
                                }
                            }

                        }
                        //reszta


                    }
                }
                    Console.WriteLine("{0} został wprowadzony do bazy danych", tablica[i, 0]);
                    Console.WriteLine("Wciśnij dowolny klawisz aby kontynuować.");
                    Console.ReadKey();
                    Console.Clear();
            }
            Console.WriteLine("\tOto spis wprowadzonych dancyh");
            Console.Write("\n");
            for (int i = 0; i < parameters.Length; i++)
                {
                    if (i == parameters.Length - 1)
                    {
                        Console.WriteLine(" {0} ", parameters[i]);
                    }
                    else
                    {
                        Console.Write(" {0} |", parameters[i]);
                    }
                }
            for (int i = 0; i < parameters.Length * 10; i++)
            {
               Console.Write("-");
            }
            Console.Write("\n");
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                        if (j == 4)
                        {
                            Console.Write(" {0} ", tablica[i, j]);
                        }
                        else
                        {
                            Console.Write(" {0} |", tablica[i, j]);
                        }
                }
                    Console.Write("\n");
            }




                Console.ReadKey();
            #endregion


        }
    }

}