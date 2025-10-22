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
    public partial class frm_Usuarios2 : Form
    {
        public frm_Usuarios2()
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
            objDt = objDs.Tables["usuarios"];
            objDt.PrimaryKey = new DataColumn[] { objDt.Columns["idUsuario"] };

            grdUsuarios.DataSource = objDt.DefaultView;
            mostrarDatos();
        }
        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0)
            {
                idUsuario.Text = objDt.Rows[posicion]["idUsuario"].ToString();
                txtUsuario.Text = objDt.Rows[posicion]["usuario"].ToString();
                txtNombre.Text = objDt.Rows[posicion]["nombre"].ToString();
                txtDireccion.Text = objDt.Rows[posicion]["direccion"].ToString();
                txtNumero.Text = objDt.Rows[posicion]["telefono"].ToString();
                txtClave.Text = objDt.Rows[posicion]["Clave"].ToString();

                lblnRegistros.Text = (posicion + 1) + " de " + objDt.Rows.Count;
            }
        }
        private void frm_Usuarios2_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;// posicion = posicion+1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el ultimo registro.", "Navegacion de Alumnos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;// posicion=posicion-1
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Estas en el primer registro.", "Navegacion de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            posicion = objDt.Rows.Count - 1;
            mostrarDatos();
        }

        private void estadoControles(Boolean estado)
        {
            grbDatosUsuarios.Enabled = estado;
            grbNavegacionUsuarios.Enabled = !estado;
            btnEliminar.Enabled = !estado;
        }
        private void limpiarControles()
        {
            idUsuario.Text = "";
            txtUsuario.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtNumero.Text = "";
            txtClave.Text = "";

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
                String[] Usuarios = {
                    idUsuario.Text, txtUsuario.Text, txtNombre.Text, txtDireccion.Text,
                    txtNumero.Text,txtClave.Text
                };
                String respuesta = objConexion.administrarDatosUsuarios(Usuarios, accion);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al guardar usuario.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
               "Eliminando usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String respuesta = objConexion.administrarDatosUsuarios(
                    new String[] { idUsuario.Text, "", "", "", "" }, "eliminar"
                );
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error al eliminar usuario.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                }
            }
        }

        private void filtrarDatos(String valor)
        {

            DataView objDv = objDt.DefaultView;
            objDv.RowFilter = "codigo like '%" + valor + "%' OR nombre like '%" + valor + "%' OR direccion like '%" + valor + "%'";
            grdUsuarios.DataSource = objDv;
            seleccionarUsuario();

        }

        private void seleccionarUsuario()
        {
            if (grdUsuarios.CurrentRow != null && grdUsuarios.Rows.Count > 0)
            {
                posicion = objDt.Rows.IndexOf(objDt.Rows.Find(grdUsuarios.CurrentRow.Cells["id"].Value));
                mostrarDatos();
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtBuscar.Text);
        }

        private void grdUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarUsuario();
        }
    }
}
