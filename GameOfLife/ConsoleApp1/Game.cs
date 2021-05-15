using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ConsoleApp1
{
   static class Game
    {
        //StillAlive= new uint[2] { 2,3 };
        //Reborn=3;
        static public void ShowMenu()
        {
            bool boardExist = false;
            bool end = false;
            List<uint> ParamsList = new List<uint>();
            List<Cell> Board= new List<Cell>();

            while (end==false)
            {
                uint Menu;
                while (true)
                {
                    Console.WriteLine("1. Enter the data and start the game.");
                    Console.WriteLine("2. Load board from file.");
                    Console.WriteLine("3. Show the board and start the game with it");
                    Console.WriteLine("4. Exit");
                    try
                    {
                        Menu = uint.Parse(Console.ReadLine());
                        if (Menu > 4 || Menu < 1) throw new Exception();
                        else break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid data entered");
                    }
                }
                switch (Menu)
                {
                    case 1:
                        {
                            Menu02();
                            break;
                        }
                    case 2:
                        {
                            string Path="", ParamsPath="",Menu0;
                            while (true)
                            {
                                Console.WriteLine("Choose one slot:");
                                if (File.Exists("data.dat")) Console.WriteLine("1. FULL");
                                else Console.WriteLine("1. EMPTY");
                                if (File.Exists("data1.dat")) Console.WriteLine("2. FULL");
                                else Console.WriteLine("2. EMPTY");
                                if (File.Exists("data2.dat")) Console.WriteLine("3. FULL");
                                else Console.WriteLine("3. EMPTY");
                                Console.WriteLine("4. Back");
                                Menu0 = Console.ReadLine();
                                Console.Clear();
                                if (Menu0 == "1" && File.Exists("data.dat"))
                                {
                                    Path = "data.dat";
                                    ParamsPath = "params.dat";
                                }
                                else if (Menu0 == "2" && File.Exists("data1.dat"))
                                {
                                    Path = "data1.dat";
                                    ParamsPath = "params1.dat";
                                }
                                else if (Menu0 == "3" & File.Exists("data2.dat"))
                                {
                                    Path = "data2.dat";
                                    ParamsPath = "params2.dat";
                                }
                                else if (Menu0 == "4") break;
                                else
                                {
                                    Console.WriteLine("Incorrect input, remember, you cant load empty save.");
                                    continue;
                                }
                                break;
                            }
                            if (Menu0 != "4")
                            {
                                ParamsList = null;
                                Board = null;
                                BinaryFormatter bf = new BinaryFormatter();
                                using (FileStream fs = new FileStream(Path, FileMode.Open, FileAccess.Read))
                                {
                                    Board = (List<Cell>)bf.Deserialize(fs);
                                }
                                using (FileStream fs = new FileStream(ParamsPath, FileMode.Open, FileAccess.Read))
                                {
                                    ParamsList = (List<uint>)bf.Deserialize(fs);
                                }
                                boardExist = true;
                                Console.WriteLine("Board loaded succesfully");
                                //Console.WriteLine(ParamsList[0]+""+ParamsList[1]);
                                //x is placed at 0 index , y at 1;
                            }
                            break;
                        }
                    case 3:
                        {
                            if(boardExist==false)
                            {
                                Console.WriteLine("First you need to load the table");
                                break;
                            }
                            else
                            {
                                string data = "";
                                //List<string> data = new List<string>();
                                for(int i = 0; i<Board.Count; i++)
                                {
                                    data += Board[i].coordinateX.ToString();
                                    data += ".";
                                    //data.Add(Board[i].coordinateX.ToString());
                                    //data.Add(".");
                                    data += Board[i].coordinateY.ToString();
                                    data += ".";
                                    //data.Add(Board[i].coordinateY.ToString());
                                    //data.Add(".");
                                    if (Board[i].alive == true) data += "T";
                                    else data += "F";
                                    data += ".";
                                    //data.Add((Board[i].alive.ToString())[0].ToString());
                                    //data.Add(".");
                                }
                                //Console.WriteLine(data);
                                Generation Gn = new Generation(data, ParamsList[0], ParamsList[1]);
                            }
                            break;
                        }
                    case 4:
                        {
                            end = true;
                            break;
                        }
                }
            }
        }
        static private void Menu02()
        {
            //enter data params
            uint tempEdgeX, tempEdgeY, density,livingCells;
            string Ans;
            while (true)
            {
                //edge
                Console.WriteLine("Enter the value of the board edge:");
                try
                {
                    Console.WriteLine("Value X:");
                    tempEdgeX = uint.Parse(Console.ReadLine());
                    if (tempEdgeX <= 0) throw new Exception();
                    Console.WriteLine("Value Y:");
                    tempEdgeY = uint.Parse(Console.ReadLine());
                    if (tempEdgeY > 0) break;
                    else throw new Exception();
                }
                catch(Exception)
                {
                    Console.Clear();
                    Console.WriteLine("The edge value must be greater than 0");
                }
            }
            while (true)
            {
                //population density
                Console.WriteLine("Do you want to enter the 'population' density of the board? Y/N");
                Console.WriteLine("If you want to enter the number of live cells directly, press N");
                Ans = Console.ReadLine();
                if(Ans == "Y")
                {
                    while (true)
                    {
                        Console.WriteLine("Enter % value of population");
                        try
                        {
                            density = uint.Parse(Console.ReadLine());
                            if (density > 0 && density < 101) break;
                            else throw new Exception();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Incorrect data entered");
                        }
                    }
                    Generation Temp = new Generation(tempEdgeX,tempEdgeY,density);
                    break;
                }
                else if (Ans == "N")
                {
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Set the number of living cells");
                            livingCells = uint.Parse(Console.ReadLine());
                            if (livingCells > (tempEdgeY *tempEdgeX) || livingCells < 1) throw new Exception();
                            else break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Incorrect data entered");
                        }
                    }
                    Generation TempObj = new Generation(tempEdgeX, tempEdgeY, (int)livingCells);
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Incorrect input, try again");
                }
            }
        }


    }
}
