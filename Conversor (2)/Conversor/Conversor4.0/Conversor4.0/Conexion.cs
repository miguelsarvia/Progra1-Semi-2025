using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //Esta es la libreria que me permite usar comandos para trabajar con Bases de datos.
using System.Data.SqlClient; // Esta librerias me permite trabajar con SQL Server.

namespace Conversor4._0
{
    internal class Conexion
    {
        //Definir los miembros de la clase Conexion de atributos y metodos.
        public SqlConnection objConexion = new SqlConnection(); //CONECTARME A BASE DE DATOS.
        public SqlCommand objComando = new SqlCommand(); //Ejecutar SQL A LA BASE DE DATOS. Actualizar, eliminar, insertar, consultar.
        public SqlDataAdapter objAdaptador = new SqlDataAdapter(); //Un puente entre la base de datos y el DaraSet y la aplicacion.
        DataSet objDs = new DataSet(); //Es una representacion de la arquitectura de bases de datos en memoria.

        public Conexion()
           
        { //Constructor. inicializador de los atributos
            String cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
            objConexion.ConnectionString = cadenaConexion;
            objConexion.Open(); //Abrir la conexion a la BD
        }
        public DataSet obtenerDatos()
        {
            objDs.Clear(); //Limpiar el DataSet
            objComando.Connection = objConexion; //Establecer la conexion para ejecutar los comandos.

            objAdaptador.SelectCommand = objComando; //Establecer el comando de seleccion

            objComando.CommandText = "SELECT * FROM alumnos";
            objAdaptador.Fill(objDs, "alumnos");//Tomando los datos de la BD y llenando el DataSet


            objComando.CommandText = "SELECT * FROM materias";
            objAdaptador.Fill(objDs, "materias");//Tomando los datos de la BD y llenando el DataSet

            objComando.CommandText = "SELECT * FROM docentes";
            objAdaptador.Fill(objDs, "Docentes");//Tomando los datos de la BD y llenando el DataSet

            objComando.CommandText = "SELECT * FROM usuarios";
            objAdaptador.Fill(objDs, "Usuarios");//Tomando los datos de la BD y llenando el DataSet


            return objDs;
        }

        public string administrarDatosAlumnos(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO alumnos(codigo,nombre,direccion,telefono) VALUES ('"+ datos[1] +"', '"+ datos[2] +"', '"+ datos[3] +"', '"+ datos[4] +"')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE alumnos SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', direccion='" + datos[3] + "', telefono='" + datos[4] + "' WHERE IdAlumno='" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM alumnos WHERE IdAlumno='" + datos[0] + "'";
            }
            return ejecutarSQL(sql);
        }

        public string administrarDatosMaterias(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO materias(codigo,nombre,uv) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE materias SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', uv='" + datos[3] + "' WHERE idMateria='" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM materias WHERE idMateria='" + datos[0] + "'";
            }
            return ejecutarSQL(sql);
        }
        public string administrarDatosDocentes(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO materias(codigo,nombre,direccion,numero) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "', '" + datos[4] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE docentes SET codigo='" + datos[1] + "', nombre='" + datos[2] + "', direccion='" + datos[3] + "', numero='" + datos[4] + "' WHERE idDocemtes='" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM docentes WHERE idDocentes='" + datos[0] + "'";
            }
            return ejecutarSQL(sql);
        }


        public string administrarDatosUsuarios(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                // Cambia 'usuario', 'contrasena', 'rol' por los nombres reales de columnas en tu tabla usuarios
                sql = "INSERT INTO usuarios(usuario,contrasena,rol) VALUES ('" + datos[1] + "', '" + datos[2] + "', '" + datos[3] + "')";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE usuarios SET usuario='" + datos[1] + "', contrasena='" + datos[2] + "', rol='" + datos[3] + "' WHERE idUsuario='" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE FROM usuarios WHERE idUsuario='" + datos[0] + "'";
            }
            return ejecutarSQL(sql);
        }



        public String ejecutarSQL(String sql)
        {
            try
            {
                objComando.Connection = objConexion;
                objComando.CommandText = sql;

                return objComando.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
