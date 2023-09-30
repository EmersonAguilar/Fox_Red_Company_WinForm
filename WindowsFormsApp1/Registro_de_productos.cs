using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Registro_de_productos : Form
    {
        public Registro_de_productos()
        {
            InitializeComponent();
        }

        private void Registro_de_productos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'usuariosDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.usuariosDataSet.productos);

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
            string Insertar = "INSERT INTO productos VALUES(@Nombre,@Cantidad,@Costo,@Proveedor)";
            SqlCommand Comando1 = new SqlCommand(Insertar, Conexion);
            Comando1.Parameters.AddWithValue("@Nombre", textBox1.Text);
            Comando1.Parameters.AddWithValue("@Cantidad", textBox2.Text);
            Comando1.Parameters.AddWithValue("@Costo", textBox3.Text);
            Comando1.Parameters.AddWithValue("@Proveedor", textBox4.Text);
            Comando1.ExecuteNonQuery();
            Conexion.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
