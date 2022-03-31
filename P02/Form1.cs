using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string veta = textBox1.Text;
            int posun = Convert.ToInt32(textBox4.Text);
            string vysledek = "";
            int hodnota = 0;
            char pismeno = ' ';
            foreach( char i in veta)
            {
               hodnota = (int) i;
                if( i >= 'a' && i <= 'z')
                {
                  
                        hodnota += posun;
                    
                   
                }
                if ((char)hodnota > 'z')
                {
                    hodnota = hodnota - 26;

                }

               
                pismeno = (char)hodnota;
                vysledek += pismeno;
                

            }
            textBox2.Text = vysledek;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string veta = textBox2.Text;
            int posun = Convert.ToInt32(textBox4.Text);
            string vysledek = "";
            int hodnota = 0;
            char pismeno = ' ';
            foreach (char i in veta)
            {
                hodnota = (int)i;
                if (i >= 'a' && i <= 'z')
                {

                    hodnota -= posun;


                }
                if ((char)hodnota < 'a')
                {
                    hodnota = hodnota + 26;

                }


                pismeno = (char)hodnota;
                vysledek += pismeno;


            }

            textBox3.Text = vysledek;


        }
    }
}
