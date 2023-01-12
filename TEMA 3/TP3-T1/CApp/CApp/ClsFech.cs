/* **************************************************** ************
Institución: Universidad Gabriel René Moreno
Carrera: Ingeniería en Sistemas
Materia: Estructura de Datos I
Creador: Rene Eduardo Chungara Martinez 
Descripcion: Implementacion del TAD Fecha
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
    public class ClsFech
    {
        //Atributos
        private int dia;
        private int mes;
        private int año;
        //Constructor
        public ClsFech()
        {
            this.dia = 0;
            this.mes = 0;
            this.año = 0;
        }
        //Constructor Parametrizado
        public ClsFech(int dd, int mm, int aa)
        {
            if (dd >= 0 && dd < 31)
            {
                this.dia = dd;
                if (mm >= 0 && mm < 12)
                {
                    this.mes = mm;
                    if (aa >= 0 && aa < 2100)
                    {
                        this.año = aa;
                    }
                }
            }
        }
        //Constructor de copia
        public ClsFech(ClsFech t)
        {
            this.dia = t.dia;
            this.mes = t.mes;
            this.año = t.año;
        }
        //properties
        public int dia1
        {
            get { return dia; }
            set { dia = value; }
        }
        public int mes1
        {
            get { return mes; }
            set { mes = value; }
        }
        public int año1
        {
            get { return año; }
            set { año = value; }
        }
        public void cargar(int dd, int mm, int aa)
        {
            if (dd < 31)
            {
                if (mm < 12)
                {
                    if (aa < 2100)
                    {
                        this.dia= dd;
                        this.mes = mm;
                        this.año = aa;
                    }
                }
            }
        }
        public string Descargar()
        {
            string cad = "";
            //Concatenando
            if (dia < 10)
            {
                cad = "0" + dia + "/";
            }
            else
            {
                cad = dia + "/";
            }
            if (mes < 10)
            {
                cad = cad + "0" + mes + "/";
            }
            else
            {
                cad = cad + mes + "/";
            }
            if (año < 100)
            {
                cad = cad + "20" + año;
            }
            else
            {
                cad = cad + año;
            }
            return cad;
        }
    }
}
