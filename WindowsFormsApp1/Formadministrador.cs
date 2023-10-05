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

        private void button3_Click(object sender, EventArgs e)
        {
            Registro_de_productos producto = new Registro_de_productos();
            producto.Show();
        }

        private void Formadministrador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'usuariosDataSet1.probedores' Puede moverla o quitarla según sea necesario.
            this.probedoresTableAdapter.Fill(this.usuariosDataSet1.probedores);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //para actualizar nuestro grid donde se muestran los resultados
            //llamamos a la nuestra conexion de la clase ComunDB
            SqlConnection Conexion = ComunDB.ObtenerConexion();

            SqlCommand Comando = new SqlCommand("SELECT * from probedores",Conexion);
            SqlDataAdapter xadaptadorDatos = new SqlDataAdapter(Comando);
            DataTable xDataTable = new DataTable();
            xadaptadorDatos.Fill(xDataTable);
            dataGridView1.DataSource = xDataTable;
            Conexion.Close();

        }
    }
}
