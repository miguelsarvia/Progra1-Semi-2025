using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor4._0
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
        /*
       Monedas
       Longitud
       Masa
       Volumen
       Almacenamiento
       Tiempo
        */

        String[][] etiquetas = new string[][] {
            new string[]{"Dolar", "Pesos Mexicanos", "Quetzal", "Lempira", "Colon SV", "Cordobas", "Colon CR"}, //Monedas
            new string[]{"Metros", "Cm", "Pulgadas","Pie", "Varas", "Yardas", "Km", "Millas"}, //Longitud
            new string[]{"Libra", "Onza", "Gramo", "Kg", "Quintal", "Tonelada Corta"}, //Masa
            new string[]{"Galon Us", "Litros", "Pinta Us", "Ml"}, //Volumen
            new string[]{"GB", "Bit", "Byte", "KB", "MG", "TB"}, //Almacenamiento
            new string[]{"Dia", "Segundos", "Minutos", "Horas", "Semana", "Meses", "Año"}, //Tiempo
        };
        double[][] valores = new double[][] {
            new double []{1,18.78, 7.66, 26.15, 8.75, 36.78, 504.12}, //Monedas
            new double []{1, 100, 39.37, 3.28084, 1.193, 1.09361, 0.001, 0.000621371}, //Longitud
            new double []{1, 16, 453.592, 0.453592, 0.01, 0.001,0.0005}, //Masa
            new double []{1, 3.78541, 8, 3785.41}, //Volumen
            new double []{1, 8e+9, 1e+9, 1e+6, 1000, 0.001}, //Almacenamiento
            new double []{1, 86400, 1440, 24, 0.142857, 0.0328767, 0.00273973}, //Tiempo
        };

        private void btnConvertir_Click_1(object sender, EventArgs e)
        {
            double cantidad = double.Parse(txtCantidadConversor.Text);

            int tipo = cboTipoConversor.SelectedIndex;

            int de = cboDeConversor.SelectedIndex;

            int a = cboAConversor.SelectedIndex;

            double respuesta = cantidad * valores[tipo][a] / valores[tipo][de];

            lblRespuestaConversor.Text = "RESPUESTA: " + respuesta.ToString("N2");
        }

        private void cboTipoConversor_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                cboDeConversor.Items.Clear();
                cboAConversor.Items.Clear();

                cboDeConversor.Items.AddRange(etiquetas[cboTipoConversor.SelectedIndex]);
                cboAConversor.Items.AddRange(etiquetas[cboTipoConversor.SelectedIndex]);
            }
        }
    }
}