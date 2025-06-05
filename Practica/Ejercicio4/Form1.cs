using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        private double numero1, numero2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double numero1) &
                double.TryParse(textBox2.Text, out double numero2)) ;
            {
                this.numero1 = numero1;
                this.numero2 = numero2;
                double resultado = numero1 + numero2;
                label1.Text = "El resultado es : " + resultado.ToString();
                label1.ForeColor = Color.Green;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
