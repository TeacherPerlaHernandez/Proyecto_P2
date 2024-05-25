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
     

        private void validar_Click(object sender, EventArgs e)
        {
            if (radioalumno.Checked)            
            {
                
                string nom = textBox1.Text;
                string fech = textBox2.Text;
                int edad = Convert.ToInt32(textBox3.Text);
                int mat = Convert.ToInt32(textBox4.Text);
                string carrera = textBox5.Text;
                Alumno alumno = new Alumno(nom,edad,fech,carrera,mat);
            }
            else
            {
                if (radioempleado.Checked)
                {

                    string nom = textBox1.Text;
                    string fech = textBox2.Text;
                    int edad = Convert.ToInt32(textBox3.Text);
                    int mat = Convert.ToInt32(textBox4.Text);
                    string puesto = textBox5.Text;
                    float sueldo = Convert.ToSingle(textBox6.Text);
                    Empleado empleado = new Empleado(nom, edad, fech, puesto, sueldo);
                }
                else if (radiodocente.Checked)
                {
                    string nom = textBox1.Text;
                    string fech = textBox2.Text;
                    int edad = Convert.ToInt32(textBox3.Text);
                    int mat = Convert.ToInt32(textBox4.Text);
                    string puesto = textBox5.Text;
                    float sueldo = Convert.ToSingle(textBox6.Text);
                    Docente docente = new Docente(nom, edad, fech, puesto, sueldo);
                }
                else
                {
                    string nom = textBox1.Text;
                    string fech = textBox2.Text;
                    int edad = Convert.ToInt32(textBox3.Text);
                }
            }
        }

        private void radioalumno_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "D:\\Ejercicios POO\\Proyecto_P2-main\\Proyecto_P2-main\\imagenes\\trabajando.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label6.Visible = false;
            textBox6.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "D:\\Ejercicios POO\\Proyecto_P2-main\\Proyecto_P2-main\\imagenes\\grupo.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label4.Visible = false;
            textBox4.Visible = false;
            label5.Visible = false;
            textBox5.Visible = false;
            label6.Visible = false;
            textBox6.Visible = false;
        }

        private void radioempleado_CheckedChanged(object sender, EventArgs e)
        {

            string rutaImagen = "D:\\Ejercicios POO\\Proyecto_P2-main\\Proyecto_P2-main\\imagenes\\datos-del-usuario.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label4.Visible = true;
            textBox4.Visible = true;
            label5.Visible = true;
            textBox5.Visible = true;
            label6.Visible = true;
            textBox6.Visible = true;
        }

        private void radiodocente_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "D:\\Ejercicios POO\\Proyecto_P2-main\\Proyecto_P2-main\\imagenes\\administrador.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label4.Visible = true;
            textBox4.Visible = true;
            label5.Visible = true;
            textBox5.Visible = true;
            label6.Visible = true;
            textBox6.Visible = true;
        }

        private void Salir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
           
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

        private void guardar_Click(object sender, EventArgs e)
        {
            if (radioalumno.Checked)
            {
                MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + textBox1.Text + "\nFecha de Nac: " + textBox2.Text
                + "\nEdad: " + textBox3.Text + "\nMatricula: " + textBox4.Text + "\nCarrera: " + textBox5.Text);
            }
            else
            {
                if (radiodocente.Checked || radioempleado.Checked)
                {
                    MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + textBox1.Text + "\nFecha de Nac: " + textBox2.Text
              + "\nEdad: " + textBox3.Text + "\nDNI: " + textBox4.Text + "\nPuesto: " + textBox5.Text + "\nSueldo: " + textBox6.Text);
                }
                else
                {
                    MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + textBox1.Text + "\nFecha de Nac: " + textBox2.Text
               + "\nEdad: " + textBox3.Text);
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string rutaImagen = "D:\\Ejercicios POO\\Proyecto_P2-main\\Proyecto_P2-main\\imagenes\\grupo.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            radioalumno.Checked = false;
            radioButton1.Checked= false;
            radiodocente.Checked = false;
           radioempleado.Checked = false;

        }
    }
}
