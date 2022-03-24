using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01
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
            string samohlasky = "aeiouyáéěíóúůý";
            string souhlasky = "bcčdďfghjklmnpqrřsštťvwxzž";
            int pocetsamohlasky = 0;
            int pocetsouhlasky = 0;

            int celkem = veta.Length;
            veta = veta.ToLower();
            foreach( char i in veta)
            {
                if( samohlasky.Contains(i))
                {
                    pocetsamohlasky++;

                }
                else if(souhlasky.Contains(i))
                {
                    pocetsouhlasky++;
                }

            }

            int pocett = celkem - pocetsamohlasky - pocetsouhlasky;
            MessageBox.Show(" veta obsahuje " + pocetsouhlasky + " souhlasek " + pocetsamohlasky + "samohlasek a ostatnich znaku" + pocett);
            
        }
    }
}
