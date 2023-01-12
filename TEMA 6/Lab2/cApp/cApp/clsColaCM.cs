/*************************************************************
Institución:    Facultad de Cs. de la Comutacion - UAGRM
Materia:        Estructura de Datos I
Proyecto:       cApp (Proyecto de Clases)
Descripción:    Implementacion del TAD Cola Circular Multiple utilizando Arreglos.
Creador:        Rene Eduardo Chungara Martinez.
Lenguaje:       C#
*************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace cApp
{
    public class clsColaCM
    {
        //ATRIBUTOS DE LA CLASE
        public const int MAX = 10;                          // Dimension del Vetor donde se almancenaran todas las Colas
        public const int n = 3;                             // Numeros de Colas a ser Almacenadas en el Vector de Colas
        public const int t = MAX / n;                       // Tamano de cada Cola  

        private int[] Colas;                               // Dimension del Vetor donde se lamancenaran todas las Colas
        private int[] B;                                   // Dimension del Vector de Tamanos de cada Cola
        private int[] F;                                   // Dimension del Vector de Front de cada Cola
        private int[] R;                                   // Dimension del Vector de Rear de cada Cola
        private int[] cant = new int[n];                   // Cantidad de Colas
    
        public clsColaCM()
        {
            Colas = new int[MAX];
            B = new int[n + 1];
            F = new int[n];
            R = new int[n];
            for (int i = 1; i < MAX; i++)
            {
                Colas[i] = 0;
            }
            int j = 0;
            while (j < n)
            {
                cant[j] = 0;
                F[j]= (j * t) - 1;
                R[j] = (j * t) - 1;
                B[j] = j * t;
                j++;
            }
            B[j] = MAX;
        }
        public void Add(int c,int ele)
        {
            R[c] = (R[c] + 1) % B[c + 1];
            if (!Llena(c))
            {
                R[c] = B[0];
            }
            Colas[R[c]] = ele;
        }
        public void Delete(int c)
        {
            if (!Vacia(c))
            {
                cant[c]--;
                F[c] = (F[c] + 1) % B[c + 1];
                if (F[c] == 0)
                {
                    F[c] = B[c];
                }
            }
        }
        public bool Vacia(int c)
        {
            bool s = false;
            if (cant[c] == 0)
            {
                s = true;
            }
            return s;
        }
        public int From(int c)
        {
            int x = 0;
            F[c] = (F[c] + 1) % B[c + 1];
            if (F[c] == 0)
            {
                F[c] = B[c];
            }
            x = Colas[F[c]];
            return x;
        }
        public bool Llena(int c)
        {
            bool s = false;
            if (cant[c] == t)
            {
                s = true;
            }
            return s;
        }

        //Calcula el numero de elementos de una  cola circular Qi.
        public int Long(int n)
        {
            return cant[n];
        }

        //Elimina los primeros n elementos en una cola circular Qi si los hay.
        public void Descola(int n,int x)
        {
            if (cant[n] >= x)
            {
                for(int i = 0; i < cant[n]; i++)
                {
                    Delete(n);
                }
            }
        }

        //Genera la inversa de una cola circular Qi.
        public void Inversa(int c)
        {
            if (!Vacia(c))
            {
                int dato = From(c);
                Delete(c);
                Inversa(c);
                Add(dato, c);
            }
        }

        /*Duplica una cola circular Qi de forma que cada elemento de Qi aparezca
        dos veces seguidas conservando el mismo orden relativo que en Qi.*/
        public clsColaCM Duplica()
        {
            clsColaCM C = new clsColaCM();
            for (int i = 0; i < n; i++)
            {
                int k = F[i];
                for (int j = 0; j < cant[i]; j++)
                {
                    k = (k + 1) % MAX;
                    C.Add(i, F[k]);
                    C.Add(i, F[k]);
                }
            }
            return C;
        }

        /*Genera la cola circular C resultante de unir los elementos
            de Pi, y Qi desde el primero hacia el último.         */
        public clsColaCM Concatena(clsColaCM P, clsColaCM Q)
        {
            clsColaCM C = new clsColaCM();
            for (int i = 0; i < n; i++)
            {
                int k = P.F[i];
                for (int j = 0; j < P.cant[i]; j++)
                {
                    k = (k + 1) % MAX;
                    C.Add(i, P.F[k]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                int k = Q.F[i];
                for (int j = 0; j < Q.cant[i]; j++)
                {
                    k = (k + 1) % MAX;
                    C.Add(i, Q.F[k]);
                }
            }
            return C;
        }

        /*Genera la cola circular C resultante de ir uniendo 
          alternativamente los elementos de Pi, y Qi desde 
        el primero elemento hacia el ultimo             */
        public clsColaCM Mezcla(clsColaCM P,clsColaCM Q)
        {
            clsColaCM C = new clsColaCM();
            for (int i = 0; i < n; i++)
            {
                int k = P.F[i];
                int w = Q.F[i];
                int j = 0;
                while ((P.cant[i] > j)&&(Q.cant[i]>j))
                {
                    k = (k + 1) % MAX;
                    w = (w + 1) % MAX;
                    C.Add(i, P.F[k]);
                    C.Add(i, Q.F[w]);
                    j++;
                }
                if (P.cant[i] > j)
                {
                    k = (k + 1) % MAX;
                    C.Add(i, P.F[k]);
                    j++;
                }
                else
                {
                    w = (w + 1) % MAX;
                    C.Add(i, Q.F[w]);
                    j++;
                }
            }
            return C;
        }

    }
}
