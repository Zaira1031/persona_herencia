﻿using System;
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
       
    }

    class Alumno :Persona //clase hija alumno
    {
        string matricula, carrera;
        public string Matricula
        {
            get { return matricula; } //vamos por el valor de la caja de texto (OBTIENE)
            set { matricula = value; } // se guarda en la memoria
        }
        public string Carrera
        {
            get { return carrera; } //vamos por el valor de la caja de texto (OBTIENE)
            set { carrera = value; } // se guarda en la memoria
        }
        
    }
    class Empleado : Persona //clase hija
    {
        string matricula, carrera, sueldo;
        public string Matricula
        {
            get { return matricula; } //vamos por el valor de la caja de texto (OBTIENE)
            set { matricula = value; } // se guarda en la memoria
        }
        public string Carrera
        {
            get { return carrera; } //vamos por el valor de la caja de texto (OBTIENE)
            set { carrera = value; } // se guarda en la memoria
        }
        public string Sueldo
        {
            get { return sueldo; } //vamos por el valor de la caja de texto (OBTIENE)
            set { sueldo = value; } // se guarda en la memoria
        }
        
    }

    class Docente : Persona //clase Hija
    {
        string matricula, sueldo;
        public string Matricula
        {
            get { return matricula; } //vamos por el valor de la caja de texto (OBTIENE)
            set { matricula = value; } // se guarda en la memoria
        }
        public string Sueldo
        {
            get { return sueldo; } //vamos por el valor de la caja de texto (OBTIENE)
            set { sueldo = value; } // se guarda en la memoria
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
