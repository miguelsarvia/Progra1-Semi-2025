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
    public partial class frmMaterias : Form
    {
        public frmMaterias()
        {
            InitializeComponent();
        }

        Conexion objConexion = new Conexion();
        DataSet objDs = new DataSet();
        DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        private void actualizarDs()
        {
            objDs.Clear(); //Limpiar el DataSet
            objDs = objConexion.obtenerDatos();
            objDt = objDs.Tables["materias"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idMateria"] };

            grdMaterias.DataSource = objDt.DefaultView;
            mostrarDatos();
        }
        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                idMateria.Text = objDt.Rows[posicion]["idMateria"].ToString();
                txtCodigo.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombre.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtUvMaterias.Text = objDt.Rows[posicion]["uv"].ToString();

                lblnRegistrosMateria.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }
        private void frmMaterias_Load(object sender, EventArgs e)
        {
            actualizarDs();
            cboBuscarMateria.SelectedIndex = 1; //buscar por materia
        }

        private void estadoControles(Boolean estado)
        {
            grbDatosMateria.Enabled = estado;
            grbNavegacionMateria.Enabled = !estado;
            btnEliminar.Enabled = !estado;
        }
        private void limpiarControles()
        {
            idMateria.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtUvMaterias.Text = "";
        }
        private void filtrarDatos(String valor)
        {
            try
            {
                DataView objDv = objDt.DefaultView;
                switch (cboBuscarMateria.SelectedIndex)
                {
                    case 0: //codigo
                        objDv.RowFilter = "codigo = " + valor;
                        break;

                    case 1: //nombre
                        objDv.RowFilter = "nombre like '%" + valor + "%'";
                        break;
                }
                grdMaterias.DataSource = objDv;
                seleccionarMateria();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void seleccionarMateria()
        {
            try
            {
                if (grdMaterias.CurrentRow == null)
                {
                    return;
                }
                string id = grdMaterias.CurrentRow.Cells["idMateria"].Value.ToString();
                posicion = objDt.Rows.IndexOf(objDt.Rows.Find(id));
                mostrarDatos();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void grdMaterias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarMateria();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombre.Text,
     "Eliminando materias", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objConexion.administrarDatosAlumnos(
                    new String[] { idMateria.Text, "", "", "", "" }, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar alumnos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Modificar")
            {
                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                estadoControles(true);
                accion = "modificar";

            }
            else
            {//Cancelar
                mostrarDatos();
                estadoControles(false);
                btnNuevo.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Text == "Nuevo")
            {
                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                estadoControles(true);
                accion = "nuevo";
                limpiarControles();
            }
            else
            {//Guardar
                String[] materias = {
                    idMateria.Text, txtCodigo.Text, txtNombre.Text, txtUvMaterias.Text
                };
                String respuesta = objConexion.administrarDatosMaterias(materias, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar materias.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estadoControles(false);
                    btnNuevo.Text = "Nuevo";
                    btnModificar.Text = "Modificar";
                    actualizarDs();
                }
            }
        }

        private void btnSiguienteMateria_Click(object sender, EventArgs e)
        {

            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;// posicion=posicion+1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorMateria_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;// posicion=posicion-1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoMateria_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnPrimeroMateria_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void txtBuscarMaterias_KeyUp_1(object sender, KeyEventArgs e)
        {
            try
            {
                filtrarDatos(txtBuscarMaterias.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
