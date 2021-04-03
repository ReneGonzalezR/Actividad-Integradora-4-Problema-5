using System;
using System.Windows.Forms;
/// <summary>
/// Lenguaje de programacion III
/// Autor: Rene Gonzalez Rodriguez
/// Maestro: Aarón I. Salazar
/// </summary>

namespace Actividad_Integradora_4_Problema_5
{
    public partial class Form1 : Form
    {
        int contador = 0;
        double anterior = 0;
        string[] nombre = new string[4];
        double[] salario = new double[4];

        public Form1()
        {
            InitializeComponent();
            lblContador.Text = contador.ToString();
        }

        private void btnCaptura_Click(object sender, EventArgs e)
        {
            double total = 0;
            if (contador < 4)
            {
                nombre[contador] = txtNombre.Text;
                salario[contador] = Convert.ToDouble(txtSalario.Text);
                contador++;
                lblContador.Text = contador.ToString();
                Limpiar();
            }
            else
            {
                MessageBox.Show("Ya no puede capturar mas empleados", "Alerta");
                Limpiar();
            }

            for (int i = 0; i < contador; i++)
            {
                total = total + salario[i];
                if (salario[i] > anterior)
                {
                    anterior = salario[i];
                    lblNombreSueldo.Text = nombre[i];
                }
            }
            lblTotal.Text = total.ToString();

            
        }
        private void Limpiar()
        {
            txtNombre.Text = string.Empty;
            txtNombre.Focus();
            txtSalario.Text = string.Empty;
        }
    }
}
