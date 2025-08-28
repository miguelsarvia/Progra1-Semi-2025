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

        //Matrices
        //Funciones 
        //LINQ = Language Integrado de Consultas

        double media(int[] serie)
        {
            return serie.Average();
        }
        double tipica(int[] serie, double m)
        {
            return Math.Sqrt(serie.Average(n => Math.Pow(n - m, 2)));
        }
        double armonica(int[] serie)
        {
            int n = serie.Length;
            return n / serie.Sum(num => 1.0 / num);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int[] serie = txtSerie.Text.Split(',').Select(n=>int.Parse(n)).ToArray(); //5,8,1,9 => ["5","8","1","9"]

            double mediaAritmetica = media(serie);
            double desviacionTipica = tipica(serie, mediaAritmetica);
            double mediaArmonica = armonica(serie);

            lblMedia.Text = "Media: " + mediaAritmetica.ToString();
            lblTipica.Text = "Tipica: " + desviacionTipica.ToString();
            lblArmonica.Text = "Armonica: " + mediaArmonica.ToString();
        }

    }
}