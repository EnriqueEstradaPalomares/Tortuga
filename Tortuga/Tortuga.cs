using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tortuga
{
    class Tortuga
    {
        private int[,] piso;
        private bool pluma = true;
        private bool gIzquierda = false;
        private bool gDerecha = false;
        private int x = 0;
        private int y = 0;

        public Tortuga()
        {
            piso = new int[21, 21];
            for(int i=0; i<21; i++)
            {
                for(int j=0; j < 21; j++)
                {
                    piso[i, j] = 0;
                }
            }
        }
        public void plumaIsUp()
        {
            pluma = true;
        }

        public void plumaIsDown()
        {
            pluma = false;
        }

        public void avanzar(int pasos)
        {
            if (pluma)
            {
                if (x > 0 && y > 0 || x < 21 && y < 21)
                {
                    if(gDerecha)
                    {

                    }
                }
            }
        }

        public string imprimirArreglo()
        {
            string data = " ";
            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 21; j++)
                {
                    data += piso[i, j] + ",";
                    if (j == 20)
                    {
                        data += "\r\n";
                    }
                }
            }
            return data;
        }
    }
}
