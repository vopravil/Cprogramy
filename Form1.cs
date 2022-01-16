using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sibenice
{
    public partial class Form1 : Form
    {
        
        string hadaneSlovoText ="";
        int hadaneSlovoCislo;
        int spravne = 0;
        string[] prazdno = {" "," ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", };
      
        string[] slova = { "kun", "auto", "pocitac", "nosorozec" };
        string[,] sibenice =
        {
            {"__________"},
            {"|  /     |"},
            {"|/       *"},
            {"|       -[]-"},
            {"|        ||   "},
            {"-----------"},

        };

        Random r = new Random();
       
        int chyby;

        
        public Form1()
        {
            InitializeComponent();
        }
       
        public string startGame()
        {

                hadaneSlovoCislo = r.Next(slova.Length);
                hadaneSlovoText = slova[hadaneSlovoCislo];
            for (int i = 0; i < hadaneSlovoText.Length; i++)
            {
                prazdno[i] = "?";
                vystup2.Text += prazdno[i];
            }      
                 return hadaneSlovoText;
        }
        public void hadaniSlova()
        {
            
            vystup2.Text = "";
            int spatne = 0;

            if (textBox1.Text != "")
            {
                for (int i = 0; i < hadaneSlovoText.Length; i++)
                {
                    if (hadaneSlovoText[i].ToString() == textBox1.Text)
                    {

                        prazdno[i] = textBox1.Text;
                        spravne +=1;
                        if (spravne == hadaneSlovoText.Length)
                        {
                            vystup.Text = "spravne";
                        }
                    }
                    else
                    {
                        spatne++;
                        if (spatne == hadaneSlovoText.Length)
                        {
                            vystup.Text = "";
                            chyby++;
                            
                            string newLine = Environment.NewLine;
                            for (int x = 0; x < chyby; x++)
                            {
                                vystup.Text += sibenice[6 - chyby + x, 0];
                                vystup.Text += "" + newLine;
                            }
                        }
                    }
                    vystup2.Text += prazdno[i];
                    if (chyby == 6)
                    {
                        vystup2.Text = "prohra";
                        spravne = hadaneSlovoText.Length;
                    }

                }
            }                   
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (hadaneSlovoText == "")
            {
                startGame();
            }
            if (spravne < hadaneSlovoText.Length && textBox1.Text != "")
            {
                hadaniSlova();
                textBox1.Text = "";
          
            }
            else if (spravne == hadaneSlovoText.Length)
            {
                hadaneSlovoText = "";
                spravne = 0;
                vystup2.Text = "";
                vystup.Text = "";
                chyby = 0;
                for (int i = 0; i < prazdno.Length; i++)
                {
                    prazdno[i] = " ";
                }
            }
            
        }

        
    }
}
