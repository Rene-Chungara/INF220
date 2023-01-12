using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CApp;

namespace wApp
{
    public partial class FPila2 : Form
    {
        public FPila2()
        {
            InitializeComponent();
        }
        clsPila2 p = new clsPila2();

        private void FPila2_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int elem = int.Parse(textBox1.Text);
            p.Add(elem);
            lblElemento.Text = p.Imprimir();
        }
    }
}
