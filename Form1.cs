using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void limpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DATOS GUARDOS");
        }
        private void validar_Click(object sender, EventArgs e)
        {

        }
    }
}
