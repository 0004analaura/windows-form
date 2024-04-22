using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combustible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double distanciarecorrida = double.Parse(textdistancia.Text);
            double rendimiento = double.Parse(textrendimiento.Text);

            double resultado = distanciarecorrida / rendimiento;


            textotal.Text = resultado.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
