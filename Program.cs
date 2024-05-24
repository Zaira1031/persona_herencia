using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{
    class Persona //clase padre
    {
        string nombre, fechanac; //variables
        int edad;
        // Propiedades 

        // Constructor 
        public string Nombre
        {
            get { return nombre; } //vamos por el valor de la caja de texto (OBTIENE)
            set { nombre = value; } // se guarda en la memoria
        }
        public string Fechanac
        {
            get { return fechanac; } //vamos por el valor de la caja de texto (OBTIENE)
            set { fechanac = value; } // se guarda en la memoria
        }
        public int Edad
        {
            get { return edad; } //vamos por el valor de la caja de texto (OBTIENE)
            set { edad = value; } // se guarda en la memoria
        }
        //constructor de estructura persona
        /* public Persona (string nombre, int edad, string fechanac)
         {
             Nombre = nombre;
             Edad = edad;
             Fechanac = fechanac;
         }*/

    }

    class Alumno :Persona //clase hija alumno
    {
        protected int matricula;
        protected string carrera;
        public int Matricula
        {
            get { return matricula; } //vamos por el valor de la caja de texto (OBTIENE)
            set { matricula = value; } // se guarda en la memoria
        }
        public string Carrera
        {
            get { return carrera; } //vamos por el valor de la caja de texto (OBTIENE)
            set { carrera = value; } // se guarda en la memoria
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
    class Empleado : Persona //clase hija
    {
        protected float sueldo;
        protected string puesto;
       
        public string Puesto
        {
            get { return puesto; } //vamos por el valor de la caja de texto (OBTIENE)
            set { puesto = value; } // se guarda en la memoria
        }
        public float Sueldo
        {
            get { return sueldo; } //vamos por el valor de la caja de texto (OBTIENE)
            set { sueldo = value; } // se guarda en la memoria
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

    class Docente : Persona //clase Hija
    {
        protected float sueldo;
        protected string puesto;

        public float Sueldo
        {
            get { return sueldo; } //vamos por el valor de la caja de texto (OBTIENE)
            set { sueldo = value; } // se guarda en la memoria
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
