/* **************************************************** ************
Institución: Universidad Gabriel René Moreno
Carrera: Ingeniería en Sistemas
Materia: Estructura de Datos I
Descripción: Implementación del TAD Hora
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
    public class ClsHora
    {
        //Atributos
        private int hora;
        private int Min;
        private int Seg;
        //Constructor
        public ClsHora()
        {
            this.hora = 0;
            this.Min = 0;
            this.Seg = 0;
        }
        //Constructor Parametrizado
        public ClsHora(int hh, int mm, int ss)
        {
            if (hh >= 0 && hh < 24)
            {
                this.hora = hh;
                if (mm >= 0 && mm < 60)
                {
                    this.Min = mm;
                    if (ss >= 0 && ss < 60)
                    {
                        this.Seg = ss;
                    }
                }
            }
        }
        //Constructor de copia
        public ClsHora(ClsHora t)
        {
            this.hora = t.hora;
            this.Min = t.Min;
            this.Seg = t.Seg;
        }
        //properties
        public int hora1
        {
            get { return hora; }
            set { hora = value; }
        }
        public int min1
        {
            get { return Min; }
            set { Min = value; }
        }
        public int seg1
        {
            get { return Seg; }
            set { Seg = value; }
        }
        public void cargar(int hh,int mm, int ss)
        {
            if (ss < 59)
            {
                if (mm < 59)
                {
                    if (hh < 24)
                    {
                        this.hora = hh;
                        this.Min = mm;
                        this.Seg = ss;
                    }
                }
            }
        }
        public string Descargar()
        {
            string cad = "";
            //Concatenando
            if (hora < 10)
            {
                cad = "0" + hora + ":";
            }
            else
            {
                cad = hora + ":";
            }
            if (Min < 10)
            {
                cad = cad + "0" + Min + ":";
            }
            else
            {
                cad = cad + Min + ":";
            }
            if (Seg < 10)
            {
                cad = cad + "0" + Seg;
            }
            else
            { 
                cad = cad + Seg; 
            }
            return cad;
        }
        public ClsHora horaActual()
        {
            ClsHora actu = new ClsHora();
            actu.hora = (int)DateTime.Now.Hour;
            actu.Min = (int)DateTime.Now.Minute;
            actu.Seg = (int)DateTime.Now.Second;
            return actu;
        }
        
    }
}
