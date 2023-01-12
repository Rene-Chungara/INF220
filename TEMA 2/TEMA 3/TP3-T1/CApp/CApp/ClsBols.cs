/* **************************************************** ************
Institución: Universidad Gabriel René Moreno
Carrera: Ingeniería en Sistemas
Materia: Estructura de Datos I
Creador: Rene Eduardo Chungara Martinez 
Descripcion: Implementacion del TAD Bolsa
Idioma: C#
Herramienta: Visual Studio 2019 - Aplicaciones Windows
**************************************************** ********** */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApp
{
    public class ClsBols
    {
        char[] Bolsa;
        int cons;

        public int Cons
        {
            get { return cons; }
            set { cons = value; }
        }
        // constructores
        public ClsBols()        
        {
            Bolsa = new char[1000];
            cons = -1;
        }

        public ClsBols(ClsBols B)
        {

            this.Bolsa = B.Bolsa;
            this.cons = B.cons;
        }

        public void Insertar(ClsBols B, char ch)
        {
            cons++;
            if (B.Esta(B, ch) == false)
            {
                Bolsa[cons] = ch;
            }
            else
            {
                cons--;
            }

        }
        public void Vaciar(ClsBols B)
        {
            B.cons = -1;
        }

        public ClsBols Union(ClsBols B1, ClsBols B2)
        {
            ClsBols BR = new ClsBols(B1);
            for (int i = 0; i <= B2.cons; i++)
            {
                if (!BR.Esta(B1, B2.Bolsa[i]) == true)
                    BR.Insertar(BR, B2.Bolsa[i]);
            }
            return BR;
        }
        public bool Esta(ClsBols B, char c)
        {
            int i = 0;
            while (i <= B.cons && B.Bolsa[i] != c)
            {
                i++;
            }
            if (i <= cons)
                return true;
            else return false;

        }
        public ClsBols Interseccion(ClsBols B1, ClsBols B2)
        {
            ClsBols BA = new ClsBols(B1);

            for (int i = 0; i <= BA.cons; i++)
            {
                if (B2.Esta(B2, BA.Bolsa[i]) == false)
                {
                    BA.eliminar(BA, BA.Bolsa[i]);
                }
            }
            return BA;
        }
        public void eliminar(ClsBols B1, char c)
        {
            int i = 0;
            while (i <= B1.cons && B1.Bolsa[i] != c)
            {
                i++;
            }
            if (i <= B1.cons)
            {
                for (int j = i; j <= B1.cons; j++)
                {
                    B1.Bolsa[j] = B1.Bolsa[j + 1];
                }
                B1.cons--;
            }

        }

    }
}
