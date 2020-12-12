using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double resultado1, resultado2;
        string operacion = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Numerador_Click(object sender, EventArgs e)
        { 
            string textoBoton = ((Button)sender).Text;
            switch (textoBoton)
            {
                case "R":
                    if (Pantalla.Text == "")
                    {
                        break;
                    }
                    resultado1 = double.Parse(Pantalla.Text);
                    double valor1 = Math.Sqrt(resultado1);
                    Pantalla.Text = valor1 + "";
                    break;
                case "ln":
                    if (Pantalla.Text == "")
                    {
                        break;
                    }
                    resultado2 = double.Parse(Pantalla.Text);
                    double valor2 = Math.Log(resultado2);
                    Pantalla.Text = valor2 + "";
                    break;
                case "Log10":
                    if (Pantalla.Text == "")
                    {
                        break;
                    }
                    resultado1 = double.Parse(Pantalla.Text);
                    double valor3 = Math.Log10(resultado1);
                    Pantalla.Text = valor3 + "";
                    break;
                case "Tan":
                    if (Pantalla.Text == "")
                    {
                        break;
                    }
                    resultado1 = double.Parse(Pantalla.Text);
                    double valor4 = Math.Tan(resultado1);
                    Pantalla.Text = valor4 + "";
                    break;
                case "Sin":
                    if (Pantalla.Text == "")
                    {
                        break;
                    }
                    resultado1 = double.Parse(Pantalla.Text);
                    double valor5 = Math.Sin(resultado1);
                    Pantalla.Text = valor5 + "";
                    break;
                case "Cos":
                    if (Pantalla.Text == "")
                    {
                        break;
                    }
                    resultado1 = double.Parse(Pantalla.Text);
                    double valor6 = Math.Cos(resultado1);
                    Pantalla.Text = valor6 + "";
                    break;
                case "+":
                    if (Pantalla.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    resultado1 = double.Parse(Pantalla.Text);
                    Pantalla.Text = "";
                    break;
                case "-":
                    if (Pantalla.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    resultado1 = double.Parse(Pantalla.Text);
                    Pantalla.Text = "";
                    break;
                case "X":
                    if (Pantalla.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    resultado1 = double.Parse(Pantalla.Text);
                    Pantalla.Text = "";
                    break;
                case "/":
                    if (Pantalla.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    resultado1 = double.Parse(Pantalla.Text);
                    Pantalla.Text = "";
                    break;
                case "=":
                    switch (operacion)
                    {
                        case "+":
                            if (Pantalla.Text == "")
                            {
                                break;
                            }
                            resultado2 = double.Parse(Pantalla.Text);
                            Pantalla.Text = (resultado1 +resultado2) + "";
                            break;
                        case "-":
                            if (Pantalla.Text == "")
                            {
                                break;
                            }
                            resultado2 = double.Parse(Pantalla.Text);
                            Pantalla.Text = (resultado1 - resultado2) + "";
                            break;
                        case "X":
                            if (Pantalla.Text == "")
                            {
                                break;
                            }
                            resultado2 = double.Parse(Pantalla.Text);
                            Pantalla.Text = (resultado1 * resultado2) + "";
                            break;
                        case "/":
                            if (Pantalla.Text == "")
                            {
                                break;
                            }
                            resultado2 = double.Parse(Pantalla.Text);
                            Pantalla.Text = (resultado1 / resultado2) + "";
                            break;
                    }
                    break;
                case "C":
                    Pantalla.Text = "";
                    break;
                case ".":
                    if (Pantalla.Text.IndexOf(".") == -1)
                    {
                        Pantalla.Text += textoBoton;
                    }
                    break;
                default:
                    Pantalla.Text += textoBoton;
                    break;
            }
        }

    }
}
