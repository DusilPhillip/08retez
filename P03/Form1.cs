using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03
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
            char pocetsmazani = ' ';
            int prom = 0;

            foreach (char i in textBox1.Text)
            {
                if (i >= '0' && i <= '9')
                {
                    pocetsmazani = i;
                    prom = 1;
                    break;
                }
            }
            if (prom == 0)
            {

                textBox2.Text = veta;
            }
            else
            {
                int pocet = veta.Length;
                int odkud = pocet - ((int)pocetsmazani - 48);
                int pocets = ((int)pocetsmazani - 48);

                if (pocets > pocet)
                {
                    textBox2.Text = " ";
                }
                else
                {
                    string vysledek = veta.Remove(odkud, pocets);


                    textBox2.Text = vysledek;
                }
            }
        }
    }
}
