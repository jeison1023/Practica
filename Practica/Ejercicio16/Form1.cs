using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio16
{
    public partial class Form1 : Form
    {
        private double Valor1;
        private double Valor2;
        private double resultados;
        private int operciones;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            //Elemininar
            txtdisplay.Text = "";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //Numero 1
            txtdisplay.Text = txtdisplay.Text + "1";

        }

        private void btnpunto_Click(object sender, EventArgs e)
        {
            // Punto
            txtdisplay.Text = txtdisplay.Text + ".";

        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            // Signo igual
            Valor2 = Convert.ToDouble(txtdisplay.Text);

            switch (operciones) // Aquí agregamos la estructura del switch
            {
                case 1:
                    resultados = Valor1 + Valor2;
                    break;
                case 2:
                    resultados = Valor1 - Valor2;
                    break;
                case 3:
                    resultados = Valor1 * Valor2;
                    break;
                case 4:
                    if (Valor2 != 0)
                        resultados = Valor1 / Valor2;
                    else
                    {
                        txtdisplay.Text = "Error: División por cero";
                        return;
                    }
                    break;
            }

            txtdisplay.Text = resultados.ToString(); // Mostrar el resultado correctamente

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //Numero 2
            txtdisplay.Text = txtdisplay.Text + "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Numero 3
            txtdisplay.Text = txtdisplay.Text + "3";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //Numero 4
            txtdisplay.Text = txtdisplay.Text + "4";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //Numero 5
            txtdisplay.Text = txtdisplay.Text + "5";

        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //Numero 6
            txtdisplay.Text = txtdisplay.Text + "6";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //Numero 7
            txtdisplay.Text = txtdisplay.Text + "7";

        }

        private void btn8_Click(object sender, EventArgs e) 
        {
            //Numero 8
            txtdisplay.Text = txtdisplay.Text + "8";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //Numero 9
            txtdisplay.Text = txtdisplay.Text + "9";

        }

        private void btdividir_Click(object sender, EventArgs e)
        {            
            //Divide
            operciones = 4;
            Valor1 = Convert.ToDouble(txtdisplay.Text);
            txtdisplay.Text = "";


        }

        private void btnmultipla_Click(object sender, EventArgs e)
        {
            //Multiplica
            operciones = 3;
            Valor1 = Convert.ToDouble(txtdisplay.Text);
            txtdisplay.Text = "";

        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            //Suma
            operciones = 1;
            Valor1 = Convert.ToDouble(txtdisplay.Text);
            txtdisplay.Text = "";

        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            //Resta
            operciones = 2;
            Valor1 = Convert.ToDouble(txtdisplay.Text);
            txtdisplay.Text = "";

        }

        private void txtdisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //Numero 0
            txtdisplay.Text = txtdisplay.Text + "0";

        }
    }
}
