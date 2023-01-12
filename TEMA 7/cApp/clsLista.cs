using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cApp

{

    public class  clsLista
    {
        // Se define la clase Nodo
        class Nodo
        {
            public int info;
            public Nodo sig;
        }

        // Se define los nodos tope (primero) y rear (ultimo)
        // se puede implementar con un solo puntero pero 
        // cada vez tenemos que recorrer todo la lista para encontrar el ultimo

        private Nodo tope, rear;

        // Constructor de la Clase Lista
        public clsLista()
        {
            tope = null;
            rear = null;
        }

        // Valida si la lista esta vacia
        public bool Vacia()
        {
            if (tope == null)
                return true;
            else
                return false;
        }

        // Adiciona un Nodo al inicio de la Lista
        public clsLista AddPrimero(int info)
        {

            clsLista L = new clsLista();
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.sig = tope;

            if (Vacia())
            {
                tope = nuevo;
                rear = nuevo;
            }
            else
            {
                tope = nuevo;
            }
            L.tope = tope;
            L.rear= rear;
            return L;
        }

        //Adiciona una Nodo al Final de la Lista
        public clsLista AddUltimo(int info)
        {
            clsLista L = new clsLista();
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
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
            L.tope = tope;
            L.rear = rear;
            return L;
        }

        // Adciona un Nodo Antes de un Nodo X dado
        public clsLista AddAntes( int info,int infoX)
        {
            // Buscamo el Nodo X en la Lista
            // recorremos toda la lista desde el Tope hasta el Rear
            clsLista L = new clsLista();
            Nodo anterior = null;       // El anterior parte en Nulo
            Nodo actual = tope;         // El Actual es igual al Primero
            
            while (actual != null)
            {
                if (actual.info == infoX)   // Encontro el nodo y se inserta el nuevo antes de
                {
                    Nodo nuevo;
                    nuevo = new Nodo();
                    nuevo.info = info;
                    nuevo.sig = actual;     // El nuevo Nodo apunta al actual Nodo
                    anterior.sig = nuevo;   // El anterior Nodo apunta al Nuevo nodo
                }
                anterior = actual;          // Anterior es igual al nodo actual
                actual = actual.sig;        // Recorremos el Siguiente Nodo
            }
            L.tope = tope;
            L.rear = rear;
            return L;         
        }

        


       
        // Borrar un nodo dado X
        public clsLista Delete(int info)
        {
            clsLista L = new clsLista();
            Nodo anterior, nodo;
            nodo = tope;
            anterior = null;
            Boolean existe = false;
            while (nodo != null && existe==false)     // recorremos la lista hasta encontrar el nodo
            {
                if (nodo.info == info)
                    existe = true;
                else
                {
                    anterior = nodo;
                    nodo = nodo.sig;
                }
            }


            if (existe == false )       // no se encuentra el nodo
                                        //   return;
            { 
                L.tope = tope;
                L.rear = rear;
                return L;
            }

            if (nodo == tope)           // si el nodo es el primero
            {
                tope = nodo.sig;        // se actualiza el puntero que apunta al primero
                nodo = null;
                L.tope = tope;
                L.rear = rear;
                return L; ;
            }

            if (nodo == rear)           // si el nodo es el ultimo
            {
                anterior.sig = null;
                rear = anterior;        // se actualiza el puntero que apunta al ultimo
                nodo = null;
                L.tope = tope;
                L.rear = rear;
                return L; ;
            }

            anterior.sig = nodo.sig;    // el nodo esta en medio de dos nodos
            L.tope = tope;
            L.rear = rear;
            return L;
        }


       

        // Borra el Primero de la Lista
        
        public clsLista DelPrimero()
        {
            clsLista L = new clsLista();
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

       // Valida si un elemento existe en la lista
        public Boolean Buscar(int info)
        {
            Nodo reco = tope;
            while (reco != null)
            {
                if  (reco.info==info)
                    return true;
                reco = reco.sig;
            }
            return false;
        }

        // Mostrar la Lista
        public string View()
        {
            string cad = "";
            Nodo reco = tope;
            while (reco != null)
            {
                cad+=reco.info + "->";
                reco = reco.sig;
            }
            return cad;
        }

        // ==========================  PARA DESARROLLAR =============================

        // Adiciona el nodo con valor info después del nodo con valor infox dado

        public clsLista AddDespues(int info, int infoX)
        {
            clsLista L = new clsLista();
            Nodo actual = tope;
            Nodo pos = tope.sig;
            bool exis = false;
            if (Vacia() == false)
            {
                while ((pos != null)&&(exis == false))
                {
                    if (actual.info == infoX)
                    {
                        exis = true;
                        Nodo nuevo = new Nodo();
                        nuevo.info = info;
                        nuevo.sig = pos;
                        actual.sig = nuevo;
                    }
                    actual = pos;
                    pos = pos.sig;
                }
            }
            L.rear = rear;
            L.tope = tope;
            return L;
        }

        // Borrar el ultimo nodo de la lista
        public clsLista DelUltimo()
        {
            clsLista L = new clsLista();
            Nodo anterior = null;
            Nodo actual = tope;
            Nodo posi = tope.sig;
            if ((!Vacia()) && (tope == rear))
            {
                tope = null;
                rear = null;
            }
            else
            {
                if (!Vacia())
                {
                    while (posi != null)
                    {
                        anterior = actual;
                        actual = posi;
                        posi = posi.sig;
                    }
                    anterior.sig = null;
                    actual = null;
                    rear = anterior;
                }
            }
            L.rear = rear;
            L.tope = tope;
            return L;
        }

        public int Menor()
        {
            Nodo actual = tope;
            int ele = Mayor();
            while (actual != null)
            {
                if (actual.info <= ele)
                {
                    ele = actual.info;
                }
                actual = actual.sig;
            }
            return ele;
        }
        public int Mayor()
        {
            Nodo actual = tope;
            int ele = 0;
            while (actual != null)
            {
                if (actual.info >= ele)
                {
                    ele = actual.info;
                }
                actual = actual.sig;
            }
            return ele;
        }
        // Retorna una lista con los elemento ordenados de forma ascendente o descennte 
        public clsLista Ordenar(int Orden)
        {

            // if Orden=1 ascendente   if Oden=2 descendente

            clsLista L = new clsLista();
            int ele = 0;
            if (Vacia() == false)
            {
                if (Orden == 1)
                {
                    while (Vacia() == false)
                    {
                        ele = Menor();
                        L.AddUltimo(ele);
                        Delete(ele);
                    }
                }
                if (Orden == 2)
                {
                    while (Vacia() == false)
                    {
                        ele = Mayor();
                        L.AddUltimo(ele);
                        Delete(ele);
                    }
                }
            }
            return L;
        }

   }
}
