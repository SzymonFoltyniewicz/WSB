using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kółko_i_krzyżyk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region ZmienneGlobalne
        int click = 0;
        string gracz = "X";
        int botzm = 0;
        string bot;
        bool win = false;
        bool boton = false;
        #endregion

        #region PrzyciskBota
        private void button10_Click(object sender, EventArgs e)
        {
            if (botzm == 0)
            {
                botzm = 1;
                button10.Text = "Wyłącz bota";
            }
            else if (botzm == 1)
            {
                botzm = 0;
                button10.Text = "Włącz bota";
            }
            if (botzm == 1)
            {
                label3.Text = "Grasz jako";
                label4.Text = gracz;
            }
            if (botzm == 0)
            {
                label3.Text = "";
                label4.Text = "";
            }

        }
        #endregion

        #region Zakończ
        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Reset
        private void button11_Click(object sender, EventArgs e)
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            if (botzm == 1)
            {
                label3.Text = "Grasz jako";
                label4.Text = gracz;
            }
            if (botzm == 0)
            {
                label3.Text = "";
                label4.Text = "";
            }
            win = false;
            click = 0;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
        }

        #endregion

        #region LogikaGry
        private void button1_Click(object sender, EventArgs e)
        {
            #region ruch
            if (button1.Text == "" && win == false)
            {
                button1.Text = gracz;
                click++;
                boton = true;
            }
            #endregion
            #region win
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }

            #endregion
            if (boton == true)
            {
                #region bot
                if (win == false)
                {
                    if (botzm == 1 && click < 5)
                    {
                        bool ruch = true;
                        if (gracz == "X")
                        {
                            bot = "O";
                        }
                        else if (gracz == "O")
                        {
                            bot = "X";
                        }
                        //botofensywa
                        #region 1
                        if (button1.Text == bot && button3.Text == bot && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button3.Text == bot && button2.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == bot && button2.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button1.Text == bot && button5.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button1.Text == bot && button9.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button5.Text == bot && button9.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == bot && button4.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button1.Text == bot && button7.Text == bot && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button7.Text == bot && button4.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        #endregion
                        #region 2 i 3
                        else if (button5.Text == bot && button2.Text == bot && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        else if (button8.Text == bot && button5.Text == bot && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button2.Text == bot && button8.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button3.Text == bot && button9.Text == bot && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button3.Text == bot && button6.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button9.Text == bot && button6.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == bot && button5.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button5.Text == bot && button7.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == bot && button7.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        #endregion
                        #region 456789
                        else if (button4.Text == bot && button5.Text == bot && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button5.Text == bot && button6.Text == bot && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button4.Text == bot && button6.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button7.Text == bot && button8.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button8.Text == bot && button9.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button7.Text == bot && button9.Text == bot && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        #endregion

                        //botdefensywa
                        #region 1
                        else if (button1.Text == gracz && button3.Text == gracz && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button3.Text == gracz && button2.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == gracz && button2.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button1.Text == gracz && button5.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button1.Text == gracz && button9.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button5.Text == gracz && button9.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == gracz && button4.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button1.Text == gracz && button7.Text == gracz && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button7.Text == gracz && button4.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        #endregion
                        #region 2 i 3
                        else if (button5.Text == gracz && button2.Text == gracz && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        else if (button8.Text == gracz && button5.Text == gracz && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button2.Text == gracz && button8.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button3.Text == gracz && button9.Text == gracz && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button3.Text == gracz && button6.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button9.Text == gracz && button6.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == gracz && button5.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button5.Text == gracz && button7.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == gracz && button7.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        #endregion
                        #region 456789
                        else if (button4.Text == gracz && button5.Text == gracz && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button5.Text == gracz && button6.Text == gracz && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button4.Text == gracz && button6.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button7.Text == gracz && button8.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button8.Text == gracz && button9.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button7.Text == gracz && button9.Text == gracz && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        #endregion


                        #region reszta
                        else
                        {
                            while (ruch == true)
                            {
                                Random x = new Random();
                                int d = x.Next(1, 9);
                                if (d == 1 && button1.Text == "")
                                {
                                    button1.Text = bot;
                                    ruch = false;
                                }
                                if (d == 2 && button2.Text == "")
                                {
                                    button2.Text = bot;
                                    ruch = false;
                                }
                                if (d == 3 && button3.Text == "")
                                {
                                    button3.Text = bot;
                                    ruch = false;
                                }
                                if (d == 4 && button4.Text == "")
                                {
                                    button4.Text = bot;
                                    ruch = false;
                                }
                                if (d == 5 && button5.Text == "")
                                {
                                    button5.Text = bot;
                                    ruch = false;
                                }
                                if (d == 6 && button6.Text == "")
                                {
                                    button6.Text = bot;
                                    ruch = false;
                                }
                                if (d == 7 && button7.Text == "")
                                {
                                    button7.Text = bot;
                                    ruch = false;
                                }
                                if (d == 8 && button8.Text == "")
                                {
                                    button8.Text = bot;
                                    ruch = false;
                                }
                                if (d == 9 && button9.Text == "")
                                {
                                    button9.Text = bot;
                                    ruch = false;
                                }
                            }
                        }
                        #endregion
                    }
                    #region zmianagracza
                    if (gracz == "X" && botzm == 0)
                    {
                        gracz = "O";
                    }
                    else if (gracz == "O" && botzm == 0)
                    {
                        gracz = "X";
                    }
                    #endregion
                }
                #endregion
                boton = false;
            }
            #region win2
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }

            #endregion
            #region remis
            if (win == false && click == 9 && botzm == 0)
                {
                    label3.Text = "Remis";
                    label4.Text = "";
                    win = true;
                }
                else if (win == false && click == 5 && botzm == 1)
                {
                    label3.Text = "Remis";
                    label4.Text = "";
                    win = true;
                }
                #endregion
            label2.Text = gracz;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region ruch
            if (button2.Text == "" && win == false)
            {
                button2.Text = gracz;
                click++;
                boton = true;
            }
            #endregion
            #region win
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            #endregion
            if (boton == true)
            {
                #region bot
                if (win == false)
                {

                    if (botzm == 1 && click < 5)
                    {
                        bool ruch = true;
                        if (gracz == "X")
                        {
                            bot = "O";
                        }
                        else if (gracz == "O")
                        {
                            bot = "X";
                        }
                        //botofensywa
                        #region 1
                        if (button1.Text == bot && button3.Text == bot && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button3.Text == bot && button2.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == bot && button2.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button1.Text == bot && button5.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button1.Text == bot && button9.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button5.Text == bot && button9.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == bot && button4.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button1.Text == bot && button7.Text == bot && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button7.Text == bot && button4.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        #endregion
                        #region 2 i 3
                        else if (button5.Text == bot && button2.Text == bot && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        else if (button8.Text == bot && button5.Text == bot && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button2.Text == bot && button8.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button3.Text == bot && button9.Text == bot && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button3.Text == bot && button6.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button9.Text == bot && button6.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == bot && button5.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button5.Text == bot && button7.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == bot && button7.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        #endregion
                        #region 456789
                        else if (button4.Text == bot && button5.Text == bot && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button5.Text == bot && button6.Text == bot && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button4.Text == bot && button6.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button7.Text == bot && button8.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button8.Text == bot && button9.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button7.Text == bot && button9.Text == bot && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        #endregion

                        //botdefensywa

                        #region 1
                        else if (button1.Text == gracz && button3.Text == gracz && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button3.Text == gracz && button2.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == gracz && button2.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button1.Text == gracz && button5.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button1.Text == gracz && button9.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button5.Text == gracz && button9.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == gracz && button4.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button1.Text == gracz && button7.Text == gracz && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button7.Text == gracz && button4.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        #endregion
                        #region 2 i 3
                        else if (button5.Text == gracz && button2.Text == gracz && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        else if (button8.Text == gracz && button5.Text == gracz && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button2.Text == gracz && button8.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button3.Text == gracz && button9.Text == gracz && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button3.Text == gracz && button6.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button9.Text == gracz && button6.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == gracz && button5.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button5.Text == gracz && button7.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == gracz && button7.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        #endregion
                        #region 456789
                        else if (button4.Text == gracz && button5.Text == gracz && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button5.Text == gracz && button6.Text == gracz && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button4.Text == gracz && button6.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button7.Text == gracz && button8.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button8.Text == gracz && button9.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button7.Text == gracz && button9.Text == gracz && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        #endregion

                        #region reszta
                        else
                        {
                            while (ruch == true)
                            {
                                Random x = new Random();
                                int d = x.Next(1, 9);
                                if (d == 1 && button1.Text == "")
                                {
                                    button1.Text = bot;
                                    ruch = false;
                                }
                                if (d == 2 && button2.Text == "")
                                {
                                    button2.Text = bot;
                                    ruch = false;
                                }
                                if (d == 3 && button3.Text == "")
                                {
                                    button3.Text = bot;
                                    ruch = false;
                                }
                                if (d == 4 && button4.Text == "")
                                {
                                    button4.Text = bot;
                                    ruch = false;
                                }
                                if (d == 5 && button5.Text == "")
                                {
                                    button5.Text = bot;
                                    ruch = false;
                                }
                                if (d == 6 && button6.Text == "")
                                {
                                    button6.Text = bot;
                                    ruch = false;
                                }
                                if (d == 7 && button7.Text == "")
                                {
                                    button7.Text = bot;
                                    ruch = false;
                                }
                                if (d == 8 && button8.Text == "")
                                {
                                    button8.Text = bot;
                                    ruch = false;
                                }
                                if (d == 9 && button9.Text == "")
                                {
                                    button9.Text = bot;
                                    ruch = false;
                                }
                            }
                        }
                        #endregion
                    }
                    #region zmianagracza
                    if (gracz == "X" && botzm == 0)
                    {
                        gracz = "O";
                    }
                    else if (gracz == "O" && botzm == 0)
                    {
                        gracz = "X";
                    }
                    #endregion
                }
                #endregion
                boton = false;
            }
            #region win2
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }

            #endregion
            #region remis
            if (win == false && click == 9)
            {
                label3.Text = "Remis";
                label4.Text = "";
                win = true;
            }
            else if (win == false && click == 5 && botzm == 1)
            {
                label3.Text = "Remis";
                label4.Text = "";
                win = true;
            }
            #endregion
            label2.Text = gracz;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region ruch
            if (button3.Text == "" && win == false)
            {
                button3.Text = gracz;
                click++;
                boton = true;
            }
            #endregion
            #region win
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            #endregion
            if (boton == true)
            {
                #region bot
                if (win == false)
                {
                    if (botzm == 1 && click < 5)
                    {
                        bool ruch = true;
                        if (gracz == "X")
                        {
                            bot = "O";
                        }
                        else if (gracz == "O")
                        {
                            bot = "X";
                        }

                        //botofensywa

                        #region 1
                        if (button1.Text == bot && button3.Text == bot && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button3.Text == bot && button2.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == bot && button2.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button1.Text == bot && button5.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button1.Text == bot && button9.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button5.Text == bot && button9.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == bot && button4.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button1.Text == bot && button7.Text == bot && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button7.Text == bot && button4.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        #endregion
                        #region 2 i 3
                        else if (button5.Text == bot && button2.Text == bot && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        else if (button8.Text == bot && button5.Text == bot && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button2.Text == bot && button8.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button3.Text == bot && button9.Text == bot && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button3.Text == bot && button6.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button9.Text == bot && button6.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == bot && button5.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button5.Text == bot && button7.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == bot && button7.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        #endregion
                        #region 456789
                        else if (button4.Text == bot && button5.Text == bot && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button5.Text == bot && button6.Text == bot && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button4.Text == bot && button6.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button7.Text == bot && button8.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button8.Text == bot && button9.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button7.Text == bot && button9.Text == bot && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        #endregion

                        //botdefensywa
                        #region 1
                        else if (button1.Text == gracz && button3.Text == gracz && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button3.Text == gracz && button2.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == gracz && button2.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button1.Text == gracz && button5.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button1.Text == gracz && button9.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button5.Text == gracz && button9.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == gracz && button4.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button1.Text == gracz && button7.Text == gracz && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button7.Text == gracz && button4.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        #endregion
                        #region 2 i 3
                        else if (button5.Text == gracz && button2.Text == gracz && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        else if (button8.Text == gracz && button5.Text == gracz && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button2.Text == gracz && button8.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button3.Text == gracz && button9.Text == gracz && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button3.Text == gracz && button6.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button9.Text == gracz && button6.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == gracz && button5.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button5.Text == gracz && button7.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == gracz && button7.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        #endregion
                        #region 456789
                        else if (button4.Text == gracz && button5.Text == gracz && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button5.Text == gracz && button6.Text == gracz && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button4.Text == gracz && button6.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button7.Text == gracz && button8.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button8.Text == gracz && button9.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button7.Text == gracz && button9.Text == gracz && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        #endregion

                        #region reszta
                        else
                        {
                            while (ruch == true)
                            {
                                Random x = new Random();
                                int d = x.Next(1, 9);
                                if (d == 1 && button1.Text == "")
                                {
                                    button1.Text = bot;
                                    ruch = false;
                                }
                                if (d == 2 && button2.Text == "")
                                {
                                    button2.Text = bot;
                                    ruch = false;
                                }
                                if (d == 3 && button3.Text == "")
                                {
                                    button3.Text = bot;
                                    ruch = false;
                                }
                                if (d == 4 && button4.Text == "")
                                {
                                    button4.Text = bot;
                                    ruch = false;
                                }
                                if (d == 5 && button5.Text == "")
                                {
                                    button5.Text = bot;
                                    ruch = false;
                                }
                                if (d == 6 && button6.Text == "")
                                {
                                    button6.Text = bot;
                                    ruch = false;
                                }
                                if (d == 7 && button7.Text == "")
                                {
                                    button7.Text = bot;
                                    ruch = false;
                                }
                                if (d == 8 && button8.Text == "")
                                {
                                    button8.Text = bot;
                                    ruch = false;
                                }
                                if (d == 9 && button9.Text == "")
                                {
                                    button9.Text = bot;
                                    ruch = false;
                                }
                            }
                        }
                        #endregion
                    }
                    #region zmianagracza
                    if (gracz == "X" && botzm == 0)
                    {
                        gracz = "O";
                    }
                    else if (gracz == "O" && botzm == 0)
                    {
                        gracz = "X";
                    }
                    #endregion
                }
                #endregion
                boton = false;
            }
            #region win2
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }

            #endregion
            #region remis
            if (win == false && click == 9)
            {
                label3.Text = "Remis";
                label4.Text = "";
                win = true;
            }
            else if (win == false && click == 5 && botzm == 1)
            {
                label3.Text = "Remis";
                label4.Text = "";
                win = true;
            }
            #endregion
            label2.Text = gracz;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            #region ruch
            if (button4.Text == "" && win == false)
            {
                button4.Text = gracz;
                click++;
                boton = true;
            }
            #endregion
            #region win
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            #endregion
            if (boton == true)
            {
                #region bot
                if (win == false)
                {
                    if (botzm == 1 && click < 5)
                    {
                        bool ruch = true;
                        if (gracz == "X")
                        {
                            bot = "O";
                        }
                        else if (gracz == "O")
                        {
                            bot = "X";
                        }
                        //botofensywa

                        #region 1
                        if (button1.Text == bot && button3.Text == bot && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button3.Text == bot && button2.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == bot && button2.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button1.Text == bot && button5.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button1.Text == bot && button9.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button5.Text == bot && button9.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == bot && button4.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button1.Text == bot && button7.Text == bot && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button7.Text == bot && button4.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        #endregion
                        #region 2 i 3
                        else if (button5.Text == bot && button2.Text == bot && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        else if (button8.Text == bot && button5.Text == bot && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button2.Text == bot && button8.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button3.Text == bot && button9.Text == bot && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button3.Text == bot && button6.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button9.Text == bot && button6.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == bot && button5.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button5.Text == bot && button7.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == bot && button7.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        #endregion
                        #region 456789
                        else if (button4.Text == bot && button5.Text == bot && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button5.Text == bot && button6.Text == bot && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button4.Text == bot && button6.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button7.Text == bot && button8.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button8.Text == bot && button9.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button7.Text == bot && button9.Text == bot && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        #endregion

                        //botdefensywa

                        #region 1
                        else if (button1.Text == gracz && button3.Text == gracz && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button3.Text == gracz && button2.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == gracz && button2.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button1.Text == gracz && button5.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button1.Text == gracz && button9.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button5.Text == gracz && button9.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == gracz && button4.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button1.Text == gracz && button7.Text == gracz && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button7.Text == gracz && button4.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        #endregion
                        #region 2 i 3
                        else if (button5.Text == gracz && button2.Text == gracz && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        else if (button8.Text == gracz && button5.Text == gracz && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button2.Text == gracz && button8.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button3.Text == gracz && button9.Text == gracz && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button3.Text == gracz && button6.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button9.Text == gracz && button6.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == gracz && button5.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button5.Text == gracz && button7.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == gracz && button7.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        #endregion
                        #region 456789
                        else if (button4.Text == gracz && button5.Text == gracz && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button5.Text == gracz && button6.Text == gracz && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button4.Text == gracz && button6.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button7.Text == gracz && button8.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button8.Text == gracz && button9.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button7.Text == gracz && button9.Text == gracz && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        #endregion

                        #region reszta
                        else
                        {
                            while (ruch == true)
                            {
                                Random x = new Random();
                                int d = x.Next(1, 9);
                                if (d == 1 && button1.Text == "")
                                {
                                    button1.Text = bot;
                                    ruch = false;
                                }
                                if (d == 2 && button2.Text == "")
                                {
                                    button2.Text = bot;
                                    ruch = false;
                                }
                                if (d == 3 && button3.Text == "")
                                {
                                    button3.Text = bot;
                                    ruch = false;
                                }
                                if (d == 4 && button4.Text == "")
                                {
                                    button4.Text = bot;
                                    ruch = false;
                                }
                                if (d == 5 && button5.Text == "")
                                {
                                    button5.Text = bot;
                                    ruch = false;
                                }
                                if (d == 6 && button6.Text == "")
                                {
                                    button6.Text = bot;
                                    ruch = false;
                                }
                                if (d == 7 && button7.Text == "")
                                {
                                    button7.Text = bot;
                                    ruch = false;
                                }
                                if (d == 8 && button8.Text == "")
                                {
                                    button8.Text = bot;
                                    ruch = false;
                                }
                                if (d == 9 && button9.Text == "")
                                {
                                    button9.Text = bot;
                                    ruch = false;
                                }
                            }
                        }
                        #endregion
                    }
                    #region zmianagracza
                    if (gracz == "X" && botzm == 0)
                    {
                        gracz = "O";
                    }
                    else if (gracz == "O" && botzm == 0)
                    {
                        gracz = "X";
                    }
                    #endregion
                }
                #endregion
                boton = false;
            }
            #region win2
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }

            #endregion
            #region remis
            if (win == false && click == 9)
            {
                label3.Text = "Remis";
                label4.Text = "";
                win = true;
            }
            else if (win == false && click == 5 && botzm == 1)
            {
                label3.Text = "Remis";
                label4.Text = "";
                win = true;
            }
            #endregion
            label2.Text = gracz;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            #region ruch
            if (button5.Text == "" && win == false)
            {
                button5.Text = gracz;
                click++;
                boton = true;
            }
            #endregion
            #region win
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            #endregion
            if (boton == true)
            {
                #region bot
                if (win == false)
                {
                    if (botzm == 1 && click < 5)
                    {
                        bool ruch = true;
                        if (gracz == "X")
                        {
                            bot = "O";
                        }
                        else if (gracz == "O")
                        {
                            bot = "X";
                        }
                        //botofensywa
                        #region 1
                        if (button1.Text == bot && button3.Text == bot && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button3.Text == bot && button2.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == bot && button2.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button1.Text == bot && button5.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button1.Text == bot && button9.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button5.Text == bot && button9.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == bot && button4.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button1.Text == bot && button7.Text == bot && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button7.Text == bot && button4.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        #endregion
                        #region 2 i 3
                        else if (button5.Text == bot && button2.Text == bot && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        else if (button8.Text == bot && button5.Text == bot && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button2.Text == bot && button8.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button3.Text == bot && button9.Text == bot && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button3.Text == bot && button6.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button9.Text == bot && button6.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == bot && button5.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button5.Text == bot && button7.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == bot && button7.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        #endregion
                        #region 456789
                        else if (button4.Text == bot && button5.Text == bot && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button5.Text == bot && button6.Text == bot && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button4.Text == bot && button6.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button7.Text == bot && button8.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button8.Text == bot && button9.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button7.Text == bot && button9.Text == bot && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        #endregion
                        //botdefensywa
                        #region 1
                        else if (button1.Text == gracz && button3.Text == gracz && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button3.Text == gracz && button2.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == gracz && button2.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button1.Text == gracz && button5.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button1.Text == gracz && button9.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button5.Text == gracz && button9.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == gracz && button4.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button1.Text == gracz && button7.Text == gracz && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button7.Text == gracz && button4.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        #endregion
                        #region 2 i 3
                        else if (button5.Text == gracz && button2.Text == gracz && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        else if (button8.Text == gracz && button5.Text == gracz && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button2.Text == gracz && button8.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button3.Text == gracz && button9.Text == gracz && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button3.Text == gracz && button6.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button9.Text == gracz && button6.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == gracz && button5.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button5.Text == gracz && button7.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == gracz && button7.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        #endregion
                        #region 456789
                        else if (button4.Text == gracz && button5.Text == gracz && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button5.Text == gracz && button6.Text == gracz && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button4.Text == gracz && button6.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button7.Text == gracz && button8.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button8.Text == gracz && button9.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button7.Text == gracz && button9.Text == gracz && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        #endregion
                        #region reszta
                        else
                        {
                            while (ruch == true)
                            {
                                Random x = new Random();
                                int d = x.Next(1, 9);
                                if (d == 1 && button1.Text == "")
                                {
                                    button1.Text = bot;
                                    ruch = false;
                                }
                                if (d == 2 && button2.Text == "")
                                {
                                    button2.Text = bot;
                                    ruch = false;
                                }
                                if (d == 3 && button3.Text == "")
                                {
                                    button3.Text = bot;
                                    ruch = false;
                                }
                                if (d == 4 && button4.Text == "")
                                {
                                    button4.Text = bot;
                                    ruch = false;
                                }
                                if (d == 5 && button5.Text == "")
                                {
                                    button5.Text = bot;
                                    ruch = false;
                                }
                                if (d == 6 && button6.Text == "")
                                {
                                    button6.Text = bot;
                                    ruch = false;
                                }
                                if (d == 7 && button7.Text == "")
                                {
                                    button7.Text = bot;
                                    ruch = false;
                                }
                                if (d == 8 && button8.Text == "")
                                {
                                    button8.Text = bot;
                                    ruch = false;
                                }
                                if (d == 9 && button9.Text == "")
                                {
                                    button9.Text = bot;
                                    ruch = false;
                                }
                            }
                        }
                        #endregion
                    }
                    #region zmianagracza
                    if (gracz == "X" && botzm == 0)
                    {
                        gracz = "O";
                    }
                    else if (gracz == "O" && botzm == 0)
                    {
                        gracz = "X";
                    }
                    #endregion
                }
                #endregion
                boton = false;
            }
            #region win2
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }

            #endregion
            #region remis
            if (win == false && click == 9)
            {
                label3.Text = "Remis";
                label4.Text = "";
                win = true;
            }
            else if (win == false && click == 5 && botzm == 1)
            {
                label3.Text = "Remis";
                label4.Text = "";
                win = true;
            }
            #endregion
            label2.Text = gracz;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            #region ruch
            if (button6.Text == "" && win == false)
            {
                button6.Text = gracz;
                click++;
                boton = true;
            }
            #endregion
            #region win
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            #endregion
            if (boton == true)
            {
                #region bot
                if (win == false)
                {
                    if (botzm == 1 && click < 5)
                    {
                        bool ruch = true;
                        if (gracz == "X")
                        {
                            bot = "O";
                        }
                        else if (gracz == "O")
                        {
                            bot = "X";
                        }
                        //botofensywa
                        #region 1
                        if (button1.Text == bot && button3.Text == bot && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button3.Text == bot && button2.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == bot && button2.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button1.Text == bot && button5.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button1.Text == bot && button9.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button5.Text == bot && button9.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == bot && button4.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button1.Text == bot && button7.Text == bot && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button7.Text == bot && button4.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        #endregion
                        #region 2 i 3
                        else if (button5.Text == bot && button2.Text == bot && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        else if (button8.Text == bot && button5.Text == bot && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button2.Text == bot && button8.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button3.Text == bot && button9.Text == bot && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button3.Text == bot && button6.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button9.Text == bot && button6.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == bot && button5.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button5.Text == bot && button7.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == bot && button7.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        #endregion
                        #region 456789
                        else if (button4.Text == bot && button5.Text == bot && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button5.Text == bot && button6.Text == bot && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button4.Text == bot && button6.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button7.Text == bot && button8.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button8.Text == bot && button9.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button7.Text == bot && button9.Text == bot && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        #endregion
                        //botdefensywa
                        #region 1
                        else if (button1.Text == gracz && button3.Text == gracz && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button3.Text == gracz && button2.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == gracz && button2.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button1.Text == gracz && button5.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button1.Text == gracz && button9.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button5.Text == gracz && button9.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == gracz && button4.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button1.Text == gracz && button7.Text == gracz && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button7.Text == gracz && button4.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        #endregion
                        #region 2 i 3
                        else if (button5.Text == gracz && button2.Text == gracz && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        else if (button8.Text == gracz && button5.Text == gracz && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button2.Text == gracz && button8.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button3.Text == gracz && button9.Text == gracz && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button3.Text == gracz && button6.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button9.Text == gracz && button6.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == gracz && button5.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button5.Text == gracz && button7.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == gracz && button7.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        #endregion
                        #region 456789
                        else if (button4.Text == gracz && button5.Text == gracz && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button5.Text == gracz && button6.Text == gracz && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button4.Text == gracz && button6.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button7.Text == gracz && button8.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button8.Text == gracz && button9.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button7.Text == gracz && button9.Text == gracz && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        #endregion
                        #region reszta
                        else
                        {
                            while (ruch == true)
                            {
                                Random x = new Random();
                                int d = x.Next(1, 9);
                                if (d == 1 && button1.Text == "")
                                {
                                    button1.Text = bot;
                                    ruch = false;
                                }
                                if (d == 2 && button2.Text == "")
                                {
                                    button2.Text = bot;
                                    ruch = false;
                                }
                                if (d == 3 && button3.Text == "")
                                {
                                    button3.Text = bot;
                                    ruch = false;
                                }
                                if (d == 4 && button4.Text == "")
                                {
                                    button4.Text = bot;
                                    ruch = false;
                                }
                                if (d == 5 && button5.Text == "")
                                {
                                    button5.Text = bot;
                                    ruch = false;
                                }
                                if (d == 6 && button6.Text == "")
                                {
                                    button6.Text = bot;
                                    ruch = false;
                                }
                                if (d == 7 && button7.Text == "")
                                {
                                    button7.Text = bot;
                                    ruch = false;
                                }
                                if (d == 8 && button8.Text == "")
                                {
                                    button8.Text = bot;
                                    ruch = false;
                                }
                                if (d == 9 && button9.Text == "")
                                {
                                    button9.Text = bot;
                                    ruch = false;
                                }
                            }
                        }
                        #endregion
                    }
                    #region zmianagracza
                    if (gracz == "X" && botzm == 0)
                    {
                        gracz = "O";
                    }
                    else if (gracz == "O" && botzm == 0)
                    {
                        gracz = "X";
                    }
                    #endregion
                }
                #endregion
                boton = false;
            }
            #region win2
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }

            #endregion
            #region remis
            if (win == false && click == 9)
            {
             label3.Text = "Remis";
             label4.Text = "";
             win = true;
            }
            else if (win == false && click == 5 && botzm == 1)
            {
                label3.Text = "Remis";
                label4.Text = "";
                win = true;
            }
            #endregion
            label2.Text = gracz;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            #region ruch
            if (button7.Text == "" && win == false)
            {
                button7.Text = gracz;
                click++;
                boton = true;
            }
            #endregion
            #region win
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            #endregion
            if (boton == true)
            {
                #region bot
                if (win == false)
                {
                    if (botzm == 1 && click < 5)
                    {
                        bool ruch = true;
                        if (gracz == "X")
                        {
                            bot = "O";
                        }
                        else if (gracz == "O")
                        {
                            bot = "X";
                        }
                        //botofensywa
                        #region 1
                        if (button1.Text == bot && button3.Text == bot && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button3.Text == bot && button2.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == bot && button2.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button1.Text == bot && button5.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button1.Text == bot && button9.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button5.Text == bot && button9.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == bot && button4.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button1.Text == bot && button7.Text == bot && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button7.Text == bot && button4.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        #endregion
                        #region 2 i 3
                        else if (button5.Text == bot && button2.Text == bot && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        else if (button8.Text == bot && button5.Text == bot && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button2.Text == bot && button8.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button3.Text == bot && button9.Text == bot && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button3.Text == bot && button6.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button9.Text == bot && button6.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == bot && button5.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button5.Text == bot && button7.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == bot && button7.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        #endregion
                        #region 456789
                        else if (button4.Text == bot && button5.Text == bot && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button5.Text == bot && button6.Text == bot && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button4.Text == bot && button6.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button7.Text == bot && button8.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button8.Text == bot && button9.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button7.Text == bot && button9.Text == bot && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        #endregion
                        //botdefensywa
                        #region 1
                        else if (button1.Text == gracz && button3.Text == gracz && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button3.Text == gracz && button2.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == gracz && button2.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button1.Text == gracz && button5.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button1.Text == gracz && button9.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button5.Text == gracz && button9.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == gracz && button4.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button1.Text == gracz && button7.Text == gracz && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button7.Text == gracz && button4.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        #endregion
                        #region 2 i 3
                        else if (button5.Text == gracz && button2.Text == gracz && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        else if (button8.Text == gracz && button5.Text == gracz && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button2.Text == gracz && button8.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button3.Text == gracz && button9.Text == gracz && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button3.Text == gracz && button6.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button9.Text == gracz && button6.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == gracz && button5.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button5.Text == gracz && button7.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == gracz && button7.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        #endregion
                        #region 456789
                        else if (button4.Text == gracz && button5.Text == gracz && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button5.Text == gracz && button6.Text == gracz && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button4.Text == gracz && button6.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button7.Text == gracz && button8.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button8.Text == gracz && button9.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button7.Text == gracz && button9.Text == gracz && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        #endregion
                        #region reszta
                        else
                        {
                            while (ruch == true)
                            {
                                Random x = new Random();
                                int d = x.Next(1, 9);
                                if (d == 1 && button1.Text == "")
                                {
                                    button1.Text = bot;
                                    ruch = false;
                                }
                                if (d == 2 && button2.Text == "")
                                {
                                    button2.Text = bot;
                                    ruch = false;
                                }
                                if (d == 3 && button3.Text == "")
                                {
                                    button3.Text = bot;
                                    ruch = false;
                                }
                                if (d == 4 && button4.Text == "")
                                {
                                    button4.Text = bot;
                                    ruch = false;
                                }
                                if (d == 5 && button5.Text == "")
                                {
                                    button5.Text = bot;
                                    ruch = false;
                                }
                                if (d == 6 && button6.Text == "")
                                {
                                    button6.Text = bot;
                                    ruch = false;
                                }
                                if (d == 7 && button7.Text == "")
                                {
                                    button7.Text = bot;
                                    ruch = false;
                                }
                                if (d == 8 && button8.Text == "")
                                {
                                    button8.Text = bot;
                                    ruch = false;
                                }
                                if (d == 9 && button9.Text == "")
                                {
                                    button9.Text = bot;
                                    ruch = false;
                                }
                            }
                        }
                        #endregion
                    }
                    #region zmianagracza
                    if (gracz == "X" && botzm == 0)
                    {
                        gracz = "O";
                    }
                    else if (gracz == "O" && botzm == 0)
                    {
                        gracz = "X";
                    }
                    #endregion
                }
                #endregion
                boton = false;
            }
            #region win2
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }

            #endregion
            #region remis
            if (win == false && click == 9)
            {
                label3.Text = "Remis";
                label4.Text = "";
                win = true;
            }
            else if (win == false && click == 5 && botzm == 1)
            {
                label3.Text = "Remis";
                label4.Text = "";
                win = true;
            }
            #endregion
            label2.Text = gracz;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            #region ruch
            if (button8.Text == "" && win == false)
            {
                button8.Text = gracz;
                click++;
                boton = true;
            }
            #endregion
            #region win
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            #endregion
            if (boton == true)
            {
                #region bot
                if (win == false)
                {
                    if (botzm == 1 && click < 5)
                    {
                        bool ruch = true;
                        if (gracz == "X")
                        {
                            bot = "O";
                        }
                        else if (gracz == "O")
                        {
                            bot = "X";
                        }
                        //botofensywa
                        #region 1
                        if (button1.Text == bot && button3.Text == bot && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button3.Text == bot && button2.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == bot && button2.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button1.Text == bot && button5.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button1.Text == bot && button9.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button5.Text == bot && button9.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == bot && button4.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button1.Text == bot && button7.Text == bot && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button7.Text == bot && button4.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        #endregion
                        #region 2 i 3
                        else if (button5.Text == bot && button2.Text == bot && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        else if (button8.Text == bot && button5.Text == bot && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button2.Text == bot && button8.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button3.Text == bot && button9.Text == bot && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button3.Text == bot && button6.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button9.Text == bot && button6.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == bot && button5.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button5.Text == bot && button7.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == bot && button7.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        #endregion
                        #region 456789
                        else if (button4.Text == bot && button5.Text == bot && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button5.Text == bot && button6.Text == bot && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button4.Text == bot && button6.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button7.Text == bot && button8.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button8.Text == bot && button9.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button7.Text == bot && button9.Text == bot && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        #endregion
                        //botdefensywa
                        #region 1
                        else if (button1.Text == gracz && button3.Text == gracz && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button3.Text == gracz && button2.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == gracz && button2.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button1.Text == gracz && button5.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button1.Text == gracz && button9.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button5.Text == gracz && button9.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == gracz && button4.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button1.Text == gracz && button7.Text == gracz && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button7.Text == gracz && button4.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        #endregion
                        #region 2 i 3
                        else if (button5.Text == gracz && button2.Text == gracz && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        else if (button8.Text == gracz && button5.Text == gracz && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button2.Text == gracz && button8.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button3.Text == gracz && button9.Text == gracz && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button3.Text == gracz && button6.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button9.Text == gracz && button6.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == gracz && button5.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button5.Text == gracz && button7.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == gracz && button7.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        #endregion
                        #region 456789
                        else if (button4.Text == gracz && button5.Text == gracz && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button5.Text == gracz && button6.Text == gracz && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button4.Text == gracz && button6.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button7.Text == gracz && button8.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button8.Text == gracz && button9.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button7.Text == gracz && button9.Text == gracz && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        #endregion
                        #region reszta
                        else
                        {
                            while (ruch == true)
                            {
                                Random x = new Random();
                                int d = x.Next(1, 9);
                                if (d == 1 && button1.Text == "")
                                {
                                    button1.Text = bot;
                                    ruch = false;
                                }
                                if (d == 2 && button2.Text == "")
                                {
                                    button2.Text = bot;
                                    ruch = false;
                                }
                                if (d == 3 && button3.Text == "")
                                {
                                    button3.Text = bot;
                                    ruch = false;
                                }
                                if (d == 4 && button4.Text == "")
                                {
                                    button4.Text = bot;
                                    ruch = false;
                                }
                                if (d == 5 && button5.Text == "")
                                {
                                    button5.Text = bot;
                                    ruch = false;
                                }
                                if (d == 6 && button6.Text == "")
                                {
                                    button6.Text = bot;
                                    ruch = false;
                                }
                                if (d == 7 && button7.Text == "")
                                {
                                    button7.Text = bot;
                                    ruch = false;
                                }
                                if (d == 8 && button8.Text == "")
                                {
                                    button8.Text = bot;
                                    ruch = false;
                                }
                                if (d == 9 && button9.Text == "")
                                {
                                    button9.Text = bot;
                                    ruch = false;
                                }
                            }
                        }
                        #endregion
                    }
                    #region zmianagracza
                    if (gracz == "X" && botzm == 0)
                    {
                        gracz = "O";
                    }
                    else if (gracz == "O" && botzm == 0)
                    {
                        gracz = "X";
                    }
                    #endregion
                }
                #endregion
                boton = false;
            }
            #region win2
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }

            #endregion
            #region remis
            if (win == false && click == 9)
            {
                label3.Text = "Remis";
                label4.Text = "";
                win = true;

            }
            else if (win == false && click == 5 && botzm == 1)
            {
                label3.Text = "Remis";
                label4.Text = "";
                win = true;
            }
            #endregion
            label2.Text = gracz;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            #region ruch
            if (button9.Text == "" && win == false)
            {
                button9.Text = gracz;
                click++;
                boton = true;
            }
            #endregion
            #region win
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            #endregion
            if (boton == true)
            {
                #region bot
                if (win == false)
                {
                    if (botzm == 1 && click < 5)
                    {
                        bool ruch = true;
                        if (gracz == "X")
                        {
                            bot = "O";
                        }
                        else if (gracz == "O")
                        {
                            bot = "X";
                        }
                        //botof
                        #region 1
                        if (button1.Text == bot && button3.Text == bot && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button3.Text == bot && button2.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == bot && button2.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button1.Text == bot && button5.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button1.Text == bot && button9.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button5.Text == bot && button9.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == bot && button4.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button1.Text == bot && button7.Text == bot && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button7.Text == bot && button4.Text == bot && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        #endregion
                        #region 2 i 3
                        else if (button5.Text == bot && button2.Text == bot && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        else if (button8.Text == bot && button5.Text == bot && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button2.Text == bot && button8.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button3.Text == bot && button9.Text == bot && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button3.Text == bot && button6.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button9.Text == bot && button6.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == bot && button5.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button5.Text == bot && button7.Text == bot && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == bot && button7.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        #endregion
                        #region 456789
                        else if (button4.Text == bot && button5.Text == bot && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button5.Text == bot && button6.Text == bot && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button4.Text == bot && button6.Text == bot && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button7.Text == bot && button8.Text == bot && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button8.Text == bot && button9.Text == bot && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button7.Text == bot && button9.Text == bot && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        #endregion
                        //botdef
                        #region 1
                        else if (button1.Text == gracz && button3.Text == gracz && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button3.Text == gracz && button2.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == gracz && button2.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button1.Text == gracz && button5.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button1.Text == gracz && button9.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button5.Text == gracz && button9.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        else if (button1.Text == gracz && button4.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button1.Text == gracz && button7.Text == gracz && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button7.Text == gracz && button4.Text == gracz && button1.Text == "")
                        {
                            button1.Text = bot;
                        }
                        #endregion
                        #region 2 i 3
                        else if (button5.Text == gracz && button2.Text == gracz && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        else if (button8.Text == gracz && button5.Text == gracz && button2.Text == "")
                        {
                            button2.Text = bot;
                        }
                        else if (button2.Text == gracz && button8.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button3.Text == gracz && button9.Text == gracz && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button3.Text == gracz && button6.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button9.Text == gracz && button6.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == gracz && button5.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button5.Text == gracz && button7.Text == gracz && button3.Text == "")
                        {
                            button3.Text = bot;
                        }
                        else if (button3.Text == gracz && button7.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        #endregion
                        #region 456789
                        else if (button4.Text == gracz && button5.Text == gracz && button6.Text == "")
                        {
                            button6.Text = bot;
                        }
                        else if (button5.Text == gracz && button6.Text == gracz && button4.Text == "")
                        {
                            button4.Text = bot;
                        }
                        else if (button4.Text == gracz && button6.Text == gracz && button5.Text == "")
                        {
                            button5.Text = bot;
                        }
                        else if (button7.Text == gracz && button8.Text == gracz && button9.Text == "")
                        {
                            button9.Text = bot;
                        }
                        else if (button8.Text == gracz && button9.Text == gracz && button7.Text == "")
                        {
                            button7.Text = bot;
                        }
                        else if (button7.Text == gracz && button9.Text == gracz && button8.Text == "")
                        {
                            button8.Text = bot;
                        }
                        #endregion
                        #region reszta
                        else
                        {
                            while (ruch == true)
                            {
                                Random x = new Random();
                                int d = x.Next(1, 9);
                                if (d == 1 && button1.Text == "")
                                {
                                    button1.Text = bot;
                                    ruch = false;
                                }
                                if (d == 2 && button2.Text == "")
                                {
                                    button2.Text = bot;
                                    ruch = false;
                                }
                                if (d == 3 && button3.Text == "")
                                {
                                    button3.Text = bot;
                                    ruch = false;
                                }
                                if (d == 4 && button4.Text == "")
                                {
                                    button4.Text = bot;
                                    ruch = false;
                                }
                                if (d == 5 && button5.Text == "")
                                {
                                    button5.Text = bot;
                                    ruch = false;
                                }
                                if (d == 6 && button6.Text == "")
                                {
                                    button6.Text = bot;
                                    ruch = false;
                                }
                                if (d == 7 && button7.Text == "")
                                {
                                    button7.Text = bot;
                                    ruch = false;
                                }
                                if (d == 8 && button8.Text == "")
                                {
                                    button8.Text = bot;
                                    ruch = false;
                                }
                                if (d == 9 && button9.Text == "")
                                {
                                    button9.Text = bot;
                                    ruch = false;
                                }
                            }
                        }
                        #endregion
                    }
                    #region zmianagracza
                    if (gracz == "X" && botzm == 0)
                    {
                        gracz = "O";
                    }
                    else if (gracz == "O" && botzm == 0)
                    {
                        gracz = "X";
                    }
                    #endregion
                }
                #endregion
                boton = false;
            }
            #region win2
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                label3.Text = "Zyciężył X";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button3.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button5.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button1.Text == "O" && button4.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button1.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button5.BackColor = Color.Red;
                button2.BackColor = Color.Red;
                button8.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button7.BackColor = Color.Red;
            }
            if (button3.Text == "O" && button6.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button3.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }
            if (button4.Text == "O" && button5.Text == "O" && button6.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
            }
            if (button7.Text == "O" && button8.Text == "O" && button9.Text == "O")
            {
                label3.Text = "Zyciężył O";
                label4.Text = "";
                win = true;
                button7.BackColor = Color.Red;
                button8.BackColor = Color.Red;
                button9.BackColor = Color.Red;
            }

            #endregion
            #region remis
            if (win == false && click == 9)
            {
                label3.Text = "Remis";
                label4.Text = "";
            }
            else if (win == false && click == 5 && botzm == 1)
            {
                label3.Text = "Remis";
                label4.Text = "";
                win = true;
            }
            #endregion
            label2.Text = gracz;
        }

        #endregion

    }  
}
