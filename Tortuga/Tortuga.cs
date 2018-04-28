using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficoTortuga
{
    class Tortuga
    {
        private int x, y,frente = 0;
        bool izquierda = false, derecha = false,plumaAbajo = false,plumaArriba=true, derecho = false;
        int[,] vector;

        public Tortuga()
        {
            vector = new int[20, 20];
            LlenarVector();
        }

        public void LlenarVector()
        {
            int renglones = vector.GetLength(0);
            int columnas = vector.GetLength(1);
            for(int i = 0; i < renglones; i++)
            {
                for (int j = 0; j < columnas; j++)
                    vector[j, i] = 0;
            }
        }

        public bool PasarLimite(int pasos)
        {
            bool limiteCruzado = false;
            int columnas = vector.GetLength(1);
            switch(frente)
            {
                case 1:
                    {
                        if(izquierda)
                        {
                            if (y + (pasos-1) >= columnas - 1)
                                limiteCruzado = true;
                        }
                        else if(derecha)
                        {
                            if (y - (pasos - 1) <= 0)
                                limiteCruzado = true;
                        }
                        else if(derecho)
                        {
                            if (x + (pasos - 1) >= columnas-1)
                                limiteCruzado = true;
                        }

                    }break;
                case 2:
                    {
                        if (izquierda)
                        {
                            if (x - (pasos - 1) <= 0)
                                limiteCruzado = true;
                        }
                        else if (derecha)
                        {
                            if (x + (pasos - 1) >= columnas-1)
                                limiteCruzado = true;
                        }
                        else if(derecho)
                        {
                            if (y + (pasos - 1) >= columnas-1)
                                limiteCruzado = true;
                        }
                    }
                    break;
                case 3:
                    {
                        if (izquierda)
                        {
                            if (y - (pasos - 1) <= 0)
                                limiteCruzado = true;
                        }
                        else if (derecha)
                        {
                            if (y + (pasos - 1) >= columnas-1)
                                limiteCruzado = true;
                        }
                        else if(derecho)
                        {
                            if (x - (pasos - 1) <= 0)
                                limiteCruzado = true;

                        }
                    }
                    break;
                case 4:
                    {
                        if (izquierda)
                        {
                            if (x + (pasos - 1) >= columnas - 1)
                                limiteCruzado = true;
                        }
                        else if (derecha)
                        {
                            if (x - (pasos - 1) <= 0)
                                limiteCruzado = true;
                        }
                        else if(derecho)
                        {
                            if (y - (pasos-1) <= 0)
                                limiteCruzado = true;
                        }
                    }
                    break;
            }
            return limiteCruzado;
        }

        public void Asignar()
        {
            int renglones = vector.GetLength(0);
            int columnas = vector.GetLength(1);
                if (plumaAbajo)
                    vector[y, x] = 1;
                else
                    vector[y, x] = 0;
        }

        public void Izquierda()
        {
            if (derecha || derecho)
            {
                derecha = false;
                izquierda = true;
                derecho = false;
            }
            else
                izquierda = true;
        }

        public void Derecho()
        {
            if (derecha || izquierda)
            {
                derecha = false;
                izquierda = false;
                derecho = true;
            }
            else
                derecho = true;
        }

        public void Derecha()
        {
            if (izquierda || derecho)
            {
                derecho = false;
                izquierda = false;
                derecha = true;
            }
            else
                derecha = true;
        }

    
        public void Girar(int pasos)
        {
            int renglones = vector.GetLength(0);
            int columnas = vector.GetLength(1);
            if(!PasarLimite(pasos))
            {
                if (frente == 1)
                {
                    for (int i = 0; i < pasos; i++)
                    {
                        if (izquierda)
                        {
                                y += 1;
                                Asignar();
                                frente = 2; 
                        }
                        else
                        {
                                y -= 1;
                                Asignar();
                                frente = 4;
                        }
                    }
                }
                else if (frente == 2)
                {
                    for (int i = 0; i < pasos; i++)
                    {
                        if (izquierda)
                        {
                                x -= 1;
                                Asignar();
                                frente = 3;    
                        }
                        else
                        {
                                x += 1;
                                Asignar();
                                frente = 1;   
                        }
                    }
                }
                else if (frente == 3)
                {
                    for (int i = 0; i < pasos; i++)
                    {
                        if (izquierda)
                        {
                                y -= 1;
                                Asignar();
                                frente = 4; 
                        }
                        else
                        {
                                y += 1;
                                Asignar();
                                frente = 2;
                        }
                    }
                }
                else if (frente == 4)
                {
                    for (int i = 0; i < pasos; i++)
                    {
                        if (izquierda)
                        {
                                x += 1;
                                Asignar();
                                frente = 1;
                        }
                        else
                        {
                                x -= 1;
                                Asignar();
                                frente = 3;
                        }
                    }
                }
            }
        }

        public void Derecho(int pasos)
        {
            int renglones = vector.GetLength(0);
            int columnas = vector.GetLength(1);
            Derecho();
            if (!PasarLimite(pasos)) {
                switch (frente)
                {
                    case 1:
                        {
                            for (int i = 0; i < pasos; i++)
                            {
                                    x += 1;
                                    Asignar();
                            }
                        }
                        break;
                        
                    case 2:
                        {
                            for (int i = 0; i < pasos; i++)
                            {
                                    y += 1;
                                    Asignar();
                            }
                        }
                        break;
                    case 3:
                        {
                            for (int i = 0; i < pasos; i++)
                            {
                                    x -= 1;
                                    Asignar();
                            }
                        }
                        break;
                    case 4:
                        {
                            for (int i = 0; i < pasos; i++)
                            {
                                    y -= 1;
                                    Asignar();
                            }
                        }
                        break;
                }
            }
        }

        public void Avanzar(int pasos,bool izquierda, bool derecha)
        {
            if (x == 0 && y == 0)
            {
                for (int i = 0; i < pasos; i++)
                {

                    if (izquierda)
                    {
                        y = i;
                        Asignar();
                        frente = 2;
                    }
                    else if (!derecha)
                    {
                        x = i;
                        Asignar();
                        frente = 1;
                    }
                }
            }
            else if (izquierda || derecha)
                Girar(pasos);
            else
                Derecho(pasos); 
        }

        public void PlumaArriba()
        {
            if (plumaAbajo)
            {
                plumaAbajo = false;
                plumaArriba = true;
            }
            else
                plumaArriba = true;
        }

        public void PlumaAbajo()
        {
            if (plumaArriba)
            {
                plumaArriba = false;
                plumaAbajo = true;
            }
            else
                plumaAbajo = true;
        }

        public string ImprimirPiso()
        {
            string texto = "";
            int renglones = vector.GetLength(0);
            int columnas = vector.GetLength(1);
            for (int i = 0; i < renglones; i++)
            {
                for (int j = 0; j < columnas; j++)
                    texto += vector[j, i].ToString() + "  ";

                texto += Environment.NewLine;
            }
            return texto;
        }
    }
}
