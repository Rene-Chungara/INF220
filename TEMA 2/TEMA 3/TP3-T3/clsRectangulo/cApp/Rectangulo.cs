using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cApp
{
    public class Rectangulo
    {
          //ATRIBUTOS/
       
        const int Max = 1000;
        public int[,] M = new int[Max, 3];           // Vector donde se almacena los datos de las Matris A original
        public int Cant = 0;                        // Cantidad de celdas llenas en el vector V
  
        //CONSTRUCTORES/
        public Rectangulo()
        {
            Cant = 0;
            int i = 0; int j = 0;
            while (i <= Max - 1)
            {
                j = 0;
                while (j <= 2)
                {
                    M[i, j] = 0;
                    j++;
                }
                i++;

            }
        }

        public Rectangulo(Rectangulo x)
        {
            Cant = x.Cant;
            int i = 0; int j = 0;
            while (i <= Max - 1)
            {
                j = 0;
                while (j <= 2)
                {
                    M[i, j] = x.M[i, j];
                    i++;
                }
                j++;

            }
        }

        //mostrar el vector de elementos
        public string mostrar()
        {
            string strSA = "";
            
            for (int i = 0; i <= Cant - 1; i++)
            {
                strSA += "[" + M[i, 0] + "," + M[i, 1] + "]";
                strSA += "\n";
            }
            return strSA;

        }

        public string Dibujar()
        {
            string strSA = "";
            int i, j, k, n, m = 0;
            if (Cant == 0) return strSA;

            n = M[0,0];
            m = M[0,1];
            for(i = 0; i < n; i++)
            {
                strSA += "\n";
                for(j = 0; j < m; j++)
                {
                    k = BuscarSA(i,j);
                    if (k >= 1)
                        strSA += "[" + M[k, 2] + "]";
                    else
                        strSA += "[" + "_" + "]";
                }
            }
            strSA += "\n";
            return strSA;
        }

        public int BuscarSA(int i,int j)
        {
            for(int k = 1; k < Cant; k++)
            {
                if ((i == M[k, 0]) && (j == M[k, 1]))
                    return k;
            }
            return -1;
        }

        public void CreateFigura(int [,] A)
        {
            int n = A.GetLength(0);
            int m = A.GetLength(1);
            M[0, 0] = n;
            M[0, 1] = m;
            Cant = 1;
            //Dim de A nro de fila y nro de columnas
            int i = 0;
            while (i < n)
            {
                int j = 0; 
                while(j < m)
                {
                    if(A[i,j] != 0)
                    {
                        M[Cant, 0] = i;
                        M[Cant, 1] = j;
                        M[Cant, 2] = A[i, j];
                        Cant++;
                    }
                    j++;
                }
                i++;
            }
            M[0, 2] = Cant - 1;
        }

        //Mover la figura hacia arriba
        public void MovUp()
        {
            for(int k = 1;k <= Cant; k++)
            {
                 M[k, 0] = M[k, 0] - 1;
            }
        }

        //Mover la figura hacia abajo
        public void MovDown()
        {
            for (int k = 1; k <= Cant; k++)
            {
                M[k, 0] = M[k, 0] + 1;
            }
        }

        //Mover la figura hacia izquierda
        public void MovIzq()
        {
            for (int k = 1; k <= Cant; k++)
            {
                  M[k, 1] = M[k, 1] - 1;
            }
        }

        //Mover la figura hacia derecha
        public void MovDer()
        {
            for (int k = 1; k <= Cant; k++)
            {
                M[k, 1] = M[k, 1] + 1;
            }
        }

       public bool limiteUp()
        {
            if (M[1, 0] > 0)
                return true;
            else
                return false;
        }

        public bool limiteDown()
        {
            if((M[0,0]-1) > M[Cant-1,0])
               return true;
            else
                return false;
        }
        
        public bool limiteIzq()
        {
            if (M[1, 1] > 0)
                return true;
            else
                return false;
        }

        public bool limiteDerecho()
        {
            if (M[Cant - 1, 1] < (M[0, 1] - 1))
                return true;
            else
                return false;
        }

        //Solo por diversion
        public bool limiteIzq2()
        {
            if (M[1, 1] > (M[0, 1] - 1))
                return true;
            else
                return false;
        }

        public bool limiteDerecho2()
        {
            if (M[Cant - 1, 1] < 0)
                return true;
            else
                return false;
        }
    }
}
