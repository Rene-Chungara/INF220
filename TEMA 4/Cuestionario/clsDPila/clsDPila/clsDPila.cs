/*************************************************************
Institución:    Universidad Gabriel Rene Moreno
Carrera:        Ingenieria Informatica
Materia:        Estructura de Datos I
Proyecto:       cApp (Proyecto de Clases)
Descripción:    Implementacion del DPila.
Creador:        Rene Eduardo Chungara Martinez - 221044191
Lenguaje:       C#
Herramienta:    Visual Studio 2019 - Windows Aplications
*************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace clsDPila
{
    public class clsDPila
    {
        public const int MAX = 10;
        private int tope;
        private int fondo;
        private int[] Dpila;
        //CONSTRUCTOR
        public clsDPila()
        {
            tope = -1;
            fondo = 0;
            Dpila = new int[MAX];
        }
        //METODOS
        public clsDPila(clsDPila p)
        {
            p.tope = tope;
            p.fondo = fondo;
            p.Dpila = Dpila;
        }
        public clsDPila(int top, int fon, int[] c)
        {
            this.tope = top;
            this.fondo = fon;
            this.Dpila = c;
        }
        public int Tope
        {
            get { return tope; }
            set { tope = value; }
        }
        public int Fondo
        {
            get { return fondo; }
            set { fondo = value; }
        }
        public void create() //Crea una DoblePila
        {
            tope = 0;
        }
        public void Add(int ele) //Adiciona un elemento x a la Pilas
        {
            if (tope >= 0)
            {
                if (isFull() == false)
                {
                    tope++;
                    Dpila[tope] = ele;
                    fondo = 0;
                }
            }
        }
        public bool isFull() //verifica si esta llena la pila
        {
            bool b = false;
            if (tope + 1 == MAX)
                b = true;
            else
                b = false;
            return b;
        }
        public bool isVacia() //verifica si esta vacia la pila
        {
            bool b = false;
            if (tope == -1)
                b = true;
            else
                b = false;
            return b;
        }
        //Borra el elemento tope de la Pila
        public void DelTop()
        {
            if (isVacia() == false)
            {
                tope--;
            }
        }
        //Borra el elemento fondo de la Pila
        public void DelFon()
        {
            if (isVacia() == false)
            {
                fondo++;
            }
        }

    }
}
