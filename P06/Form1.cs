using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P06
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
            string bezmezer = veta.Trim();

            int i = 0;
            while( i < bezmezer.Length-1)
            {
                if (bezmezer[i] ==' ' && bezmezer[i + 1] == ' ')
                {
                        bezmezer = bezmezer.Remove(i, 1);
                    
                }else { i++; }
            }
            textBox2.Text = bezmezer;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string veta = textBox1.Text;
            string bezmezer = veta.Trim();

            if (bezmezer.Contains("  "))
            {          
                    bezmezer = bezmezer.Replace("  ", " "); 
            }

            textBox3.Text = bezmezer;
        }
    }
}
