using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
               alumno.Guardar_info();
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
                    Empleado empleado = new Empleado(nom, edad, fech,mat, puesto, sueldo);
                }
                else if (radiodocente.Checked)
                {
                    string nom = textBox1.Text;
                    string fech = textBox2.Text;
                    int edad = Convert.ToInt32(textBox3.Text);
                    int mat = Convert.ToInt32(textBox4.Text);
                    string puesto = textBox5.Text;
                    float sueldo = Convert.ToSingle(textBox6.Text);
                    Docente docente = new Docente(nom, edad, fech, mat, puesto, sueldo);
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
            string rutaImagen = "E:\\Ejercicios POO\\Proyecto_P2-main\\Proyecto_P2-main\\imagenes\\trabajando.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label4.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            label5.Visible = true;
            label6.Visible = false;
            textBox6.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "E:\\Ejercicios POO\\Proyecto_P2-main\\Proyecto_P2-main\\imagenes\\grupo.png";
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

            string rutaImagen = "E:\\Ejercicios POO\\Proyecto_P2-main\\Proyecto_P2-main\\imagenes\\datos-del-usuario.png";
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
            string rutaImagen = "E:\\Ejercicios POO\\Proyecto_P2-main\\Proyecto_P2-main\\imagenes\\administrador.png";
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
            if (MessageBox.Show("¿Deseas salir de la aplicación?", "Aviso",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
            }
            
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
                + "\nEdad: " + textBox3.Text + "\nMatricula: " + textBox4.Text + "\nCarrera: " + textBox5.Text, "Datos de alumno",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
                //uso los paramatros del constructor
                string nom = textBox1.Text;
                string fech = textBox2.Text;
                int edad = Convert.ToInt32(textBox3.Text);
                int mat = Convert.ToInt32(textBox4.Text);
                string carrera = textBox5.Text;
                //creo un objeto alumno con los datos
                Alumno alumno = new Alumno(nom, edad, fech, carrera, mat);
                //guardo los datos en el archivo txt
                alumno.Guardar_info();
            }
            else
            {
                if (radiodocente.Checked || radioempleado.Checked)
                {
                    MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + textBox1.Text + "\nFecha de Nac: " + textBox2.Text
              + "\nEdad: " + textBox3.Text + "\nDNI: " + textBox4.Text + "\nPuesto: " + textBox5.Text + "\nSueldo: " + textBox6.Text, "Datos",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(radioempleado.Checked)
                    {
                        string nom = textBox1.Text;
                        string fech = textBox2.Text;
                        int edad = Convert.ToInt32(textBox3.Text);
                        int mat = Convert.ToInt32(textBox4.Text);
                        string puesto = textBox5.Text;
                        float sueldo = Convert.ToSingle(textBox6.Text);
                        Empleado empleado = new Empleado(nom, edad, fech, mat, puesto, sueldo);
                        empleado.Guardar_info();
                    }
                    else
                    {
                        string nom = textBox1.Text;
                        string fech = textBox2.Text;
                        int edad = Convert.ToInt32(textBox3.Text);
                        int mat = Convert.ToInt32(textBox4.Text);
                        string puesto = textBox5.Text;
                        float sueldo = Convert.ToSingle(textBox6.Text);
                        Docente docente = new Docente(nom, edad, fech, mat,puesto, sueldo);
                        docente.Guardar_info();
                    }
                }
                else
                {
                    MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + textBox1.Text + "\nFecha de Nac: " + textBox2.Text
               + "\nEdad: " + textBox3.Text, "Datos de persona", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string rutaImagen = "E:\\Ejercicios POO\\Proyecto_P2-main\\Proyecto_P2-main\\imagenes\\grupo.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            radioalumno.Checked = false;
            radioButton1.Checked= false;
            radiodocente.Checked = false;
           radioempleado.Checked = false;

        }
    }
}
