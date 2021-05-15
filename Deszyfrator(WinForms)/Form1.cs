using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deszyfrator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool kodowanie = true;

        static int Kodowanie1(string al)
        {
            int result = 0;
            if (al == "q")
            {
                result = 0;
            }
            if (al == " ")
            {
                result = 1;
            }
            if (al == "w")
            {
                result = 2;
            }
            if (al == "e")
            {
                result = 3;
            }
            if (al == "r")
            {
                result = 4;
            }
            if (al == "t")
            {
                result = 5;
            }
            if (al == "y")
            {
                result = 6;
            }
            if (al == "u")
            {
                result = 7;
            }
            if (al == "i")
            {
                result = 8;
            }
            if (al == "o")
            {
                result = 9;
            }
            if (al == "p")
            {
                result = 10;
            }
            if (al == "a")
            {
                result = 11;
            }
            if (al == "s")
            {
                result = 12;
            }
            if (al == "d")
            {
                result = 13;
            }
            if (al == "f")
            {
                result = 14;
            }
            if (al == "g")
            {
                result = 15;
            }
            if (al == "h")
            {
                result = 16;
            }
            if (al == "j")
            {
                result = 17;
            }
            if (al == "k")
            {
                result = 18;
            }
            if (al == "l")
            {
                result = 19;
            }
            if (al == "z")
            {
                result = 20;
            }
            if (al == "x")
            {
                result = 21;
            }
            if (al == "c")
            {
                result = 22;
            }
            if (al == "v")
            {
                result = 23;
            }
            if (al == "b")
            {
                result = 24;
            }
            if (al == "n")
            {
                result = 25;
            }
            if (al == "m")
            {
                result = 26;
            }
            if (al == "!")
            {
                result = 27;
            }
            if (al == "@")
            {
                result = 28;
            }
            if (al == "%")
            {
                result = 29;
            }
            if (al == "#")
            {
                result = 30;
            }
            if (al == "(")
            {
                result = 31;
            }
            if (al == ")")
            {
                result = 32;
            }
            if (al == "$")
            {
                result = 33;
            }
            if (al == ".")
            {
                result = 34;
            }
            if (al == "*")
            {
                result = 35;
            }
            if (al == "Q")
            {
                result = 36;
            }
            if (al == "W")
            {
                result = 37;
            }
            if (al == "E")
            {
                result = 38;
            }
            if (al == "R")
            {
                result = 39;
            }
            if (al == "T")
            {
                result = 40;
            }
            if (al == "Y")
            {
                result = 41;
            }
            if (al == "U")
            {
                result = 42;
            }
            if (al == "I")
            {
                result = 43;
            }
            if (al == "O")
            {
                result = 44;
            }
            if (al == "P")
            {
                result = 45;
            }
            if (al == "A")
            {
                result = 46;
            }
            if (al == "S")
            {
                result = 47;
            }
            if (al == "D")
            {
                result = 48;
            }
            if (al == "F")
            {
                result = 49;
            }
            if (al == "G")
            {
                result = 50;
            }
            if (al == "H")
            {
                result = 51;
            }
            if (al == "J")
            {
                result = 52;
            }
            if (al == "K")
            {
                result = 53;
            }
            if (al == "L")
            {
                result = 54;
            }
            if (al == "Z")
            {
                result = 55;
            }
            if (al == "X")
            {
                result = 56;
            }
            if (al == "C")
            {
                result = 57;
            }
            if (al == "V")
            {
                result = 58;
            }
            if (al == "B")
            {
                result = 59;
            }
            if (al == "N")
            {
                result = 60;
            }
            if (al == "M")
            {
                result = 61;
            }
            if (al == "ó")
            {
                result = 62;
            }
            if (al == "ę")
            {
                result = 63;
            }
            if (al == "ą")
            {
                result = 64;
            }
            if (al == "ś")
            {
                result = 65;
            }
            if (al == "ł")
            {
                result = 66;
            }
            if (al == "ż")
            {
                result = 67;
            }
            if (al == "ź")
            {
                result = 68;
            }
            if (al == "ć")
            {
                result = 69;
            }
            if (al == "ń")
            {
                result = 70;
            }
            if (al == "Ę")
            {
                result = 71;
            }
            if (al == "Ó")
            {
                result = 72;
            }
            if (al == "Ą")
            {
                result = 73;
            }
            if (al == "Ś")
            {
                result = 74;
            }
            if (al == "Ł")
            {
                result = 75;
            }
            if (al == "Ż")
            {
                result = 76;
            }
            if (al == "Ź")
            {
                result = 77;
            }
            if (al == "Ć")
            {
                result = 78;
            }
            if (al == "Ń")
            {
                result = 79;
            }
            if (al == "0")
            {
                result = 80;
            }
            if (al == "1")
            {
                result = 81;
            }
            if (al == "2")
            {
                result = 82;
            }
            if (al == "3")
            {
                result = 83;
            }
            if (al == "4")
            {
                result = 84;
            }
            if (al == "5")
            {
                result = 85;
            }
            if (al == "6")
            {
                result = 86;
            }
            if (al == "7")
            {
                result = 87;
            }
            if (al == "8")
            {
                result = 88;
            }
            if (al == "9")
            {
                result = 89;
            }

            return result;
        }

        static string Kodowanie2(int al)
        {
            string result = "";
            if (al == 0)
            {
                result = "q";
            }
            if (al == 1)
            {
                result = " ";
            }
            if (al == 2)
            {
                result = "w";
            }
            if (al == 3)
            {
                result = "e";
            }
            if (al == 4)
            {
                result = "r";
            }
            if (al == 5)
            {
                result = "t";
            }
            if (al == 6)
            {
                result = "y";
            }
            if (al == 7)
            {
                result = "u";
            }
            if (al == 8)
            {
                result = "i";
            }
            if (al == 9)
            {
                result = "o";
            }
            if (al == 10)
            {
                result = "p";
            }
            if (al ==11)
            {
                result = "a";
            }
            if (al == 12)
            {
                result = "s";
            }
            if (al == 13)
            {
                result = "d";
            }
            if (al == 14)
            {
                result = "f";
            }
            if (al == 15)
            {
                result = "g";
            }
            if (al == 16)
            {
                result = "h";
            }
            if (al == 17)
            {
                result = "j";
            }
            if (al == 18)
            {
                result = "k";
            }
            if (al == 19)
            {
                result = "l";
            }
            if (al == 20)
            {
                result = "z";
            }
            if (al == 21)
            {
                result = "x";
            }
            if (al == 22)
            {
                result = "c";
            }
            if (al == 23)
            {
                result = "v";
            }
            if (al == 24)
            {
                result = "b";
            }
            if (al == 25)
            {
                result = "n";
            }
            if (al == 26)
            {
                result = "m";
            }
            if (al == 27)
            {
                result = "!";
            }
            if (al == 28)
            {
                result = "@";
            }
            if (al == 29)
            {
                result = "%";
            }
            if (al == 30)
            {
                result = "#";
            }
            if (al == 31)
            {
                result = "(";
            }
            if (al == 32)
            {
                result = ")";
            }
            if (al == 33)
            {
                result = "$";
            }
            if (al == 34)
            {
                result = ".";
            }
            if (al == 35)
            {
                result = "*";
            }
            if (al == 36)
            {
                result = "Q";
            }
            if (al == 37)
            {
                result = "W";
            }
            if (al == 38)
            {
                result = "E";
            }
            if (al == 39)
            {
                result = "R";
            }
            if (al == 40)
            {
                result = "T";
            }
            if (al == 41)
            {
                result = "Y";
            }
            if (al == 42)
            {
                result = "U";
            }
            if (al == 43)
            {
                result = "I";
            }
            if (al == 44)
            {
                result = "O";
            }
            if (al == 45)
            {
                result = "P";
            }
            if (al == 46)
            {
                result = "A";
            }
            if (al == 47)
            {
                result = "S";
            }
            if (al == 48)
            {
                result = "D";
            }
            if (al == 49)
            {
                result = "F";
            }
            if (al == 50)
            {
                result = "G";
            }
            if (al == 51)
            {
                result = "H";
            }
            if (al == 52)
            {
                result = "J";
            }
            if (al == 53)
            {
                result = "K";
            }
            if (al == 54)
            {
                result = "L";
            }
            if (al == 55)
            {
                result = "Z";
            }
            if (al == 56)
            {
                result = "X";
            }
            if (al ==57)
            {
                result = "C";
            }
            if (al == 58)
            {
                result = "V";
            }
            if (al == 59)
            {
                result = "B";
            }
            if (al == 60)
            {
                result = "N";
            }
            if (al == 61)
            {
                result = "M";
            }
            if (al == 62)
            {
                result = "ó";
            }
            if (al == 63)
            {
                result = "ę";
            }
            if (al == 64)
            {
                result = "ą";
            }
            if (al == 65)
            {
                result = "ś";
            }
            if (al == 66)
            {
                result = "ł";
            }
            if (al == 67)
            {
                result = "ż";
            }
            if (al == 68)
            {
                result = "ź";
            }
            if (al == 69)
            {
                result = "ć";
            }
            if (al == 70)
            {
                result = "ń";
            }
            if (al == 71)
            {
                result = "Ę";
            }
            if (al == 72)
            {
                result = "Ó";
            }
            if (al == 73)
            {
                result = "Ą";
            }
            if (al == 74)
            {
                result ="Ś";
            }
            if (al == 75)
            {
                result = "Ł";
            }
            if (al == 76)
            {
                result = "Ż";
            }
            if (al == 77)
            {
                result = "Ź";
            }
            if (al == 78)
            {
                result = "Ć";
            }
            if (al == 79)
            {
                result = "Ń";
            }
            if (al == 80)
            {
                result = "0";
            }
            if (al == 81)
            {
                result = "1";
            }
            if (al == 82)
            {
                result = "2";
            }
            if (al == 83)
            {
                result = "3";
            }
            if (al == 84)
            {
                result = "4";
            }
            if (al == 85)
            {
                result = "5";
            }
            if (al == 86)
            {
                result = "6";
            }
            if (al == 87)
            {
                result = "7";
            }
            if (al == 88)
            {
                result = "8";
            }
            if (al == 89)
            {
                result = "9";
            }
            return result;
        }


        private void button22_Click(object sender, EventArgs e)
        {
            if (kodowanie == true)
            {
                kodowanie = false;
                button22.Text = "DEKODOWANIE";
            }
            else
            {
                kodowanie = true;
                button22.Text = "KODOWANIE";
            }
        }

        private void Koders(object sender, EventArgs e)
        {
            Button a = (Button)sender;
           label3.Text = a.Text;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            kodowanie = true;
            button22.Text = "KODOWANIE";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (kodowanie == true)
            {
                string result = "";
                string podstawa = textBox1.Text;
                string[] resulttab = new string[podstawa.Length];
                string[] tablicapod = new string[podstawa.Length];
                int[] tablicawartości = new int[podstawa.Length];
                for (int i = 0; i < tablicapod.Length; i++)
                {
                    tablicapod[i] = podstawa[podstawa.Length - (i + 1)].ToString();
                    string kodowany = tablicapod[i];
                    int kodowana = Kodowanie1(kodowany);//przypisanie znaku do liczby
                    tablicawartości[i] = kodowana;//przypisanie odpowiednika do tablicy
                    if (label3.Text == "")
                    {
                        textBox2.Text = "Najpierw wybierz kod";
                    }
                    if (label3.Text == "Z1")
                    {
                            tablicawartości[i] += 10;
                        if (tablicawartości[i] >= 90)
                        {
                            tablicawartości[i] -= 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "Z2")
                    {

                        tablicawartości[i] += 8;
                        if (tablicawartości[i] >= 90)
                        {
                            tablicawartości[i] -= 90;
                        }

                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "Z3")
                    {
                        tablicawartości[i] += 5;
                        if (tablicawartości[i] >= 90)
                        {
                            tablicawartości[i] -= 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "Z4")
                    {
                        tablicawartości[i] += 6;
                        if (tablicawartości[i] >= 90)
                        {
                            tablicawartości[i] -= 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "Z5")
                    {

                        tablicawartości[i] += 7;
                        if (tablicawartości[i] >= 90)
                        {
                            tablicawartości[i] -= 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "X1")
                    {
                        tablicawartości[i] += 9;
                        if (tablicawartości[i] >= 90)
                        {
                            tablicawartości[i] -= 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "X2")
                    {

                        tablicawartości[i] += 4;
                        if (tablicawartości[i] >= 90)
                        {
                            tablicawartości[i] -= 90;
                        }

                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "X3")
                    {
                        tablicawartości[i] += 3;
                        if (tablicawartości[i] >= 90)
                        {
                            tablicawartości[i] -= 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "X4")
                    {
                        tablicawartości[i] += 2;
                        if (tablicawartości[i] >= 90)
                        {
                            tablicawartości[i] -= 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "X5")
                    {

                        tablicawartości[i] += 1;
                        if (tablicawartości[i] >= 90)
                        {
                            tablicawartości[i] -= 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "H1")
                    {
                        tablicawartości[i] += 11;
                        if (tablicawartości[i] >= 90)
                        {
                            tablicawartości[i] -= 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "H2")
                    {

                        tablicawartości[i] += 15;
                        if (tablicawartości[i] >= 90)
                        {
                            tablicawartości[i] -= 90;
                        }

                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "H3")
                    {
                        tablicawartości[i] += 12;
                        if (tablicawartości[i] >= 90)
                        {
                            tablicawartości[i] -= 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "H4")
                    {
                        tablicawartości[i] += 14;
                        if (tablicawartości[i] >= 90)
                        {
                            tablicawartości[i] -= 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "H5")
                    {

                        tablicawartości[i] += 13;
                        if (tablicawartości[i] >= 90)
                        {
                            tablicawartości[i] -= 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "PO")
                    {
                        tablicawartości[i] -= 10;
                        if (tablicawartości[i] <= 0)
                        {
                            tablicawartości[i] += 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "PC")
                    {
                        tablicawartości[i] -= 8;
                        if (tablicawartości[i] <= 0)
                        {
                            tablicawartości[i] += 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "PK")
                    {
                        tablicawartości[i] -= 5;
                        if (tablicawartości[i] <= 0)
                        {
                            tablicawartości[i] += 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "PG")
                    {
                        tablicawartości[i] -= 6;
                        if (tablicawartości[i] <= 0)
                        {
                            tablicawartości[i] += 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "PZ")
                    {
                        tablicawartości[i] -= 7;
                        if (tablicawartości[i] <= 0)
                        {
                            tablicawartości[i] += 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                }
                for (int i = resulttab.Length - 1; i >= 0; i--)
                {
                    result += resulttab[i];
                }
                textBox2.Text = result;
            }
            if(kodowanie == false)
            {
                string result = "";
                string podstawa = textBox1.Text;
                string[] resulttab = new string[podstawa.Length];
                string[] tablicapod = new string[podstawa.Length];
                int[] tablicawartości = new int[podstawa.Length];
                for(int i =0;i< podstawa.Length; i++)
                {
                    tablicapod[i] = podstawa[podstawa.Length - (i + 1)].ToString();
                    string kodowany = tablicapod[i];
                    int kodowana = Kodowanie1(kodowany);//przypisanie znaku do liczby
                    tablicawartości[i] = kodowana;
                    if (label3.Text == "")
                    {
                        textBox2.Text = "Najpierw wybierz kod";
                    }
                    if (label3.Text == "Z1")
                    {
                        tablicawartości[i] -= 10;
                        if (tablicawartości[i] <= 0)
                        {
                            tablicawartości[i] += 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "Z2")
                    {
                        tablicawartości[i] -= 8;
                        if (tablicawartości[i] <= 0)
                        {
                            tablicawartości[i] += 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "Z3")
                    {
                        tablicawartości[i] -= 5;
                        if (tablicawartości[i] <= 0)
                        {
                            tablicawartości[i] += 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "Z4")
                    {
                        tablicawartości[i] -= 6;
                        if (tablicawartości[i] <= 0)
                        {
                            tablicawartości[i] += 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "Z5")
                    {
                        tablicawartości[i] -= 7;
                        if (tablicawartości[i] <= 0)
                        {
                            tablicawartości[i] += 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "X1")
                    {
                        tablicawartości[i] -= 9;
                        if (tablicawartości[i] <= 0)
                        {
                            tablicawartości[i] += 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "X2")
                    {
                        tablicawartości[i] -= 4;
                        if (tablicawartości[i] <= 0)
                        {
                            tablicawartości[i] += 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "X3")
                    {
                        tablicawartości[i] -= 3;
                        if (tablicawartości[i] <= 0)
                        {
                            tablicawartości[i] += 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "X4")
                    {
                        tablicawartości[i] -= 2;
                        if (tablicawartości[i] <= 0)
                        {
                            tablicawartości[i] += 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "X5")
                    {
                        tablicawartości[i] -= 1;
                        if (tablicawartości[i] <= 0)
                        {
                            tablicawartości[i] += 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "H1")
                    {
                        tablicawartości[i] -= 11;
                        if (tablicawartości[i] <= 0)
                        {
                            tablicawartości[i] += 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "H2")
                    {
                        tablicawartości[i] -= 15;
                        if (tablicawartości[i] <= 0)
                        {
                            tablicawartości[i] += 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "H3")
                    {
                        tablicawartości[i] -= 12;
                        if (tablicawartości[i] <= 0)
                        {
                            tablicawartości[i] += 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "H4")
                    {
                        tablicawartości[i] -= 14;
                        if (tablicawartości[i] <= 0)
                        {
                            tablicawartości[i] += 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "H5")
                    {
                        tablicawartości[i] -= 13;
                        if (tablicawartości[i] <= 0)
                        {
                            tablicawartości[i] += 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "PO")
                    {
                        tablicawartości[i] += 10;
                        if (tablicawartości[i] >= 90)
                        {
                            tablicawartości[i] -= 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "PC")
                    {

                        tablicawartości[i] += 8;
                        if (tablicawartości[i] >= 90)
                        {
                            tablicawartości[i] -= 90;
                        }

                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "PK")
                    {
                        tablicawartości[i] += 5;
                        if (tablicawartości[i] >= 90)
                        {
                            tablicawartości[i] -= 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "PG")
                    {
                        tablicawartości[i] += 6;
                        if (tablicawartości[i] >= 90)
                        {
                            tablicawartości[i] -= 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                    if (label3.Text == "PZ")
                    {

                        tablicawartości[i] += 7;
                        if (tablicawartości[i] >= 90)
                        {
                            tablicawartości[i] -= 90;
                        }
                        resulttab[i] = Kodowanie2(tablicawartości[i]);
                    }
                }
                    for(int i = podstawa.Length-1; i >= 0; i--)
                    {
                    result += resulttab[i];
                    }
                textBox2.Text = result;
            }
        }
    }
}
