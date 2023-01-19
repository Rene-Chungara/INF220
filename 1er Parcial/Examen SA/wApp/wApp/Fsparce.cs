using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cApp;

namespace wApp
{
    public partial class Fsparce : Form
    {
        public Fsparce()
        {
            InitializeComponent();
        }
        int[,] Z = {
                     { 0, 0, 0 , 0, 0, 0 , 5},
                     { 0, 0, 1 , 0, 0, 1 , 0},
                     { 0, 0, 0 , 3, 0, 0 , 1},
                     { 8, 0, 0 , 0, 0, 0 , 2},
                     { 0, 0, 1 , 5, 0, 0 , 0},
                     { 0, 5, 0 , 0, 0, 1 , 0},
                     { 2, 0, 0 , 0, 0, 0 , 0},
         };
        clsSpar S = new clsSpar();
        clsPila P = new clsPila();

        private void Msparce_Click(object sender, EventArgs e)
        {
            S.n = 7;       // Fila de la matriz
            S.m = 7;       // Columna la matriz
            lblMatriz.Text = S.MostraArreglo(Z);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            S = S.CopyZtoPS(Z);
            lblPS.Text = S.MostrarVector();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            P = S.DiagonalSegunda(S.PS);
            lblPila.Text = P.Imprimir();
        }

        private void lblPS_Click(object sender, EventArgs e)
        {

        }
    }
}
