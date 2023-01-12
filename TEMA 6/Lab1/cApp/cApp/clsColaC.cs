using System;
using System.Collections.Generic;
using System.Text;

namespace cApp
{
    public class clsColaC
    { 
        private const int max = 1000;
        private int[] Cola = new int[max];
        int rear; //ultimo
        int from; //primero
        int cant; //cantidad

        //Constructor
        public clsColaC()
        {
            rear = -1;
            from = -1;
            cant = 0;
            for (int i = 0; i < max; i++)
            {
                Cola[i] = 0;
            }
        }

        public clsColaC(clsColaC Q)
        {
            rear = Q.rear;
            from = Q.from;
            cant = Q.cant;
            for (int i = 0; i < max; i++)
            {
                Cola[i] = Q.Cola[i];
            }
        }
        public bool vacia()
        {
            return (cant == 0);
        }

        public bool llena()
        {
            return (cant == max);
        }

        public int From()
        {
            return (Cola[from + 1]);
        }

        public void Add(int ele)
        {
            if (!llena())
            {
                rear = (rear + 1) % max;
                Cola[rear] = ele;
                cant++;
            }
        }
        public void Delete()
        {
            if (!vacia())
            {
                from = (from + 1) % max;
                cant--;
            }
        }

        //long(Q) --> N                 
        //Calcula el numero de elementos de una cola circular.
        public int Long()
        {
            return cant;
        }

        //descola(Q, n) -->Q 
        //Elimina los primeros n elementos en una cola circular p si los hay
        public void Descola(int n)
        {
            if (n <= cant)
            {
                for (int i = 1; i <= n; i++)
                {
                    Delete();
                }
            }
        }

        //inversa(Q) -->Q 
        //Genera la inversa de una cola circular Q.
        public void Inversa()
        {
            clsColaC C = new clsColaC();
            int k = rear;
            for (int i = 0; i < cant; i++)
            {
                C.Add(Cola[k]);
                if (k == 0)
                {
                    k = max;
                }
                k = (k - 1) % max;
            }
            rear = from;
            for (int j = 0; j < cant; j++)
            {
                rear = (rear + 1) % max;
                Cola[rear] = C.From();
                C.Delete();
            }
        }

        //duplica(Q) --> Q 
        //Duplica una cola circular Q de forma que cada elemento de Q aparezca dos veces seguidas
        public clsColaC Duplica()
        {
            clsColaC C = new clsColaC();
            int j = from;
            for (int i = 0; i < cant; i++)
            {
                j = (j + 1) % max;
                C.Add(Cola[j]);
                C.Add(Cola[j]);
            }
            return C;
        }

        //concatena(P, Q) -->C 
        /*Genera la cola circular C resultante de unir los elementos de P y Q 
         desde el primero hacia el último.                */
        public clsColaC Concatena(clsColaC P, clsColaC Q)
        {
            clsColaC C = new clsColaC();
            int i = P.from;
            for (int j = 1; j <= P.cant; j++)
            {
                i = (i + 1) % max;
                C.Add(P.Cola[i]);
            }
            int k = Q.from;
            for (int w = 1; w <= Q.cant; w++)
            {
                k = (k + 1) % max;
                C.Add(Q.Cola[k]);
            }
            return C;
        }

        //mezcla(P,Q) -->C 
        //Genera la cola circular C resultante de ir uniendo alternativamente los elementos de P y Q 
        //  desde el primero elemento hacia el ultimo
        public clsColaC Mezcla(clsColaC P, clsColaC Q)
        {
            clsColaC C = new clsColaC();
            int i = P.from;
            int j = Q.from;
            int k = 0;
            while ((P.cant > k) && (Q.cant > k))
            {
                i = (i + 1) % max;
                j = (j + 1) % max;
                C.Add(P.Cola[i]);
                C.Add(Q.Cola[j]);
                k++;
            }
            if (k == P.cant)
            {
                while (k <= Q.cant)
                {
                    j = (j + 1) % max;
                    C.Add(P.Cola[j]);
                    k++;
                }
            }
            else
            {
                j = (j + 1) % max;
                C.Add(P.Cola[j]);
            }
            return C;
        }

        //Muestra las colas
        public String Mostrar()
        {
            String S = "C[";
            int i = from;
            for (int j = 1; j <= cant; j++)
            {
                i = (i + 1) % max;
                S = S + Cola[i] + "|";
            }
            S = S + "]";
            return S;
        }
    }
}
