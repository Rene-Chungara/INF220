/* **************************************************** ************
Institución: Universidad Gabriel René Moreno
Carrera: Ingeniería en Sistemas
Materia: Estructura de Datos I
Creador: Rene Eduardo Chungara Martinez - 221044191
Grupo: SD
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
    class Program
    {
        public static void Main(string[] args)
        {
            ClsNatu N = new ClsNatu();
            Console.WriteLine("Sucesor de 10: ");
            Console.WriteLine(N.Sucesor(10));
            Console.WriteLine("La Suma es: ");
            Console.WriteLine(N.Suma(5, 10));
            Console.WriteLine("La resta es: ");
            Console.WriteLine(N.Resta(5, 10));
            Console.WriteLine("La multiplicacion es: ");
            Console.WriteLine(N.Multiplicacion(5, 10));
            Console.WriteLine("-------------");
            Console.WriteLine("-------------");
            ClsHora H = new ClsHora();
            H.cargar(1, 36, 08);
            Console.WriteLine("La hora es: ");
            Console.WriteLine(H.Descargar());
            Console.WriteLine("-------------");
            Console.WriteLine("-------------");
            ClsFech F = new ClsFech();
            F.cargar(14, 9, 22);
            Console.WriteLine("La Fecha es: ");
            Console.WriteLine(F.Descargar());
            Console.ReadKey();
        }
    }
}
