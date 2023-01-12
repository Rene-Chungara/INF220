/* **************************************************** ************
Institución: Universidad Gabriel René Moreno
Carrera: Ingeniería en Sistemas
Materia: Estructura de Datos I
Creador: Rene Eduardo Chungara Martinez 
Descripcion: Implementacion del TAD Agenda
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
    public class ClsAgen
    {
        int Maxfil = 50;
        int MaxCol = 50;

        string[,] Matriz;
        string[] vectorD;
        int dim = 50;


        public ClsAgen()
        {
            Matriz = new String[Maxfil, MaxCol];
            vectorD = new String[dim];
            dim = 0;
            Maxfil = 0;

        }
        public int get_dim()
        {

            return this.dim;
        }
        public void cargar(string nombre, string dir, string cel, string otros)
        {
            Maxfil = contador() - 1;
            //   MaxCol=col;
            for (int c = 0; c < 4; c++)
            {
                if (c == 0) { Matriz[Maxfil, c] = nombre; }
                if (c == 1) { Matriz[Maxfil, c] = dir; }
                if (c == 2) { Matriz[Maxfil, c] = cel; }
                if (c == 3) { Matriz[Maxfil, c] = otros; }
            }
        }
        public string mostrar_agenda()
        {
            string s = "";
            Maxfil = contador() - 1;
            for (int f = 0; f < Maxfil; f++)
            {
                for (int c = 0; c < 4; c++)
                {

                    s = s + " |" + Convert.ToString(Matriz[f, c]);
                }
                s = s + "\n";
            }
            return s;
        }
        public string buscar_per(string nombre)
        {
            string s = "";
            bool b = false;
            int j = 0;
            int i = 0;
            while ((i < Maxfil) && (b == false))
            {
                j = 0;
                while ((j < 4) && (b == false))
                {
                    if (Matriz[i, j] == nombre)
                    {
                        s = s + "NOMBRE    " + Matriz[i, 0] + "/ DIRECCION       " + Matriz[i, 1] + "/ Nro CELULAR    " + Matriz[i, 2] + "/  OTROS" + Matriz[i, 3];
                        b = true;
                    }
                    j++;
                }
                i++;
            }
            return s;
        }
        public int contador()
        {
            this.Maxfil++;
            return this.Maxfil;
        }
    }
}
