using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04
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
            int i = 0;
            while ( i < veta.Length)
            { 
                    if (veta[i] >= 'A' && veta[i] <= 'Z')
                    {
                     veta = veta.Remove(i, 1);

                    }
                    else
                {
                    i++;
                }
                
            }


            textBox2.Text = veta;
        }
    }
}

