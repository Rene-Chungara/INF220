using System;
using System.Collections.Generic;
using System.Text;

namespace cApp
{
    public class clsCola2
    {
        public const int max = 20;
        private int rear1;
        private int rear2;
        private int top1;
        private int top2;
        public int cant;
        private int[] cola = new int[max];

        public clsCola2()
        {
            rear1 = -1;
            top1 = -1;
            rear2 = max;
            top2 = max;
            cant = 0;
            for (int i = 0; i < max; i++)
            {
                cola[i] = 0;
            }
        }

        public clsCola2(clsCola2 c)
        {
            rear1 = c.rear1;
            top1 = c.top1;
            rear2 = c.rear2;
            top2 = c.top2;
            cant = c.cant;
            for (int i = 0; i < max; i++)
            {
                cola[i] = c.cola[i];
            }

        }
        //Adiciona el elemento x la cola
        public void Add(int s, int x)
        {
            if (s == 0)
            {
                if (!llena(s))
                {
                    rear1++;
                    cola[rear1] = x;
                }
            }
            else
            {
                if (!llena(s))
                {
                    rear2++;
                    cola[rear2] = x;
                }
            }
        }
        // Elimina el elemento tope de la cola
        public void delete(int s)
        {
            if (s == 0)
            {
                if (!vacia(s))
                {
                    top1++;
                }
            }
            else
            {
                if (!vacia(s))
                {
                    top2--;
                }
            }
        }

        // Retorna TRUE si S esta vacía de lo contrario FALSE
        public Boolean vacia(int s)
        {
            Boolean vacio = false;
            if (s == 0)
            {
                if (top1 == rear1)
                {
                    vacio = true;
                }
            }
            else
            {
                if (top2 == rear2)
                {
                    vacio = true;
                }
            }
            return vacio;
        }

        // Retorna TRUE si S esta llena de lo contrario FALSE
        public Boolean llena(int s)
        {
            Boolean lleno = false;
            if (s == 0)
            {
                if (rear1 + 1 == max / 2)
                {
                    lleno = true;
                }
            }
            else
            {
                if (rear2 - 1 == max / 2)
                {
                    lleno = true;
                }
            }
            return lleno;
        }
        //mostrar la cola de un string
        public String mostrar()
        {
            String s = "cola:[";
            for (int i = top1 + 1; i <= rear1; i++)
            {
                s = s + cola[i] + "|";
            }
            for (int i = rear2; i <= top1 + 1; i++)
            {
                s = s + cola[i] + "|";
            }
            return s;
        }
    }
}
