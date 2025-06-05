using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (double.TryParse(textBox1.Text, out double celsius))
            {
                double fahrenheit = (celsius * 9 / 5) + 32;
                label1.Text = $"Fahrenheit: {fahrenheit:F2}°F";
                label1.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                label1.Text = "Error: Ingrese un número válido";
                 label1.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
