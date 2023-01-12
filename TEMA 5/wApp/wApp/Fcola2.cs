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
    public partial class Fcola2 : Form
    {
        public Fcola2()
        {
            InitializeComponent();
        }

        clsCola2 A = new clsCola2();

        private void button1_Click(object sender, EventArgs e)
        {
            int ele = int.Parse(textBox1.Text);
            int s = 0;
            A.Add(s, ele);
            lblMostrar.Text = A.mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int ele = int.Parse(textBox1.Text);
            int s = 1;
            A.Add(s, ele);
            lblMostrar.Text = A.mostrar();
        }
    }
}
