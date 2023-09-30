using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dusuario du= new Dusuario();
            Fusuario fu = new Fusuario();

            if(textusuario.Text != string.Empty && textcontraseña.Text != string.Empty)
            {
                DataTable dt = new DataTable();

                du.set_usuario(textusuario.Text);
                du.set_password(textcontraseña.Text);
                dt = fu.validar_usuario(du);

                if (dt.Rows.Count != 0)
                {
                    String nivel1;
                    nivel1 = Convert.ToString( dt.Rows[0]["tipo_usuario"]);
                    if (nivel1.Equals("Administrador"))
                    {
                        MessageBox.Show("Hola" + textusuario.Text);
                        this.Hide();
                        Formadministrador fa= new Formadministrador();
                        fa.Show();
                    }
                    else if (nivel1.Equals("Usuario"))
                    {
                        MessageBox.Show("Hola" + textusuario.Text);
                        this.Hide();
                        Formusuario us = new Formusuario();
                        us.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error");
                        
                    }
                }
                else
                {
                    MessageBox.Show("Error");
                }


            }
            else
            {
                MessageBox.Show("Ingrese datos");
            }

        }
    }
}
