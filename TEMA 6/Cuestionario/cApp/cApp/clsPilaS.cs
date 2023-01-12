/*************************************************************
Institución:    Facultad de Cs. de la Comutacion - UAGRM
Materia:        Estructura de Datos I
Proyecto:       cApp (Proyecto de Clases)
Descripción:    Implementacion de DoblePila.
Creador:        Rene Eduardo Chungara Martinez.
Registro:       221044191
Lenguaje:       C#
*************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace cApp
{
    public class clsPilaS
    {
        //ATRIBUTOS DE LA CLASE
        public const int MAX = 10;                          
        public const int n = 3;                             
        public const int t = MAX / n;                       

        private int[] pilas;                               
        private int[] front;                                
        private int[] rear;
        private int[] cant;

        //CONSTRUCTOR DE LA CLASE
        public clsPilaS()
        {
            pilas = new int[MAX];
            cant = new int[n + 1];
            front = new int[n];
            rear = new int[n];
            for (int i = 0; i < MAX; i++)
            {
                pilas[i] = 0;
            }
            int j = 0;
            while (j < n)
            {
                front[j] = (j * t) - 1;
                rear[j] = (j * t) - 1;
                cant[j] = j * t;
                j++;
            }
            cant[j] = MAX;
        }

        //METODOS DE LA CLASE

        // Es TRUE si la Pila i esta vacía, de lo contrario es FALSE.
        public bool IsVacia(int i)
        {
            bool s = false;
            if (front[i] == rear[i])
            {
                s = true;
            }
            return s;
        }

        //Es TRUE si la Pila i esta llena, de lo contrsrio esta vacia .
        public bool IsFull(int i)
        {
            bool s = false;
            if (rear[i] == cant[i + 1]) 
            {
                s = true;
            }
            return s;
        }

        // Cuantos elemento tiene la Pila i
        public void LongEle(int i)
        {
            int cantidad = 0;
            while (!IsVacia(i))
            {
                cantidad = cant[i]++;
                DelFon(i);
            }
           // return cantidad;
        }

        //Adiciona el elemento x a la Pila i
        public void Add(int i, int ele)
        {
            if (!IsFull(i))
            {
                rear[i]++;
                pilas[rear[i]] = ele;
            }
        }
        /*Borra el elemento del tope de la Pila i, la cantidad
        de elementos de la Pila i debe ser mayor a cero     */
        public void DelFon(int i)
        {
            if (!IsVacia(i))
            {
                front[i]++;
            }
        }
        /*Borra los n  elemento del fondo de la Pila i,  
         * la pila debe tener mayor o igual cantidad de elementos que n */
        public void DelFonN(int i,int c)
        {

        }
    }
}
