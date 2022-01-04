using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {

        Random r = new Random();
        int rInt;
        int pocetX = 0;
        int pocetO = 0;
        int vyhryX;
        int vyhryO;
        int celkemX = 0;
        int celkemO = 0;
        int yminus = 0;
        int yminusTwo = 0;

        bool hra = true;
        


        public Form1()
        {
            InitializeComponent();
        }

        String[,] pole =
        {

            {"H","H","H","H","H","H","H","H","H","H"}, 
            {"H","H","H","H","H","H","H","H","H","H"},
            {"H","H","H","H","H","H","H","H","H","H"}, 
            {"H","H","H","H","H","H","H","H","H","H"}, 
            {"H","H","H","H","H","H","H","H","H","H"}, 
            {"H","H","H","H","H","H","H","H","H","H"}, 
            {"H","H","H","H","H","H","H","H","H","H"}, 
            {"H","H","H","H","H","H","H","H","H","H"}, 
            {"H","H","H","H","H","H","H","H","H","H"}, 
            {"H","H","H","H","H","H","H","H","H","H"}
           



        };

      
        

        public void CheckKdoHraje()
        {
            if (hra == true)
            {

          
            int rInt = r.Next(1,3);
            if (rInt == 1)
            {
                label1.Text = "Hraje X";
                   
                }
            else
            {
                label1.Text = "Hraje O";
                  

                }
            }

        }








        public void startGame()
        {
            string newLine = Environment.NewLine;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {

                    vystup1.Text += pole[i, j];
                    

                }
                vystup1.Text += ""+newLine ;

            }
        }

        public void gameOver()
        {
            

            if( pocetX == 5)
            {
                vystup1.Text = "X win";
                vyhryX += 1;
                hra = true;

            }
            else if ( pocetO == 5)
            {
                vystup1.Text = "O win";
                vyhryO += 1;
                hra = true;
            }
          
            
        }


        public void checkRows()
        {
           
            for (int i = 0; i < 10; i++)
            {
                pocetX = 0;
                pocetO = 0;
                for (int j = 0; j < 10; j++)
                {
                    if (pole[i, j] == "@")
                    {
                        pocetX = 0;
                        pocetO = 0;
                    }

                    if (pole[i, j] != "@")
                    {
                        if (pole[i, j] == "X")
                        {
                            pocetX += 1;

                        }
                        else if (pole[i, j] == "O")
                        {
                            pocetO += 1;
                        }
                       

                        gameOver();
                    }
                }
            }
        
        }

        public void checkColomns()
        {
            
            for (int i = 0; i < 10; i++)
            {
                pocetX = 0;
                pocetO = 0;
                for (int j = 0; j < 10; j++)
                {
                    if (pole[j, i] == "@")
                    {
                        pocetX = 0;
                        pocetO = 0;
                    }
                    if (pole[j, i] != "@")
                    {

                        if (pole[j, i] == "X")
                        {
                            pocetX += 1;

                        }
                        else if (pole[j, i] == "O")
                        {
                            pocetO += 1;
                        }
                        gameOver();
                    }
                }
            }
           

        }


       public void checkDiagonalOne()
        {

                for (int i = 0; i < 10; i++)
            {

                pocetX = 0;
                pocetO = 0;


                for (int j = 0; j < i+1; j++)
                {
                    if (pole[i - j, j] == "@")
                    {
                        pocetX = 0;
                        pocetO = 0;
                    }

                    if (pole[i - j, j] != "@")
                    {


                        if (pole[i - j, j] == "X")
                        {
                            pocetX += 1;

                        }
                        else if (pole[i - j, j] == "O")
                        {
                            pocetO += 1;
                        }

                        gameOver();

                    }
                }

            }
           
           for(int x = 1; x < 10; x++)
            {
                int xplus = -1;
                yminus += 1;
               

                for (int y = 0; y < 10 - yminus ; y++) { 
                    xplus += 1;

                    if (pole[x + xplus, 9 - xplus] == "@")
                    {
                        pocetX = 0;
                        pocetO = 0;
                    }

                    if (pole[x + xplus, 9 - xplus] != "@")
                    {
                        if (pole[x + xplus, 9 - xplus] == "X")
                        {
                            pocetX += 1;

                        }
                        else if (pole[x + xplus, 9 - xplus] == "O")
                        {
                            pocetO += 1;
                        }

                        gameOver();





                    }
                }
            }      




        }
            

        public void checkDiagonalTwo()
        {

           

            for(int y = 0; y < 10; y++)
            {


                pocetX = 0;
                pocetO = 0;
                yminusTwo = -1;
                for (int x = 0; x < y + 1; x++)
                {
                    yminusTwo += 1;

                    if (pole[9 - yminusTwo, y - yminusTwo] == "@")
                    {
                        pocetX = 0;
                        pocetO = 0;
                    }

                    if (pole[9 - yminusTwo, y - yminusTwo] != "@")
                    {
                        if (pole[9 - yminusTwo, y - yminusTwo] == "X")
                        {
                            pocetX += 1;

                        }
                        else if (pole[9 - yminusTwo, y - yminusTwo] == "O")
                        {
                            pocetO += 1;
                        }

                        gameOver();

                    }
                }               
            }

            for (int x = 9; x > 0; x--)
            {

                pocetX = 0;
                pocetO = 0;
                for (int i = 0; i < (10 - x); i++)
                {
                    if (pole[i, x + i] == "@")
                    {
                        pocetX = 0;
                        pocetO = 0;
                    }

                    if (pole[i, x + i] != "@")
                    {
                        if (pole[i, x + i] == "X")
                        {
                            pocetX += 1;

                        }
                        else if (pole[i, x + i] == "O")
                        {
                            pocetO += 1;
                        }

                        gameOver();
                    }
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if(hra == false)
            { 

            for (int y = 0; y < 10; y++)
            {

                for (int j = 0; j < 10; j++)
                {

                pole[y, j] = Convert.ToString(vystup1.Text[j+ (12 * y)]);


                }

            }
            /*
            int celkemX = 0;
            int celkemO = 0;

            for (int y = 0; y < 10; y++)
            {

                for (int j = 0; j < 10; j++)
                {

                    if (pole[y, j] == "X")
                    {
                        celkemX += 1;
                          

                        }
                    else if (pole[y, j] == "O")
                    {
                        celkemO += 1;
                    }


                }

            }
           */

            if (rInt == 1)            
        {             
                                         
          
                             
            label1.Text = "Hraje O";
          

           
                rInt = 2;

        }
        else 
        {          
             label1.Text = "Hraje X";
            
                 rInt = 1;
        }
        

            checkDiagonalTwo();
            checkDiagonalOne();
            checkColomns();
            checkRows();
            pocetX = 0;
            pocetO = 0;
           

        }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (hra == true)
            {

                for (int i = 0; i < 10; i++)
                {
                    for (int y = 0; y < 10; y++)
                    {
                        pole[i, y] = "H";
                    }
                }
                label2.Text = "Vyhry X: " + vyhryX;
                label3.Text = "Vyhry O: " + vyhryO;
                CheckKdoHraje();
                vystup1.Text = "";
                startGame();
                hra = false;

            }
           
            
        }

        
    }
}

    