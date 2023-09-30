using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Formadministrador : Form
    {
        public Formadministrador()
        {
            InitializeComponent();
        }

        SqlConnection Conexion;
        SqlDataReader Leer;

        public void leer()
        {
            string CadenadeConexion = "Data Source=DESKTOP-FUUIGHB\\SQLEXPRESS;Initial Catalog=usuarios;integrated security=true";
            Conexion = new SqlConnection(CadenadeConexion);
            Conexion.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            leer();
            string Insertar = "INSERT INTO probedores VALUES(@Nombre,@Producto,@Telefono,@Dirección,@Correo)";
            SqlCommand Comando1 = new SqlCommand(Insertar, Conexion);
            Comando1.Parameters.AddWithValue("@Nombre", textBox1.Text);
            Comando1.Parameters.AddWithValue("@Producto", textBox2.Text);
            Comando1.Parameters.AddWithValue("Telefono", textBox3.Text);
            Comando1.Parameters.AddWithValue("@Dirección", textBox4.Text);
            Comando1.Parameters.AddWithValue("@Correo", textBox5.Text);
            Comando1.ExecuteNonQuery();
            Conexion.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Registro_de_productos producto = new Registro_de_productos();
            producto.Show();
        }
    }
}
