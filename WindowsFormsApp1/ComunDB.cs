using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class ComunDB
    {
        //creamos nuestra conexion a la base de datos.

        public int resultado;
        const string StringDeConexion = "Data Source=DESKTOP-FUUIGHB\\SQLEXPRESS;Initial Catalog=usuarios;integrated security=true";

        //Le desimos que la base va hacer de tipo static y le decimos que sera de tipo abierta
        public static SqlConnection ObtenerConexion()
        {
            SqlConnection _conexion= new SqlConnection(StringDeConexion);
            _conexion.Open();
            return _conexion;
        }

        public static int EjecutarComando(string pConsulta)
        {
            SqlConnection _conexion = ObtenerConexion();

            //Creamos comando para insertar registros
            SqlCommand _comando= new SqlCommand(pConsulta,_conexion);

            // esto insertara la insercion de registro
            int resultado = _comando.ExecuteNonQuery();

            //cerramos conexion
            _conexion.Close();
            return resultado;
        }

        public static SqlDataReader EjecutarComandoReader(string pConsulta)
        {
            SqlConnection _conexion = ObtenerConexion();
            SqlCommand _comando = new SqlCommand(pConsulta, _conexion);
            SqlDataReader _reader =
            _comando.ExecuteReader(CommandBehavior.CloseConnection);
            return _reader;
        }


    }
}
