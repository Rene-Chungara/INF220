using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cApp
{
    public class clsLisPoly
    {
        class Nodo
        {
            public int coef;
            public int exp;
            public Nodo sig;
        }

        private Nodo tope, rear;

        public clsLisPoly()
        {
            tope = null;
            rear = null;
        }

        public bool IsZero()
        {
            return tope == null;
        }

        public int Coef(int exp) {
            Nodo aux = tope;
            while (aux != null) {
                if (aux.exp == exp) {
                    return aux.coef;
                }
                aux = aux.sig;
            }
            return 0;
        }


        public clsLisPoly Attach(int coef, int exp) {
            clsLisPoly R = new clsLisPoly();
            if (coef != 0 && exp >= 0) {

                Nodo nuevo = new Nodo();
                nuevo.coef = coef;
                nuevo.exp = exp;
                nuevo.sig = null;

                if (IsZero()) {
                    tope = nuevo;
                    rear = nuevo;
                }
                else {
                    Nodo actual = tope;
                    bool aux = false;
                    while (actual != null) {
                        if(actual.exp == exp) {
                            actual.coef += coef;
                            aux = true;
                        }
                        actual = actual.sig;
                    }
                    if (aux == false) {
                        rear.sig = nuevo;
                        rear = nuevo;
                    }
                }            
            }
            R.tope = tope;
            R.rear = rear;
            return R;
        }

        //
        public string Imprimir() {
            string cad = "";
            Nodo reco = tope;
            while (reco != null){
                cad += reco.coef + "x^"+reco.exp + " ";
                reco = reco.sig;
            }
            return cad;
        }



        // PilaToLista (LisPila) --> LisPoly        
        // Funcion que pasa los elementos de la Pila lista a un Polinomio Lista
        // Aqui escriba el codigo
        public clsLisPoly PilaToLista(clsLisPila LisPila)
        {
            clsLisPoly LisPoly = new clsLisPoly();
            clsLisPila L = new clsLisPila();
            LisPila=LisPila.Invertir(LisPila);
            
            while(LisPila.Vacia()==false)
            {
                int coe = LisPila.Top();
                LisPila.Delete();
                int exp = LisPila.Top();
                LisPila.Delete();
                LisPoly.Attach(coe, exp);
            }
            return LisPoly;
        }


        

    }
}
