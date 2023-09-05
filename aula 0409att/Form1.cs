using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_0409att
{
    public partial class Form1 : Form
    {
        Random randNum = new Random();
        int i;
        int [] valor1 = new int[10];
        int [] valor2 = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         try
            {
                for (int i = 0; i < 10; i++) { 
                }
                valor1[i] = randNum.Next(0, 10);
                listBox1.Items.Add(valor1[i]);
                valor2[i] = randNum.Next(0, 10);
                listBox2.Items.Add(valor2[i]);
                listBox3.Items.Add(valor2[i] * valor1[i]);

            }
            catch (Exception erro)
            {

            }

            }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
