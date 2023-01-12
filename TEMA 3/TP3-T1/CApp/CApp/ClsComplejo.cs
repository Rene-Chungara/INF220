/* **************************************************** ************
Institución: Universidad Gabriel René Moreno
Carrera: Ingeniería en Sistemas
Materia: Estructura de Datos I
Descripción: Implementación del TAD Complejo
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
    public class ClsComplejo
    {
        private float n;
        public ClsComplejo()
        {
            n = 0;
        }
        //Properties
        public float GetSet
        {
            get { return n; }
            set { n = value; }
        }
        public void cargar(float ele)
        {
            this.n = ele;
        }
        public bool esCero(float x)
        {
            if (x == 0)
            {
                return true;
            }
            return false;
        }
        public float Suma(float a, float b)
        {
            float s = a + b;
            return s;
        }
        public float Resta(float a, float b)
        {
            float r = a - b;
            return r;
        }
        public float Multiplicacion(float a, float b)
        {
            float m = a * b;
            return m;
        }
        public int parteEntera(String x)
        {
            String cad = "";
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] != ',')
                {
                    cad = cad + x[i];
                }
                else
                {
                    i = x.Length + 1;
                }
            }
            return int.Parse(cad);
        }
        public int parteDecimal(String x)
        {
            String cad = "";
            bool b = false;
            for (int i = 0; i < x.Length; i++)
            {
                if (b)
                {
                    cad = cad + x[i];
                }
                if (x[i] == ',')
                {
                    b = true;
                }
            }
            return int.Parse(cad);
        }
    }
}
