using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            Distancia Calculardistancia = new Distancia();
            double Distancia_ = Calculardistancia.Calculardistancia(double.Parse(x2txt.Text), double.Parse(X1txt.Text), double.Parse(y2txt.Text), double.Parse(Y1txt.Text);
            distxt.Text = Distancia.ToString();

        }
    }
}
