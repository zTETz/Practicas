﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using CapaEntidades;
using System.Data.SqlClient; //nugget instalado
using System.Linq;

namespace Capa3AccesoDatos {
    public class DAProducto {
        //atributos
        private string _cadenaConexion;
        private string _mensaje;

        //Constructor
        public DAProducto(string cadenaConexion) {
            _cadenaConexion = cadenaConexion;
            _mensaje = "";
        }

        //propiedades
        public string Mensaje {
            get => _mensaje;
        }

        public int Insertar(EntidadProducto producto) {
            int id = 0;

            //Establecer el objeto conexion
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            //Establecer el objeto command para crear los comandos
            SqlCommand comando = new SqlCommand();
            //Asignar la conexion al command
            comando.Connection = conexion;
            //crear la sentencia
            string sentencia = "INSERT INTO Productos(Descripcion, PrecioCompra, PrecioVenta,Gravado) VALUES " +
                "(@direccion,@precioCompra,@precioVenta,@gravado) select @@identity";
            comando.Parameters.AddWithValue("@direccion", producto.Descripcion);
            comando.Parameters.AddWithValue("@precioCompra", producto.PrecioCompra);
            comando.Parameters.AddWithValue("@precioVenta", producto.PrecioVenta);
            comando.Parameters.AddWithValue("@gravado", producto.Gravado);

            comando.CommandText = sentencia;
            try {
                conexion.Open();// se abre la conexion
                id = Convert.ToInt32(comando.ExecuteScalar()); // nos devuelve un dato
                conexion.Close();
            } catch (Exception) {
                throw;
            } finally {
                conexion.Dispose();
                comando.Dispose();
            }


            return id;
        }

        //Devuelve un DATASET con datos de clientes, SOLO para ser mostrados en el DataGridView
        public DataSet ListarProductos(string condicion = "", string orden = "") {
            DataSet datos = new DataSet(); //en "datos" se va aguardar los resultados del select
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;

            string sentencia = "SELECT ID_Producto, Descripcion, PrecioCompra, PrecioVenta, Gravado FROM Productos";

            //Si el parametro de condicion no esta vacio, lo concatena a la sentencia
            if (!string.IsNullOrEmpty(condicion)) {
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }
            //para orden
            if (!string.IsNullOrEmpty(orden)) {
                sentencia = string.Format("{0} order by {1}", sentencia, orden);
            }
            //se ejecuta
            try {
                adapter = new SqlDataAdapter(sentencia, conexion);
                //el adapter .fill llena "adapter" con los datos del dataset "datos" y le asigna el nombre "clientes
                //"
                adapter.Fill(datos, "Productos");
            } catch (Exception) {
                throw;
            }
            return datos; //devuelve el dataset

        }//FIN LISTAR PRODUCTOS

        public EntidadProducto ObtenerProducto(int id) {
            EntidadProducto producto = null;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader; //el data reader no tiene constructor se llena mediante un excecute
            string sentencia = string.Format("SELECT ID_Producto, Descripcion, PrecioCompra, PrecioVenta, Gravado FROM Productos WHERE ID_Producto = {0}", id);
            //si el id es texto se debe de escribir entre comillas '{0}' en el string
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try {
                conexion.Open();
                dataReader = comando.ExecuteReader();
                if (dataReader.HasRows) {
                    producto = new EntidadProducto();
                    dataReader.Read(); //lee fila por fila el data rader
                    producto.Id_producto = dataReader.GetInt32(0);
                    producto.Descripcion = dataReader.GetString(1);
                    producto.PrecioCompra = dataReader.GetDouble(2);
                    producto.PrecioVenta = dataReader.GetDouble(3);
                    producto.Gravado = dataReader.GetString(4);
                }
                conexion.Close();
            } catch (Exception) {
                throw;
            }
            return producto;
        }

    }
}
