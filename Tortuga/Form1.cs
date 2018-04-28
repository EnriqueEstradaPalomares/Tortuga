using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tortuga
{
    public partial class Form1 : Form
    {
        Tortuga tortuga = new Tortuga();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Recorrido, 1 es por donde ha pasado la tortuga" + "\r\n" + tortuga.imprimirArreglo();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
