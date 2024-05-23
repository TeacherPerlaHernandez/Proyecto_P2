using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{
    class Persona
    { //cuando una persona se crea desde 0 unicamente tiene
        protected int edad; //caja que guarda edad
        protected string nombre;//caja que guarda nombre
        protected string fechanac;//caja que guarda fecha de nacimiento

        public int Edad //CAJA DE MEMORIA edad
        {
            get { return edad; } //vamos por el valor
                                 //de la caja de texto
            set { edad = value; }//lo guardamos en memoria
        }
        public string Fechanac //CAJA DE MEMORIA fechanacimiento
        {
            get { return fechanac; } //vamos por el valor
                                     //de la caja de texto
            set { fechanac = value; }//lo guardamos en memoria
        }
        public string Nombre //CAJA DE MEMORIA nombre
        {
            get { return nombre; } //vamos por el valor
                                   //de la caja de texto
            set { nombre = value; }//lo guardamos en memoria
        }
        //constructor de estructura persona
       /* public Persona (string nombre, int edad, string fechanac)
        {
            Nombre = nombre;
            Edad = edad;
            Fechanac = fechanac;
        }*/
    }

    class Alumno : Persona
    {
        protected int matricula;
        protected string carrera;
        public int Matricula //CAJA DE MEMORIA edad
        {
            get { return matricula; } //vamos por el valor
                                      //de la caja de texto
            set { matricula = value; }//lo guardamos en memoria
        }
        public string Carrera //CAJA DE MEMORIA fechanacimiento
        {
            get { return carrera; } //vamos por el valor
                                    //de la caja de texto
            set { carrera = value; }//lo guardamos en memoria
        }
        public Alumno(string nombre, int edad, string fechanac, string carrera, int matricula)
        {
            Nombre = nombre;
            Edad = edad;
            Fechanac = fechanac;
            Carrera = carrera;
            Matricula = matricula;
        }

    }

    class Empleado : Persona
    {
        protected float sueldo;
        protected string puesto;
        public float Sueldo //CAJA DE MEMORIA edad
        {
            get { return sueldo; } //vamos por el valor
                                   //de la caja de texto
            set { sueldo = value; }//lo guardamos en memoria
        }
        public string Puesto //CAJA DE MEMORIA fechanacimiento
        {
            get { return puesto; } //vamos por el valor
                                   //de la caja de texto
            set { puesto = value; }//lo guardamos en memoria
        }

        public Empleado(string nombre, int edad, string fechanac, string puesto, float sueldo)
        {
            Nombre = nombre;
            Edad = edad;
            Fechanac = fechanac;
            Puesto = puesto;
            Sueldo = sueldo;
        }
    }

    class Docente : Persona
    {
        protected float sueldo;
        protected string puesto;
        public float Sueldo //CAJA DE MEMORIA edad
        {
            get { return sueldo; } //vamos por el valor
                                   //de la caja de texto
            set { sueldo = value; }//lo guardamos en memoria
        }
        public string Puesto //CAJA DE MEMORIA fechanacimiento
        {
            get { return puesto; } //vamos por el valor
                                   //de la caja de texto
            set { puesto = value; }//lo guardamos en memoria
        }
        public Docente(string nombre, int edad, string fechanac, string puesto, float sueldo)
        {
            Nombre = nombre;
            Edad = edad;
            Fechanac = fechanac;
            Puesto = puesto;
            Sueldo = sueldo;
        }
    }
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
