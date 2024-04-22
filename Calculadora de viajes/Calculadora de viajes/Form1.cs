using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_viajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double origen = double.Parse(textorigen.Text);
            double velocidad = double.Parse(textvelocidad.Text);


            double calculareltiempo = origen / velocidad;

            textBox1.Text = calculareltiempo.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textvelocidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
