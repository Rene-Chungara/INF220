/* **************************************************** ************
Institución: Universidad Gabriel René Moreno
Carrera: Ingeniería en Sistemas
Materia: Estructura de Datos I
Descripción: Implementación del TAD Natural
Creador: Rene Eduardo Chungara Martinez
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
    public class ClsNatu
    {
        //Atributo
        private int n;
        //contructor

        public ClsNatu()
        {
            n = 0;
        }

        public void cargar(int ele)
        {
            this.n = ele;
        }

        public bool esCero(int x)
        {
            if (x == 0)
            {
                return true;
            }
            return false;
        }
        public int Sucesor(int x)
        {
            x = x + 1;
            return x;
        }
        public bool Igual(int a, int b)
        {
            if (esCero(a) == true || esCero(b) == false)
                return false;
            if (esCero(a) == false || esCero(b) == true)
                return false;
            if (a == b)
                return true;
            return false;
        }
        public int Suma(int a,int b)
        {
            int s = 0;
            if (a < 0 || b < 0)
            {
                throw new Exception("Error de numero invalido");
            }
            else
            {
                s = a + b;
            }
            return s;
        }
        public int Resta(int a,int b)
        {
            int r = 0;
            if (a < 0 || b < 0)
            {
                throw new Exception("Error de numero invalido");
            }
            if (a >= b)
            {
                r = a - b;
            }
            else
            {
                r = b - a;
            }
            return r;
        }
        public int Multiplicacion(int a, int b)
        {
            int m = 0;
            if (a < 0 || b < 0)
            {
                throw new Exception("Error de numero invalido");
            }
            else
            {
                m = a * b;
            }
            return m;
        }

    }
}
