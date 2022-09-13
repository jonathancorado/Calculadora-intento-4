using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_intento_4
{
    public enum Operaciones
    {
        NoDefinida = 0,
        Suma = 1,
        Resta = 2,
        Multiplicar = 3,
        Dividir = 4,
        Modulo = 5,
    }
    public partial class Form1 : Form
    {
        double valor1 = 0;
        double valor2 = 0;
        Operaciones Operador = Operaciones.NoDefinida;

        public Form1()
        {
            InitializeComponent();
        }
        private void LeerNumero(string numero)
        {
            if (Resultados.Text == "0" && Resultados.Text != null)
            {
                Resultados.Text = numero;
            }
            else
            {
                Resultados.Text += numero;
            }
        }

        private double EjecutarOper()
        {
            double Resultado = 0;
            switch (Operador)
            {
                case Operaciones.Suma:
                    Resultado = valor1 + valor2;
                    break;
                case Operaciones.Resta:
                    Resultado = valor1 - valor2;
                    break;
                case Operaciones.Multiplicar:
                    Resultado = valor1 * valor2;
                    break;
                case Operaciones.Dividir:
                    
                    if (valor2 == 0)
                    {
                        MessageBox.Show("No se puede Dividir entre 0");
                        Resultado = 0;
                    }
                    else
                    {
                        Resultado = valor1 / valor2;
                    }
                    break;
                case Operaciones.Modulo:
                    Resultado = valor1 % valor2;
                    break;
            }

            return Resultado;
        }

        private void btnCERO_Click(object sender, EventArgs e)
        {
            if (Resultados.Text == "0")
            {
                return;
            }
            else
            {
                Resultados.Text += "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LeerNumero("1");
        }

        private void btnDOS_Click(object sender, EventArgs e)
        {
            LeerNumero("2");
        }

        private void btnTRES_Click(object sender, EventArgs e)
        {
            LeerNumero("3");
        }

        private void btnCUATRO_Click(object sender, EventArgs e)
        {
            LeerNumero("4");
        }

        private void btnCINCO_Click(object sender, EventArgs e)
        {
            LeerNumero("5");
        }

        private void btnSEIS_Click(object sender, EventArgs e)
        {
            LeerNumero("6");
        }

        private void btnSIETE_Click(object sender, EventArgs e)
        {
            LeerNumero("7");
        }

        private void btnOCHO_Click(object sender, EventArgs e)
        {
            LeerNumero("8");
        }

        private void btnNUEVE_Click(object sender, EventArgs e)
        {
            LeerNumero("9");
        }

        private void ObtenerValor(string operador)
        {
            valor1 = Convert.ToDouble(Resultados.Text);
            Historial.Text = Resultados.Text + operador;
            Resultados.Text = "0";
        }

        private void btnMAS_Click(object sender, EventArgs e)
        {
            Operador = Operaciones.Suma;
            ObtenerValor("+");

        
        }

        private void btnIGUAL_Click(object sender, EventArgs e)
        {
            if (valor2 == 0)
            {
                valor2 = Convert.ToDouble(Resultados.Text);
                Historial.Text += valor2 + "=";
                double Resultado = EjecutarOper();

                valor1 = 0;
                valor2 = 0;

                Resultados.Text = Convert.ToString(Resultado);
            }
        }

        private void btnMENOS_Click(object sender, EventArgs e)
        {
            Operador = Operaciones.Resta;
            ObtenerValor("-");
        }

        private void btnMULTIPLICAR_Click(object sender, EventArgs e)
        {
            Operador = Operaciones.Multiplicar;
            ObtenerValor("X");
        }

        private void btnDIVIDIR_Click(object sender, EventArgs e)
        {
            Operador = Operaciones.Dividir;
            ObtenerValor("/");
        }

        private void btnMODULO_Click(object sender, EventArgs e)
        {
            Operador = Operaciones.Modulo;
            ObtenerValor("%");
        }

        private void btnRESEAT_Click(object sender, EventArgs e)
        {
            Resultados.Text = "0";
            Historial.Text = "";
        }

        private void bntBORRAR_Click(object sender, EventArgs e)
        {
          

            
        }
    }
}
