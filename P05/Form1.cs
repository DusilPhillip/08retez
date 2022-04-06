using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P05
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

            string[] slova = veta.Split(' ');
            int pocet = slova.Length;

            MessageBox.Show("pocet slov je:" + pocet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string veta = textBox2.Text;//   ahoj   ydar

            string bezmezer = veta.Trim();//ahoj  ydar
       
            string[] slova = bezmezer.Split(' ');
            int pocet = 0;
            for( int i = 0; i < slova.Length; i++)
            {
                if(slova[i] != "")
                {
                    pocet++;
                } 
            }
            MessageBox.Show("pocet slov je:" + pocet);
        }
    }
}
