/* **************************************************** ************
Institución: Universidad Gabriel René Moreno
Carrera: Ingeniería en Sistemas
Materia: Estructura de Datos I
Descripción: Implementación del TAD Real
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
    public class ClsReal
    {
        //Atributo
        private double n;
        //Constructor
        public ClsReal()
        {
            n = 0;
        }
        public void cargar(double ele)
        {
            this.n = ele;
        }
        public bool esCero(double x)
        {
            if (x == 0)
            {
                return true;
            }
            return false;
        }
        public bool EsNegativo(double x)
        {
            if (x >= 0)
                return false;
            else return true;
        }
        public double Suma(double a, double b)
        {
            double s = a + b;
            return s;
        }
        public double Resta(double a, double b)
        {
            double r = a - b;
            return r;
        }
        public double Multiplicacion(double a, double b)
        {
            double m = a * b;
            return m;
        }
    }
}
