﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = ComunDB.ObtenerConexion();

            string Insertar = "INSERT INTO probedores VALUES(@Nombre,@Producto,@Telefono,@Dirección,@Correo)";
            SqlCommand Comando2 = new SqlCommand(Insertar, Conexion);
            Comando2.Parameters.AddWithValue("@Nombre", textBox1.Text);
            Comando2.Parameters.AddWithValue("@Producto", textBox2.Text);
            Comando2.Parameters.AddWithValue("@Telefono", textBox3.Text);
            Comando2.Parameters.AddWithValue("@Dirección", textBox4.Text);
            Comando2.Parameters.AddWithValue("@Correo", textBox5.Text);
            Comando2.ExecuteNonQuery();
            Conexion.Close();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }
    }
}
