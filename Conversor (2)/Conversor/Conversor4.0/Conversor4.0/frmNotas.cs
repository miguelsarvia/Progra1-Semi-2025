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
    public partial class frmNotas : Form
    {
        public frmNotas()
        {
            InitializeComponent();
        }

        private void notasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.notasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.db_academicaDataSet);

        }

        private void frmNotas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'db_academicaDataSet.notas' Puede moverla o quitarla según sea necesario.
            this.notasTableAdapter.Fill(this.db_academicaDataSet.notas);

        }
    }
}
