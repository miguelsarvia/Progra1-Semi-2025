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
    public partial class frmDocentes : Form
    {
        public frmDocentes()
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
            objDt = objDs.Tables["Docentes"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idDocente"] }; // <-- corregido

            grdDocentes.DataSource = objDt.DefaultView;
            mostrarDatos();
        }
        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                idDocentes.Text = objDt.Rows[posicion]["idDocente"].ToString();
                txtCodigo.Text = objDt.Rows[posicion]["codigo"].ToString();
                txtNombre.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtDireccion.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtNumero.Text = objDt.Rows[posicion]["numero"].ToString();

                lblnRegistrosDocentes.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }
        private void frmDocentes_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void btnSiguienteDocentes_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;// posicion = posicion+1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnteriorDocentes_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;// posicion=posicion-1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Docentes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoDocentes_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnPrimeroDocentes_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void estadoControles(Boolean estado)
        {
            grbAdministrarDatosDocentes.Enabled = estado;
            grbNavegacionDocentes.Enabled = !estado;
            btnEliminar.Enabled = !estado;
        }
        private void limpiarControles()
        {
            idDocentes.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtNumero.Text = "";

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
                String[] Docentes = {
                    idDocentes.Text, txtCodigo.Text, txtNombre.Text, txtDireccion.Text,
                    txtNumero.Text
                };
                String respuesta = objConexion.administrarDatosDocentes(Docentes, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar Docente.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombre.Text,
               "Eliminando Docente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objConexion.administrarDatosAlumnos(
                    new String[] { idDocentes.Text, "", "", "", "" }, "eliminar"
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

        private void txtBuscarDocentes_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtBuscarDocentes.Text);
        }

        private void filtrarDatos(String valor)
        {

            DataView objDv = objDt.DefaultView;
            objDv.RowFilter = "Codigo LIKE '%" + valor + "%' OR Nombre LIKE '%" + valor + "%' OR Direccion LIKE '%" + valor + "%'";
            grdDocentes.DataSource = objDv;
            seleccionarDocentes();

        }

        private void seleccionarDocentes()
        {
            posicion = objDt.Rows.IndexOf(objDt.Rows.Find(grdDocentes.CurrentRow.Cells["idDocente"].Value));
            mostrarDatos();
        }

        private void grdDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarDocentes();
        }
    }
}
