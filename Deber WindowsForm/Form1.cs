using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deber_WindowsForm
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

        private void button2_Click(object sender, EventArgs e)
        {
            string valor = txtTemperature1.Text.Trim();


            if (double.TryParse(valor, out double temperature))
            {
                // Verificar cuál CheckBox está marcado
                if (checkCelsius.Checked == true)
                {
                    double fahrenheit = (temperature * 1.8) + 32;
                    response.Text = $"{temperature} °C = {fahrenheit:F2} °F";

                    MessageBox.Show($"{temperature} °C = {fahrenheit:F2} °F");
                }
                if (checkFahrenheit.Checked == true)
                {
                    double celsius = (temperature - 32) / 1.8;
                    response.Text = $"{temperature} °F = {celsius:F2} °C";
                    MessageBox.Show($"{temperature} °F = {celsius:F2} °C");
                }

            }

            else
            {
                MessageBox.Show("Por favor, ingresa un valor numérico válido.");
            }
        }
    }
}



