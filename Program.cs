using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        public void Guardar_info()
        {
            try
            {
                string fileName = @"C:\Users\carlo\Desktop\Proyecto_P2-main\RegistroAlumnos\Archivos.txt";
                StreamWriter writer = File.AppendText(fileName);
                writer.WriteLine("Nombre: " + Nombre);
                writer.WriteLine("Edad: " + Edad);
                writer.WriteLine("Fecha Nacimiento: " + Fechanac);
                writer.WriteLine("Carrera: " + Carrera);
                writer.WriteLine("Matricula: " + Matricula);
                writer.WriteLine("\n" );
                writer.Close();
            }
            catch 
            {

                MessageBox.Show("ERROR AL GUARDAR DARTOS EN EL ARCHIVO: RegistrosAlumnos.TXT", "ERROR"
                 , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    class Empleado : Persona //clase hija
    {
        protected string dni;
        protected float sueldo;
        protected string puesto;
        
        public string Dni
        {
            get { return dni; } //vamos por el valor de la caja de texto (OBTIENE)
            set { dni = value; } // se guarda en la memoria
        }
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
        
        public Empleado(string nombre, int edad, string fechanac, string puesto, float sueldo, string dni)
        {
            Nombre = nombre;
            Edad = edad;
            Dni = dni;
            Fechanac = fechanac;
            Puesto = puesto;
            Sueldo = sueldo;
           
        }
        public void Guardar_info()
        {
            try
            {
                string fileName = @"C:/Users/carlo/Desktop/Proyecto_P2 - main/RegistrosAlumnos/ ArchivosEmpleado.txt";
                StreamWriter writer = File.AppendText(fileName);
                writer.WriteLine("Nombre: " + Nombre);
                writer.WriteLine("Edad: " + Edad);
                writer.WriteLine("Fecha Nacimiento: " + Fechanac);
                writer.WriteLine("DNI: " + Dni);
                writer.WriteLine("Puesto: " + Puesto);
                writer.WriteLine("Sueldo: " + Sueldo);
                writer.WriteLine("\n");
                writer.Close();
            }
            catch
            {

                MessageBox.Show("ERROR AL GUARDAR DARTOS EN EL ARCHIVO: RegistrosAlumnos.TXT", "ERROR"
                 , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    class Docente : Persona //clase Hija
    {
        protected string dni;
        protected float sueldo;
        protected string puesto;

        public string Dni
        {
            get { return dni; } //vamos por el valor de la caja de texto (OBTIENE)
            set { dni = value; } // se guarda en la memoria
        }
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
        public Docente(string nombre, int edad, string fechanac, string puesto, float sueldo, string dni)
        {
            Nombre = nombre;
            Edad = edad;
            Dni = dni;
            Fechanac = fechanac;
            Puesto = puesto;
            Sueldo = sueldo;
        }
        public void Guardar_info()
        {
            try
            {
                string fileName = @"C:/Users/carlo/Desktop/Proyecto_P2 - main/RegistrosAlumnos/ ArchivosDocente.txt";
                StreamWriter writer = File.AppendText(fileName);
                writer.WriteLine("Nombre: " + Nombre);
                writer.WriteLine("Edad: " + Edad);
                writer.WriteLine("Fecha Nacimiento: " + Fechanac);
                writer.WriteLine("DNI: " + Dni);
                writer.WriteLine("Puesto: " + Puesto);
                writer.WriteLine("Sueldo: " + Sueldo);
                writer.WriteLine("\n");
                writer.Close();
            }
            catch
            {

                MessageBox.Show("ERROR AL GUARDAR DARTOS EN EL ARCHIVO: RegistrosAlumnos.TXT", "ERROR"
                 , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
