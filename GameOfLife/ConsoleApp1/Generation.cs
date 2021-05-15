using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace ConsoleApp1
{
    [Serializable]
    class Generation
    {
        private List<Cell> Board = new List<Cell>();
        private List<Cell> Copy0 = new List<Cell>();
        private List<Cell> Copy1 = new List<Cell>();
        private int Step = 0,fullStep=0;
        private uint BoardX { get; set; }
        private uint BoardY { get; set; }
        public Generation(uint x, uint y, uint density)
        {
            //first constructor ~ done
            int densityReal = (int)Math.Ceiling(((double)density / 100) * ((double)x * (double)y));
            BoardX = x;
            BoardY = y;
            for(int i =0;i< densityReal;)
            {
                Random rnd = new Random();
                uint tempX = (uint)rnd.Next(0, (int)x);
                uint tempY = (uint)rnd.Next(0, (int)y);
                if (i == 0)
                {
                    Board.Add(new Cell(tempX, tempY, true));
                    i++;
                }
                else
                {
                    for (int j = 0; j < Board.Count; j++)
                    {
                        if (Board[j].coordinateX == tempX && Board[j].coordinateY == tempY) break;
                        else if (j == Board.Count - 1)
                        {
                            i++;
                            Board.Add(new Cell(tempX, tempY, true));
                        }
                    }
                }
            }
            for( uint i =0;i< y; i++)
            {
                for(uint j = 0; j < x; j++)
                {
                    for (int k = 0; k < Board.Count; k++)
                    {
                            if (Board[k].coordinateX == j && Board[k].coordinateY == i) break;
                            else if (k == Board.Count - 1)
                            {
                                Board.Add(new Cell(j, i, false));
                                break;
                            }
                    }
                }
            }
            GameMenu(Board);
        }
        public Generation(uint x, uint y, int livingCells)
        {
            //second constructor ~ done
            //Console.WriteLine(livingCells);
            BoardX = x;
            BoardY = y;
            for (int i = 0; i < livingCells;)
            {
                Random rnd = new Random();
                uint tempX = (uint)rnd.Next(0, (int)x);
                uint tempY = (uint)rnd.Next(0, (int)y);
                if (i == 0)
                {
                    Board.Add(new Cell(tempX, tempY, true));
                    i++;
                }
                else
                {
                    for (int j = 0; j < Board.Count; j++)
                    {
                        if (Board[j].coordinateX == tempX && Board[j].coordinateY == tempY) break;
                        else if (j == Board.Count - 1)
                        {
                            i++;
                            Board.Add(new Cell(tempX, tempY, true));
                        }
                    }
                }
            }
            for (uint i = 0; i < y; i++)
            {
                for (uint j = 0; j < x; j++)
                {
                    for (int k = 0; k < Board.Count; k++)
                    {
                        if (Board[k].coordinateX == j && Board[k].coordinateY == i) break;
                        else if (k == Board.Count - 1)
                        {
                            Board.Add(new Cell(j, i, false));
                            break;
                        }
                    }
                }
            }
            GameMenu(Board);
        }
        public Generation(string board,uint x, uint y)
        {
            //string[] tempArr = board.Split(",");
            BoardX = x;
            BoardY = y;
            int step = 0;
            uint tempX=0, tempY=0;
            string tempData,tempXstring="",tempYstring="";
            for(int i =0;i< board.Length; i++)
            {
                if (board[i] == '.' && step == 3)
                {
                    step = 0;
                    continue;
                }
                if (board[i] == '.' && step == 0)
                {
                    step++;
                    tempX = uint.Parse(tempXstring);
                    tempXstring = "";
                    continue;
                }
                if(board[i]=='.'&& step == 1)
                {
                    step++;
                    tempY = uint.Parse(tempYstring);
                    tempYstring = "";
                    continue;
                }
                if (step == 0)
                {

                    tempXstring += board[i].ToString();
                    continue;
                }
                if (step == 1)
                {
                    tempYstring += board[i].ToString();
                    continue;
                }
                if (step == 2)
                {
                    tempData = board[i].ToString();
                    if (tempData == "F")
                    {
                        step++;
                        Board.Add(new Cell(tempX, tempY, false));
                        tempData = "";
                    }
                    if (tempData == "T")
                    {
                        step++;
                       Board.Add(new Cell(tempX, tempY, true));
                        tempData = "";
                    }
                }
            }
            GameMenu(Board);
        }
         private void GameMenu(List<Cell> tempBoard)
         {
            //inside menu ~ done
            Extend();
            int Menu;
            bool end = false;
            while (end==false)
            {
                while (true)
                {
                    ToString(tempBoard);
                    Console.WriteLine("1. Show next generation");
                    Console.WriteLine("2. Skip few generations");
                    Console.WriteLine("3.  Exit and ?save?");
                    try
                    {
                        Menu = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (Menu == 1 || Menu == 2 || Menu == 3) break;
                        else throw new Exception();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Error, try again");
                    }
                }
                if (Menu == 3) end = true;
                if (Menu == 1) NextStep(ref tempBoard);
                if (Menu == 2)
                {
                    int howManyGen;
                    while (true)
                    {
                        Console.WriteLine("How many generations do you want to skip");
                        try
                        {
                            howManyGen = int.Parse(Console.ReadLine());
                            if (howManyGen > 0) break;
                            else throw new Exception();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Error try again");
                        }
                    }
                    for (int i = 0; i < howManyGen; i++)
                    {
                        NextStep(ref tempBoard);
                    }
                }
            }
            while (true)
            {
                Console.Clear();
                ToString(Board);
                Console.WriteLine("Do you want to save this board?^^^ Y/N");
                string ans = Console.ReadLine();
                if (ans == "Y")
                {
                    Save();
                    break;
                }
                if (ans == "N") break;
                else Console.WriteLine("Incorrect input, try again.");
            }
        }
        private int Check(int bufor,int pX,int pY,List<Cell> checkBoard)
        {
            int tempX, tempY;
                tempX = (int)checkBoard[bufor].coordinateX +pX;
                tempY = (int)checkBoard[bufor].coordinateY + pY;
            if (tempX < 0 || tempY < 0) return 0;
            else
            {
                for(int i=0;i< Board.Count; i++)
                {
                    if(checkBoard[i].coordinateX==tempX && checkBoard[i].coordinateY == tempY)
                    {
                        //Console.WriteLine(Board[i].alive+" "+Board[i].coordinateY+" "+ Board[i].coordinateX);
                        if (checkBoard[i].alive == true) return 1;
                        else return 0;
                    }
                }
                return 0;
            }

        }
        private void NextStep(ref List<Cell> tempBoard)
        {
            //generation step
            GetCopy(Step);
            Extend();
            int bufor=0, neighbor;
            List<Cell> checkBoard = new List<Cell>();
            for(int i = 0; i < tempBoard.Count; i++)
            {
                checkBoard.Add(new Cell(tempBoard[i].coordinateX, tempBoard[i].coordinateY, tempBoard[i].alive));
            }
            for (int i = 0; i < BoardY; i++)
            {
                for (int j = 0; j < BoardX; j++)
                {
                    neighbor = 0;
                    for (int k = 0; k < tempBoard.Count; k++)
                    {
                        if (tempBoard[k].coordinateY == i && tempBoard[k].coordinateX == j) bufor = k;
                    }
                    //Console.WriteLine(Board[bufor].coordinateY + " " + Board[bufor].coordinateX);
                    for (int l = 0; l < 8; l++)
                    {
                        if (l == 0) neighbor += Check(bufor, -1, -1, checkBoard);
                        if (l == 1) neighbor += Check(bufor, 0, -1, checkBoard);
                        if (l == 2) neighbor += Check(bufor, 1, -1, checkBoard);
                        if (l == 3) neighbor += Check(bufor, -1, 0, checkBoard);
                        if (l == 4) neighbor += Check(bufor, 1, 0, checkBoard);
                        if (l == 5) neighbor += Check(bufor, -1, 1, checkBoard);
                        if (l == 6) neighbor += Check(bufor, 0, 1, checkBoard);
                        if (l == 7) neighbor += Check(bufor, 1, 1, checkBoard);
                    }
                    //Console.WriteLine(neighbor);
                    if (tempBoard[bufor].alive == true)
                    {
                        if (neighbor == 3 || neighbor == 2) continue;
                        else tempBoard[bufor].kill();
                    }
                    else if (tempBoard[bufor].alive == false)
                    {
                        if (neighbor == 3) tempBoard[bufor].reborn();
                        else continue;
                    }
                }
            }
            isEqual();

        }
        private void GetCopy(int whichOne)
        {
            //~ done
            fullStep++;
            if (Step == 0)
            {
                Copy0 = new List<Cell>();
                for(int i =0;i< Board.Count; i++)
                {
                    Copy0.Add(new Cell(Board[i].coordinateX, Board[i].coordinateY, Board[i].alive));
                }
                Step++;
            }
            else if(Step == 1)
            {
                Copy1 = new List<Cell>();
                for (int i = 0; i < Board.Count; i++)
                {
                    Copy1.Add(new Cell(Board[i].coordinateX, Board[i].coordinateY, Board[i].alive));
                }
                Step = 0;
                //ToString(Copy0);
                //ToString(Copy1);
            }
        }
        private void isEqual()
        {
            //comparison ~ done
            int effectiveness0 = 0,effectiveness1=0;
            for(int i =0;i< Board.Count; i++)
            {
                if (Board[i] == Copy0[i]) effectiveness0++;
            }
            if (fullStep > 1)
            {
                for (int i = 0; i < Board.Count; i++)
                {
                    if (Board[i] == Copy1[i]) effectiveness1++;
                }
            }
            if (effectiveness0 == BoardX * BoardY || effectiveness1 == BoardX * BoardY)
            {
                Console.WriteLine("A stable structure was formed");
            }
        }
        private void Extend()
        {
            // ArrayExtension to greater size
            bool test = false;
            for (int i = 0; i < BoardY*BoardX; i++)
            {
                if (Board[i].coordinateY == 0 && Board[i].alive == true) test = true;
                if (Board[i].coordinateY == (BoardY - 1) && Board[i].alive == true) test = true;
                if (Board[i].coordinateX == 0 && Board[i].alive == true) test = true;
                if (Board[i].coordinateX == (BoardX-1) && Board[i].alive == true) test = true;
            }
            if (test == true)
            {
                if (fullStep > 0)
                {
                    Extension(ref Copy0, false);
                }
                if (fullStep > 1)
                {
                    Extension(ref Copy1, false);
                }
                Extension(ref Board,true);
            }
        }
        private void Extension(ref List<Cell> tempBoard,bool check)
        {
            // board extension ~ done
            List<Cell> exampleBoard= new List<Cell>();
            int tempX = (int)BoardX+2;
            int tempY = (int)BoardY+2;
            for (int i = 0; i < BoardY*BoardX; i++)
            {
                tempBoard[i].coordinateX += 1;
                tempBoard[i].coordinateY += 1;
            }
            for (int i = 0; i < tempBoard.Count; i++)
            {
                exampleBoard.Add(new Cell(tempBoard[i].coordinateX, tempBoard[i].coordinateY, tempBoard[i].alive));
            }
            for (int i = 0; i < tempY; i++)
            {
                bool test;
                for(int j = 0; j < tempX; j++)
                {
                    test = false;
                    for(int k = 0; k < exampleBoard.Count; k++)
                    {
                        //comparison
                        if (exampleBoard[k].coordinateX == j && exampleBoard[k].coordinateY == i) test = true;
                    }
                    if (test == false)
                    {
                        tempBoard.Add(new Cell((uint)j, (uint)i, false));
                    }
                }
            }
            if (check == true)
            {
                BoardX += 2;
                BoardY += 2;
            }
        }
        private void ToString(List<Cell> tempBoard)
        {
            //ShowBoard ~ done
            bool[,] tempArr = new bool[BoardY, BoardX];
            for(int i = 0; i < (BoardY * BoardX);i++)
            {
                tempArr[tempBoard[i].coordinateY, tempBoard[i].coordinateX] = tempBoard[i].alive;
            }
            for(int i=0;i< BoardY; i++)
            {
                    Console.WriteLine("");
                for(int j = 0; j < BoardX; j++)
                {
                    if (tempArr[i, j] == true)
                    {
                        Console.Write("[O]");
                    }
                    else Console.Write("[ ]");
                }
            }
            Console.WriteLine("");
        }

        private void Save()
        {
            string Path,ParamsPath;
            while (true)
            {
                Console.WriteLine("Choose one slot:");
                if (File.Exists("data.dat")) Console.WriteLine("1. FULL");
                else Console.WriteLine("1. EMPTY");
                if (File.Exists("data1.dat")) Console.WriteLine("2. FULL");
                else Console.WriteLine("2. EMPTY");
                if (File.Exists("data2.dat")) Console.WriteLine("3. FULL");
                else Console.WriteLine("3. EMPTY");
                string Menu = Console.ReadLine();
                Console.Clear();
                if (Menu == "1")
                {
                    Path = "data.dat";
                    ParamsPath = "params.dat";
                }
                else if (Menu == "2")
                {
                    Path = "data1.dat";
                    ParamsPath = "params1.dat";
                }
                else if (Menu == "3")
                {
                    Path = "data2.dat";
                    ParamsPath = "params2.dat";
                }
                else
                {
                    Console.WriteLine("Incorrect input, chosse one number from the list.");
                    continue;
                }
                break;
            }
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(Path, FileMode.Create, FileAccess.Write))
            {
                bf.Serialize(fs, Board);
            }
            List<uint> ParamsList = new List<uint>();
            ParamsList.Add(BoardX);
            ParamsList.Add(BoardY);
            using (FileStream fs = new FileStream(ParamsPath, FileMode.Create, FileAccess.Write))
            {
                bf.Serialize(fs, ParamsList);
            }
            Console.WriteLine("Board saved successfully");
        }
    }
}
