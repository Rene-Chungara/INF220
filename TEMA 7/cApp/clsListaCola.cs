using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cApp

{

    public class  clsListaS
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
        public clsListaS()
        {
            //tope (primero) y rear (ultimo)
            tope = null;
            rear = null;
        }

        // True si la lista esta vacia
        public bool Vacia()
        {
            if (tope == null)
                return true;
            else
                return false;
        }

        // Adiciona un Nodo al inicio de la Lista
        public clsListaS AddPrimero(int info)
        {
            clsListaS L = new clsListaS();
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.sig = tope;
            if (Vacia())
                rear = nuevo;
            else
                rear.sig = nuevo;
            tope = nuevo;
            L.tope = tope;
            L.rear= rear;
            return L;
        }

        //Adiciona una Nodo al Final de la Lista
        public clsListaS AddUltimo(int info)
        {
            clsListaS L = new clsListaS();
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
                rear.sig = nuevo;
                rear = nuevo;
            }
            L.tope = tope;
            L.rear = rear;
            return L;
        }

        // Adciona un Nodo Antes de un Nodo X dado
        public clsListaS AddAntes( int info,int infoX)
        {
            // Buscamo el Nodo X en la Lista
            // recorremos toda la lista desde el Tope hasta el Rear
            clsListaS L = new clsListaS();
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
        public clsListaS Delete(int info)
        {
            clsListaS L = new clsListaS();
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
        
        public clsListaS DelPrimero()
        {
            clsListaS L = new clsListaS();
            Nodo nodo;
            nodo = tope;

            if (nodo == null)//la lista esta vacia...por lo tanto no hay que borrar
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
                reco = reco.sig;//toma el puntero de la sgte casilla
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

        public clsListaS AddDespues(int info, int infoX)
        {
            clsListaS L = new clsListaS();
            if (!Vacia())
            {
                Nodo actual, despues;
                actual = tope;
                despues = tope.sig;
                Boolean sw = false;
                if (rear.info == infoX)//si esque esta al final de la lista
                {
                    sw = !sw;
                    Nodo nuevo = new Nodo();
                    nuevo.info = info;
                    nuevo.sig = null;
                    rear.sig = nuevo;
                    rear = nuevo;
                }
                while ((despues != null) && (!sw))
                {
                    if (actual.info == infoX)
                    {
                        sw = !sw;
                        Nodo nuevo = new Nodo();
                        nuevo.info = info;
                        nuevo.sig = despues;
                        actual.sig = nuevo;
                    }
                    actual = despues;
                    despues = despues.sig;
                }
            }
            L.tope = tope;
            L.rear = rear;
            return L;
        }

        // Borrar el ultimo nodo de la lista
         public clsListaS DelUltimo()
         {
             clsListaS L = new clsListaS();
             Nodo anterior, actual,Aanterior;
             anterior = null;
             Aanterior = null;
             actual = tope;

             if ((!Vacia()) && (tope==rear))//si la lista tiene un solo elemento....elimina ese uno
             {
                 tope = null;
                 rear = null;
                 L.tope = tope;
                 L.rear = rear;
                 return L;
             }
             if (Vacia())
             {
                 L.tope = tope;
                 L.rear = rear;
                 return L;
             }
             //1,2,3,4
             while (actual != null)
             {
                Aanterior = anterior;
                 anterior = actual;//3
                 actual = actual.sig;//null
             }
             Aanterior.sig = null;
             rear = Aanterior;
             anterior = null;
             L.tope = tope;
             L.rear = rear;
             return L; ;
         }
       
        // Retorna una lista con los elemento ordenados de forma ascendente o descennte 
        public clsListaS Ordenar(int Orden)
        {

            // if Orden=1 ascendente   if Oden=2 descendente

            clsListaS L = new clsListaS();

            // Escriba aqui el codigo

            return L;
        }
        public clsListaS drop()
        {
            clsListaS L = new clsListaS();
            tope = null;
            rear = null;
            L.tope = tope;
            L.rear = rear;
            return L;
        }

   }
}
