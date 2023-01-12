/*************************************************************
Institución:    Universidad Gabriel Rene Moreno
Carrera:        Ingenieria Informatica
Materia:        Estructura de Datos I
Proyecto:       cApp (Proyecto de Clases)
Descripción:    Implementacion del TAD Pila dos Pilas S1 y S2.
Creador:        Rene EduardO Chungara Martinez - 221044191
Lenguaje:       C#
Herramienta:     Visual Studio 2019 - Windows Aplications
*************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace CApp
{
    public class clsPila2
    {

        //ATRIBUTOS
        public const int MAX = 10;
        private int _top;
        private int[] _pila;
        private int _top2;
        //CONSTRUCTOR
        public clsPila2()
        {
            _top = -1;
            _pila = new int[MAX/2];
            _top2 = MAX;
        }

        //METODOS
        public clsPila2(clsPila2 p)
        {
            _top = p._top;
            _pila = new int[MAX/2];
            for (int i = 0; i < p._top; i++)
            {
                _pila[i] = p._pila[i];
            }
        }

        public int Top
        {
            get { return _top; }
            set { _top = value; }
        }
        public int Top2
        {
            get { return _top2; }
            set { _top2 = value; }
        }
        public int[] Pila
        {
            get { return _pila; }
            set { _pila = value; }
        }
    
        // Destruye la Pila
        public void Drop()
        {
            _top = -1;
            _top2 = +1;
        }

        // Valida si la Pila esta vacia
        public Boolean Vacia()
        {
            if (_top == -1)
            {
                return true;
            }
            return false;
        }

        // Obtiene el elemento de la Cima de la Pila 
        public int Tope()
        {
            if (Vacia() != true)
                return _pila[_top];
            return 0;
        }
        public int Tope2()
        {
            if (Vacia() != true)
                return _pila[_top2];
            return 0;
        }


        // Adiciona un elemento en la cima de la Pila
        public void Add(int e)
        {
            {
                if (Llena() != true)
                {
                    _top++;
                    _pila[_top] = e;
                }
            }
        }
        public void Add2(int elem)
        {
            {
                if (Llena() != true)
                {
                    _top2--;
                    _pila[_top2] = elem;
                }
            }
        }

        // Elimina el elemento de la cima de la Pila
        public void Delete()
        {
            if (Vacia() != true)
                _top--;
        }
        public void Delete2()
        {
            if (Vacia() != true)
                _top2++;
        }
        // Valida si la Pila esta llena
        public Boolean Llena()
        {
            if (_top + 1 == MAX/2)
            {
                return true;
            }
            return false;
        }
        public Boolean Llena2()
        {
            if (_top - 1 == MAX/2)
            {
                return true;
            }
            return false;
        }


        // Obtiene la cantidad de elementos en la Pila 
        public int Long()
        {
            return ((_top + 1)&(_top2 - 1));
        }

        // Imprime los elementos de la Pila 
        public string Imprimir()
        {
            string salida = "";
            for (int i = 0; i <= _top; i++)
            {
                salida += "[ " + _pila[i].ToString() + " ]";
            }
            return salida;
        }
        public string Imprimir2()
        {
            string salida = "";
            for (int i = 0; i <= _top2; i--)
            {
                salida += "[ " + _pila[i].ToString() + " ]";
            }
            return salida;
        }
    }
}
