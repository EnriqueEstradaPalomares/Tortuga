using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficoTortuga
{
    public partial class Form1 : Form
    {
        Tortuga tortuga;
        bool girarDerecha = false, girarIzquierda = false;
        public Form1()
        {
            InitializeComponent();
            tortuga = new Tortuga();
        }

        private void btnGirarIzquierda_Click(object sender, EventArgs e)
        {
            tortuga.Izquierda();
            if (girarDerecha)
            {
                girarIzquierda = true;
                girarDerecha = false;
            }
            else
                girarIzquierda = true;
        }

        private void btnGirarDerecha_Click(object sender, EventArgs e)
        {
            tortuga.Derecha();
            if (girarIzquierda)
            {
                girarIzquierda = false;
                girarDerecha = true;
            }
            else
                girarDerecha = true;
        }

        private void btnPlumaArriba_Click(object sender, EventArgs e)
        {
            tortuga.PlumaArriba();
        }

        private void btnPlumaAbajo_Click(object sender, EventArgs e)
        {
            tortuga.PlumaAbajo();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPasos.Text))
            {
                MessageBox.Show("Debe ingresar los pasos a avanzar");
                txtPasos.Focus();
            }
            else
            {
                int pasos = Convert.ToInt32(txtPasos.Text);
                if (tortuga.PasarLimite(pasos))
                    MessageBox.Show("No puedes salir del area");
                else 
                   tortuga.Avanzar(pasos, girarIzquierda, girarDerecha);
            }
            girarIzquierda = false;
            girarDerecha = false;

        }

        private void BtnGirarDerecha_MouseClick(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            txtPiso.Text = "";
            txtPiso.Text += tortuga.ImprimirPiso();
        }
    }
}
