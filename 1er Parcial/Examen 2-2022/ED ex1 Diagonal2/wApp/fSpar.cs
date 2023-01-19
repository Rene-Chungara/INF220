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
    public partial class fSpar : Form
    {
        public fSpar()
        {
            InitializeComponent();
        }

        int[,] A = {
                     { 0, 1, 0 , 0, 0, 0 , 0},           
                     { 0, 0, 1 , 0, 0, 1 , 0}, 
                     { 0, 0, 0 , 3, 0, 0 , 1},
                     { 0, 0, 0 , 0, 0, 0 , 2},
                     { 0, 0, 1 , 5, 0, 0 , 0},
                     { 0, 0, 0 , 0, 0, 1 , 0},
                     { 2, 0, 0 , 0, 0, 0 , 0},
                   };

        clsSpar S = new clsSpar();
        clsCola Q = new clsCola();
        private void fSpar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            S.n = 7;       // Fila
            S.m = 7;       // Columna
            label1.Text = S.MostraArreglo(A);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            S = S.SparceA(A);
            label2.Text = S.MostrarVector();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Q = S.DiagonalSeg(S.SP);
            label3.Text = Q.Imprimir();
        }
    }
}
