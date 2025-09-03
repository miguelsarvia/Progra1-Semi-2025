using System;
using System.Data;
using System.Windows.Forms;

namespace Conversor4._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Tabla de Impuestos (fuera de los métodos)
        private double[][] tablaImpuesto = {
            new Double[] {0.01,  500, 1.5, 0 },
            new Double[] { 500.01,1000 ,1.5, 3 },
            new Double[] { 1000.01,2000 ,3 ,3 },
            new Double[] { 2000.01 , 3000 , 6 ,3 },
            new Double[] { 3000.01 , 6000 , 9 , 2 },
            new Double[] { 8000.01 , 18000 , 15 , 2 },
            new Double[] { 18000.01, 30000 , 39 , 2 },
            new Double[] { 30000.01, 60000 ,  63 , 1 },
            new Double[] { 60000.01 , 100000 , 93 , 0.8 },
            new Double[] { 100000.01  ,  200000 , 125 , 0.7 },
            new Double[] { 200000.01  ,  300000 , 195 , 0.6 },
            new Double[] { 300000.01   , 400000,  255 , 0.45 },
            new Double[] { 400000.01  ,  500000 , 300 , 0.4 },
            new Double[] { 500000.01  ,  1000000 , 340 , 0.30 },
            new Double[] { 1000000.01 ,  99999999  ,  490 , 0.18 },
        };


        private double CalcularImpuesto(double monto)
        {
            foreach (var tramo in tablaImpuesto)
            {
                double desde = tramo[0];
                double hasta = tramo[1];
                double precio = tramo[2];
                double adicional = tramo[3];

                if (monto >= desde && monto <= hasta)
                {
                    return (monto - desde) / 1000 * adicional  + precio;
                }
            }
            return 0;
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            double monto;
            if (double.TryParse(txtNumero.Text, out monto))
            {
                double impuesto = CalcularImpuesto(monto);
                if (impuesto == 0)
                    lblResultados.Text = "No se encontró un tramo de impuesto para el monto ingresado.";
                else
                    lblResultados.Text = $"El impuesto a pagar es: {impuesto:C2}";
            }
           
            else
            {
                MessageBox.Show("Por favor ingrese un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}