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
            
            factores["Superficie"] = new Dictionary<string, double>
            {
                { "Metro cuadrado", 1 },
                {"Vara cuadrada", 0.835464 },
                {"Tarea", 437.5 },
                { "Pie cuadrado", 0.092903 },
                { "Yarda cuadrada", 0.836127 },
                {"Manzana", 6988},
                { "Hectárea", 10000 },
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
