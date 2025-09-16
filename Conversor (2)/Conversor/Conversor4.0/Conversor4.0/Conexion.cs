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
            String cadenaConexion = "";
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

            return objDs;
        }
    }
}
