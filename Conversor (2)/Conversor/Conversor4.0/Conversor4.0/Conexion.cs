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
        SqlConnection objConexion = new SqlConnection(); //CONECTARME A BASE DE DATOS.
        SqlCommand objComando = new SqlCommand(); //Ejecutar SQL A LA BASE DE DATOS. Actualizar, eliminar, insertar, consultar.
        SqlDataAdapter objAdaptador = new SqlDataAdapter(); //Un puente entre la base de datos y el DaraSet y la aplicacion.
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

            objComando.CommandText = "SELECT * FROM docente";
            objAdaptador.Fill(objDs, "docente");//Tomando los datos de la BD y llenando el DataSet


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
            return ejecutarSQL(sql, datos);
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
            return ejecutarSQL(sql, datos);
        }
        private String ejecutarSQL(String sql, String[] datos)
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
