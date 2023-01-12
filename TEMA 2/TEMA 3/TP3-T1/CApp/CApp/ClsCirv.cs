/* **************************************************** ************
Institución: Universidad Gabriel René Moreno
Carrera: Ingeniería en Sistemas
Materia: Estructura de Datos I
Descripción: Implementación del TAD Circulo
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
    public class ClsCirv
    {
        private double radio;
        private double ancho;

        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }
        public double Ancho
        {
            get { return ancho; }
            set { ancho = value; }
        }
        //Constructor
        public ClsCirv()
        {
            radio = 0;
        }
        // constructor de parametro
        public ClsCirv(double radio)
        {
            if (radio >= 0)
            {
                this.radio = radio;

            }
        }
        // constructor de copia
        public ClsCirv(ClsCirv c)
        {

            this.radio = c.radio;
        }
        public double diametro(double radio)
        {
            radio = radio * 2;
            return radio;
        }
        public double area(double radio)
        {
            double Area = Math.PI * Math.Pow(radio, 2);
            return Area;
        }
        public double Perimetro(double radio)
        {
            double Peri = (2 * Math.PI * radio);
            return Peri;
        }

    }
}
