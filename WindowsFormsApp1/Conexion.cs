using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class Conexion
    {

        public SqlConnection ccn = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();

        public void conectado()
        {
            ccn = new SqlConnection("Data Source=DESKTOP-FUUIGHB\\SQLEXPRESS;Initial Catalog=usuarios;integrated security=true");
            ccn.Open();
        }
    }
}
