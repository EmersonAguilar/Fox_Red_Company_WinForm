using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Formusuario : Form
    {
        public Formusuario()
        {
            InitializeComponent();
        }

        private void Formusuario_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("USB");
            comboBox1.Items.Add("Laptop");
            comboBox1.Items.Add("Audifonos");
            comboBox1.Items.Add("Teclado");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox6.Text = "USB de 1t de 3m";
                pictureBox2.Image = Properties.Resources._61T85CGI4ZL;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                textBox6.Text = "Laptop para estudio y trabajo";
                pictureBox2.Image = Properties.Resources._71EFEN6lHbL__AC_UF894_1000_QL80_;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                textBox6.Text = "Audifonos gamers";
                pictureBox2.Image = Properties.Resources.audifonos;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                textBox6.Text = "Teclado mecanico con piezas de repuesto";
                pictureBox2.Image = Properties.Resources.teclado;
            }
        }
    }
}
