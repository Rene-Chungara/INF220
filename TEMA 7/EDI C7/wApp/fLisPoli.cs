﻿using System;
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
    public partial class fLisPoli : Form
    {
        public fLisPoli()
        {
            InitializeComponent();
        }

        clsLisPoly P = new clsLisPoly();
        clsLisPila S = new clsLisPila();
        clsLisPila SI = new clsLisPila();
        private void button1_Click(object sender, EventArgs e)
        {
            P=P.PilaToLista(S);
            Salida2.Text = P.Imprimir();
        }

       
        private void fLisPoli_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            S=S.Add(Convert.ToInt32(textBox1.Text));
            Salida1.Text = S.Imprimir();
            textBox1.Clear();
        }
    }
}
