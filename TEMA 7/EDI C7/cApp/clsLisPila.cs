﻿/*************************************************************
Institución:    Universidad Gabriel Rene Moreno
Carrera:        Ingenieria Informatica
Materia:        Estructura de Datos I
Proyecto:       cApp (Proyecto de Clases)
Descripción:    Implementacion del TAD clsLisPila.
Creador:        Rene Eduardo Chungara Martinez.
Registro:       221044191    
Lenguaje:       C#
Herramienta:    Visual Studio 2019 - Windows Aplications
**************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cApp
{
    public class clsLisPila
    {
        class Nodo {
            public int info;
            public Nodo sig;
        }
        private Nodo tope, rear;

        public clsLisPila() {
            tope = null;
            rear = null;
        }
        public void Drop() {
            tope = null;
            rear = null;
        }
        public bool Vacia()
        {
            if (tope == null)
                return true;
            else
                return false;
        }
        public int Top()
        {
            if (Vacia() != true)
                return rear.info;
            return 0;
        }

        public int primer()
        {
            if (Vacia() != true)
                return tope.info;
            return 0;
        }
        public clsLisPila Delete()
        {
            clsLisPila R = new clsLisPila();
            if (Vacia() == false)
            {
                if (tope.sig == null)
                {
                    tope = null;
                    rear = null;
                }
                else
                {
                    Nodo next = tope;
                    Nodo actual = tope;
                    next = next.sig;
                    while (next != null)
                    {
                        if (next.sig == null)
                        {
                            actual.sig = null;
                            rear = actual;
                        }
                        actual = next;
                        next = next.sig;
                    }
                }
            }
            R.tope = tope;
            R.rear = rear;
            return R;
        }
        public clsLisPila Add(int elemento)
        {
            clsLisPila R = new clsLisPila();
            Nodo nuevo = new Nodo();
            nuevo.info = elemento;
            nuevo.sig = null;
            if (Vacia())
            {
                tope = nuevo;
                rear = nuevo;
            }
            else
            {
                rear.sig = nuevo;
                rear = nuevo;
            }

            R.tope = tope;
            R.rear = rear;
            return R;
        }

        public clsLisPila DelPrimero()
        {
            clsLisPila L = new clsLisPila();
            Nodo nodo;
            nodo = tope;

            if (nodo == null)
            {
                L.tope = tope;
                L.rear = rear;
                return L;
            }
            tope = nodo.sig;        // se actualiza el puntero que apunta al primero
            nodo = null;
            L.tope = tope;
            L.rear = rear;
            return L;
        }
        public string Imprimir(){
            string S = "";
            Nodo actual = tope;
            while (actual != null){
                S += "[ "+actual.info + " ]";
                actual = actual.sig;
            }
            return S;
        }

        public clsLisPila Invertir(clsLisPila P)
        {
            clsLisPila S = new clsLisPila();
            while (P.Vacia() == false)
            { 
                S.Add(P.Top());
                P.Delete();
            }
            return S;
        }
    }
}
