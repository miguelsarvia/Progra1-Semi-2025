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
        private readonly Dictionary<string, Dictionary<string, double>> factores = new Dictionary<string, Dictionary<string, double>>();

        public Form1()
        {
            InitializeComponent();
            InicializarConversores();
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            btnConvertir.Click += btnConvertir_Click;
        }

        private void InicializarConversores()
        {
            factores["Monedas"] = new Dictionary<string, double>
            {
                { "USD", 1},
                { "EUR", 0.91 },
                { "JPY", 155 },
                { "GBP", 0.78 },
                { "CAD", 1.36 },
                { "MXN", 16.0 },
                { "CNY", 7.3 },
                { "BRL", 5.2 },
                { "INR", 83.2 },
                { "CLP", 930 }
            };

            factores["Masa"] = new Dictionary<string, double>
            {
                { "Kilogramo", 1 },
                { "Gramo", 0.001 },
                { "Tonelada", 1000 },
                { "Libra", 0.453592 },
                { "Onza", 0.0283495 },
                { "Stone", 6.35029 },
                { "Miligramo", 0.000001 },
                { "Microgramo", 1e-9 },
                { "Quintal", 100 },
                { "Slug", 14.5939 }
            };

            factores["Volumen"] = new Dictionary<string, double>
            {
                { "Litro", 1 },
                { "Mililitro", 0.001 },
                { "Metro cúbico", 1000 },
                { "Galón (US)", 3.78541 },
                { "Galón (UK)", 4.54609 },
                { "Pinta", 0.473176 },
                { "Onza líquida", 0.0295735 },
                { "Cucharada", 0.0147868 },
                { "Cucharadita", 0.00492892 },
                { "Barril", 159 }
            };

            factores["Longitud"] = new Dictionary<string, double>
            {
                { "Metro", 1 },
                { "Centímetro", 0.01 },
                { "Milímetro", 0.001 },
                { "Kilómetro", 1000 },
                { "Pulgada", 0.0254 },
                { "Pie", 0.3048 },
                { "Yarda", 0.9144 },
                { "Milla", 1609.34 },
                { "Micrómetro", 1e-6 },
                { "Nanómetro", 1e-9 }
            };

            factores["Almacenamiento"] = new Dictionary<string, double>
            {
                { "Byte", 1 },
                { "Kilobyte", 1024 },
                { "Megabyte", 1024 * 1024 },
                { "Gigabyte", 1024 * 1024 * 1024 },
                { "Terabyte", Math.Pow(1024, 4) },
                { "Petabyte", Math.Pow(1024, 5) },
                { "Bit", 0.125 },
                { "Nibble", 0.5 },
                { "Word (16-bit)", 2 },
                { "Block (512B)", 512 }
            };

            factores["Tiempo"] = new Dictionary<string, double>
            {
                { "Segundo", 1 },
                { "Minuto", 60 },
                { "Hora", 3600 },
                { "Día", 86400 },
                { "Semana", 604800 },
                { "Mes (30d)", 2592000 },
                { "Año (365d)", 31536000 },
                { "Milisegundo", 0.001 },
                { "Microsegundo", 1e-6 },
                { "Nanosegundo", 1e-9 }
            };

            cmbTipo.Items.AddRange(factores.Keys.ToArray());
            if (cmbTipo.Items.Count > 0)
                cmbTipo.SelectedIndex = 0;
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cmbTipo.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tipo)) return;

            cmbOrigen.Items.Clear();
            cmbDestino.Items.Clear();

            var claves = factores[tipo].Keys.ToArray();
            cmbOrigen.Items.AddRange(claves);
            cmbDestino.Items.AddRange(claves);

            if (cmbOrigen.Items.Count > 0) cmbOrigen.SelectedIndex = 0;
            if (cmbDestino.Items.Count > 1) cmbDestino.SelectedIndex = 1;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                string tipo = cmbTipo.SelectedItem.ToString();
                string origen = cmbOrigen.SelectedItem.ToString();
                string destino = cmbDestino.SelectedItem.ToString();

                if (!double.TryParse(txtValor.Text, out double valor))
                    throw new Exception("Valor inválido.");

                double factorOrigen = factores[tipo][origen];
                double factorDestino = factores[tipo][destino];

                double resultado;

                if (tipo == "Monedas")
                {
                    double valorEnUSD = valor / factorOrigen;
                    resultado = valorEnUSD * factorDestino;
                }
                else
                {
                    resultado = valor * factorOrigen / factorDestino;
                }

                lblResultado.Text = $"{valor} {origen} = {resultado:F4} {destino}";
            }
            catch
            {
                MessageBox.Show("Verifica que todos los campos estén llenos correctamente.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click_1(object sender, EventArgs e)
        {

        }
    }
}
