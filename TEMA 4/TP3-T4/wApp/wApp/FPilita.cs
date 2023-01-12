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
    public partial class FPilita : Form
    {
        public FPilita()
        {
            InitializeComponent();
        }
        clsPila2 p = new clsPila2();

        private void button1_Click(object sender, EventArgs e)
        {
            int elem = int.Parse(textBox1.Text);
            p.Add(elem);
            lblElem.Text = p.Imprimir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int elem = int.Parse(textBox1.Text);
            p.Add2(elem);
            lblElem.Text = p.Imprimir();
        }
    }
}
