using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cApp
{
    public class clsSpar
    {
        /*ATRIBUTOS*/

        const int Max = 1000;                          // Cantidad de filas del arreglo SP Sparce
        public int[,] SP = new int[Max, 3];            // Arreglo donde se almacena los datos de las Matris  original
        public int Cant = 0;                           // Cantidad de celdas llenas en el  arreglo SP Sparce
        public int m = 0;                             // Cantidad de columnas de la Matriz original
        public int n = 0;                             // Cantidad de filas de la Matriz original


        /*CONSTRUCTORES*/
        public clsSpar()
        {
            Cant = 0; n = 0; m = 0;
            int i = 0;
            while (i < Max)
            {
                SP[i, 0] = 0; SP[i, 1] = 0; SP[i, 2] = 0;
                i++;
            }
        }

        public clsSpar(clsSpar x)
        {
            Cant = x.Cant; n = x.n; m = x.m;
            int i = 0;
            while (i < Max)
            {
                SP[i, 0] = x.SP[i, 0]; SP[i, 1] = x.SP[i, 1]; SP[i, 2] = x.SP[i, 2];
                i++;
            }
        }

        // Limpiar el Arreglo SP
        public void ClearArreglo()
        {
            int i = 0; Cant = 0;
            while (i < Max)
            {
                SP[i, 0] = 0; SP[i, 1] = 0; SP[i, 2] = 0;
                i++;
            }
        }

        // Funcion para mostrar la Matriz A
        public string MostraArreglo(int[,] A)
        {
            int i, j = 0;
            string cad = "";
            for (i = 0; i < n; i++)
            {
                cad += "\n";
                for (j = 0; j < m; j++)
                    cad += "[" + A[i, j] + "]";
            }
            return cad;
        }


        // Funcion para mostrar arreglo Spar V(t,3)
        public string MostrarVector()
        {
            string cad = "";

            for (int i = 0; i < Cant; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cad += " [" + SP[i, j] + "]";
                }
                cad += "\n";
            }
            return cad;
        }

        // Aqui escriba el codigo de la funciones


        //Sparce(A) --> SP          //Funcion para pasar los datos de la matriz A a la matros Sparce SP(t,3)
        public clsSpar SparceA(int[,] A)
        {
            clsSpar S = new clsSpar();
            n = A.GetLength(0); //columna
            m = A.GetLength(1); //Fila
            S.SP[0, 0] = n;
            S.SP[0, 1] = m;
            S.Cant = 1;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (A[i, j] != 0)
                    {
                        S.SP[S.Cant, 0] = i;
                        S.SP[S.Cant, 1] = j;
                        S.SP[S.Cant, 2] = A[i, j];
                        S.Cant++;
                    }
                }
            }
            S.SP[0, 2] = S.Cant - 1;
            return S;
        }
        //Diagonal2(SP) --> Q       //Funcion para pasar obtener en una cola  Q los datos de la diagonal secundaria de M a partir de SP
        public clsCola DiagonalSeg(int[,] SP)
        {
            clsCola Q = new clsCola();
            int cantidad = SP[0, 2];
            int colum = SP[0, 0];
            for (int i = 0; i < cantidad +1 ; i++)
            {
                if (SP[i, 0] + SP[i, 1] == colum - 1)
                {
                        Q.Add(SP[i, 2]);
                }
            }
            return Q;
        }
    }

}


