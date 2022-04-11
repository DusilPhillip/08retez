using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            int pocetp;
            int max = 0;
            string slovo = " ";
            if (checkBox1.Checked)
            {

                MessageBox.Show("pocet slov ve vete:" + slova.Length);

            }
            if (checkBox2.Checked) {
                foreach (string slova1 in slova) {



                    pocetp = 0;
                    foreach (char pis in slova1)
                    {
                        pocetp++;
                    }

                    if (max < pocetp)
                    {
                        max = pocetp;
                        slovo = slova1;
                    }
                }
                MessageBox.Show("nejdelsi slovo je" + slovo + " a obsahuje " + max + " pismen ");
            

            }
            if(radioButton1.Checked)
            {

                    textBox1.ForeColor = Color.Red;
                

            }
           else if ( radioButton2.Checked)
            {

                textBox1.Font = new Font(textBox1.Font.Name, 12);

            }
            if ( radioButton3.Checked)
            {

                textBox1.Font = new Font(textBox1.Font.Name, 20);

            }
           else if (radioButton4.Checked)
            {

                textBox1.ForeColor = Color.Black;

            }







        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
