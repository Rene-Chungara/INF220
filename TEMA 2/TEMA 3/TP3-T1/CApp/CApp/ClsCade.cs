using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    public class ClsCade
    {
        char[] Cadena = new char[100];
        int c;

        public int cm
        {
            get { return c; }
            set { c = value; }
        }

        public ClsCade()
        {
            c = -1;
        }
        public ClsCade(string Cadena)
        {
            c = Convert.ToUInt16(Cadena.Length);
            for (int i = 0; i <= c; i++)
            {
                this.Cadena[i] = Cadena[i];
            }
        }
        public void Meter(string Cad)
        {
            c = Convert.ToUInt16(Cad.Length);
            for (int i = 0; i <= c - 1; i++)
            {
                this.Cadena[i] = Cad[i];
            }
        }
        public string sacar()
        {
            string cad = " ";
            for (int i = 0; i <= c - 1; i++)
            {
                cad = cad + Cadena[i];
            }
            return cad;
        }
        public void BorrarCade(ClsCade c)
        {
            c.c = -1;
        }

        public Boolean Vacia(ClsCade c)
        {
            if (c.c == -1)
            {
                return true;
            }
            else return false;
        }
        public void InvertirCad()
        {
            char Aux;
            int f = 0;
            for (int i = c; i >= 0; i--)
            {
                Aux = Cadena[f];
                Cadena[f] = Cadena[i];
                Cadena[i] = Aux;
                f++;

            }
        }

    }
}
