/* **************************************************** ************
Institución: Universidad Gabriel René Moreno
Carrera: Ingeniería en Sistemas
Materia: Estructura de Datos I
Descripción: Implementación del TAD Conjunto
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
    public class ClsConj
    {
        const int MAX = 100;
        int[] conj;
        int dim;

        public int Dim
        {
            get { return dim; }
            set { dim = value; }
        }

        public ClsConj()
        {
            conj = new int[MAX];
            dim = -1;
        }
        public ClsConj(ClsConj C)
        {

            this.conj = C.conj;
            this.dim = C.Dim;
        }


        public void añadir(ClsConj A, int ele)
        {
            dim++;
            if (A.Esta(A, ele) == false)
            {

                conj[dim] = ele;
            }
            else
            {
                dim--;
            }

        }
        public bool Esta(ClsConj B, int c)
        {

            int i = 0;
            while (i <= B.dim && B.conj[i] != c)
            {
                i++;
            }
            if (i <= dim)
                return true;
            else return false;

        }
        public void eliminar(ClsConj B1, int c)
        {
            int i = 0;
            while (i <= B1.dim && B1.conj[i] != c)
            {
                i++;
            }
            if (i <= B1.dim)
            {
                for (int j = i; j <= B1.dim; j++)
                {
                    B1.conj[j] = B1.conj[j + 1];

                }
                B1.dim--;
            }

        }
        public void Vaciar(ClsConj A)
        {
            A.dim = -1;
        }
        public ClsConj Union(ClsConj A, ClsConj B)
        {
            ClsConj C = new ClsConj();
            for (int i = 0; i <= A.dim; i++)
            {
                C.añadir(C, A.conj[i]);
            }
            for (int j = 0; j <= B.dim; j++)
            {
                C.añadir(C, B.conj[j]);
            }
            return C;
        }
    }
}
