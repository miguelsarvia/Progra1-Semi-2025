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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 objAlumnos = new Form1();
            objAlumnos.MdiParent = this;
            objAlumnos.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMaterias objMaterias = new frmMaterias();
            objMaterias.MdiParent = this;
            objMaterias.Show();
        }

        private void periodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPeriodos objPeriodos = new frmPeriodos();
            objPeriodos.MdiParent = this;
            objPeriodos.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDocentes objDocentes = new frmDocentes();
            objDocentes.MdiParent = this;
            objDocentes.Show();
        }
    }
}
