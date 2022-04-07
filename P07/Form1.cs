using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] morseovka = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            string veta = textBox1.Text;
            string mor = "";

            foreach (char i in veta)
            {
                if (i == ' ')
                {
                    mor += "/";
                }
                else
                {
                    mor += morseovka[((int)i - 97)] + " ";
                }
            }
            textBox2.Text = mor;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] morseovka = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            string abc = "abcdefghijklmnopqrstuvwxyz";
            string veta = textBox2.Text;
            string final = "";
            

            for(int i = 0; i < veta.Length; i++)
            {
                if ( veta[i] == '/')
                {
                    final += " ";
                }
                else
                {
                   

                }

            }
        }
    }
}
