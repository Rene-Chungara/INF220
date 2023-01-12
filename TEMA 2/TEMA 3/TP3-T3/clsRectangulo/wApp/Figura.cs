/* **************************************************** ************
Institución: Universidad Gabriel René Moreno
Carrera: Ingeniería en Sistemas
Materia: Estructura de Datos I
Creador: Rene Eduardo Chungara Martinez - 221044191
Descripcion: Implementacion del TAD Rectangulo
Idioma: C#
Herramienta: Visual Studio 2019 - Aplicaciones Windows
**************************************************** ********** */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cApp;

namespace wApp
{
    public partial class Figura : Form
    {
        public Figura()
        {
            InitializeComponent();
        }

        int[,] A = {
                     { 0, 0, 0, 0, 0, 0 ,0 , 0, 0, 0, 0, 0, 0, 0 ,0 , 0},
                     { 0, 0, 0, 0, 0, 0 ,0 , 0, 0, 0, 0, 0, 0, 0 ,0 , 0},
                     { 0, 0, 0, 0, 0, 0 ,0 , 0, 0, 0, 0, 0, 0, 0 ,0 , 0},
                     { 0, 0, 0, 0, 0, 0 ,0 , 0, 0, 0, 0, 0, 0, 0 ,0 , 0},
                     { 0, 0, 0, 1, 1, 1 ,1 , 1, 0, 0, 0, 0 , 0, 0 , 0, 0},
                     { 0, 0, 0, 1, 0, 0 ,0 , 1, 0, 0, 0, 0, 0, 0 ,0 , 0},
                     { 0, 0, 0, 1, 0, 0 ,0 , 1, 0, 0, 0, 0, 0, 0 ,0 , 0},
                     { 0, 0, 0, 1, 0, 0 ,0 , 1, 0, 0, 0, 0, 0, 0 ,0 , 0},
                     { 0, 0, 0, 1, 0, 0 ,0 , 1, 0, 0, 0, 0, 0, 0 ,0 , 0},
                     { 0, 0, 0, 1, 0, 0 ,0 , 1, 0, 0, 0, 0 , 0, 0 , 0, 0},
                     { 0, 0, 0, 1, 0, 0 ,0 , 1, 0, 0, 0, 0, 0, 0 ,0 , 0},
                     { 0, 0, 0, 1, 0, 0 ,0 , 1, 0, 0, 0, 0, 0, 0 ,0 , 0},
                     { 0, 0, 0, 1, 0, 0 ,0 , 1, 0, 0, 0, 0, 0, 0 ,0 , 0},
                     { 0, 0, 0, 1, 1, 1 ,1 , 1, 0, 0, 0, 0, 0, 0 ,0 , 0},
                     { 0, 0, 0, 0, 0, 0 ,0 , 0, 0, 0, 0, 0 , 0, 0 , 0, 0},
                     { 0, 0, 0, 0, 0, 0 ,0 , 0, 0, 0, 0, 0, 0, 0 ,0 , 0},
                     { 0, 0, 0, 0, 0, 0 ,0 , 0, 0, 0, 0, 0, 0, 0 ,0 , 0},
                     { 0, 0, 0, 0, 0, 0 ,0 , 0, 0, 0, 0, 0, 0, 0 ,0 , 0},
                     { 0, 0, 0, 0, 0, 0 ,0 , 0, 0, 0, 0, 0 , 0, 0 , 0, 0},
                     };


        Rectangulo F = new Rectangulo();

        private void MostrarArreglo()
        {
            int i, j = 0;
            label1.Text = " ";
            for (i = 0; i <= 14; i++)
            {
                label1.Text += "\n";
                for (j = 0; j <= 14; j++)
                {
                    if (A[i, j] != 0)
                    {
                        label1.Text += "[" + A[i, j] + "]";
                    }
                    else
                    {
                        label1.Text += "[_]";
                    }

                }

            }
            label1.Text += "\n";
        }
        private void Figura_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            F.CreateFigura(A);     
            MostrarArreglo();
            label3.Text = F.Dibujar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            F.CreateFigura(A);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Text = F.mostrar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label7.Text = F.Dibujar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (F.limiteUp())
            {
                F.MovUp();
                label7.Text = F.Dibujar();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (F.limiteDown())
            {
                F.MovDown();
                label7.Text = F.Dibujar();
            }
            label4.Visible = false;
            label5.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //if (F.limiteIzq())
            //{
            if (!F.limiteDerecho2())
            {
                label7.Visible = true;
                F.MovIzq();
                label7.Text = F.Dibujar();
                
            }
            else
            {
                label3.Visible = false;
                label4.Visible = true;

            }
            //}
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //if (F.limiteDerecho())
            //{
                F.MovDer();
                label7.Text = F.Dibujar();
            //}
        }

        private void button6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!F.limiteDerecho2())
            {
                F.MovIzq();
                label7.Text = F.Dibujar();
               
            }
            else 
            { 
                label7.Visible = false;
            
            }
            
        }

        private void button6_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void button8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (F.limiteDerecho2())
            {
                F.MovDer();
                label7.Text = F.Dibujar();
            }
            else
            {
                label7.Visible = false;
            }
        }
    }
}
