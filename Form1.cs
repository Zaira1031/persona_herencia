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

        private void guardar_Click(object sender, EventArgs e)
        {
            // esto se hace de tarea todos los valores
            // deben de almacenarse en su
            // caja de memoria correspondiente
            // usando la clase hija que corresponda
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
             nomC.Clear();
            fechaNac.Clear();
            edad.Clear();
            dni.Clear();
            carrera.Clear();
            sueldo.Clear();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // se hace de tarea
            // debe de terminar la ejecucion de la interfaz
        }

        private void nomC_TextChanged(object sender, EventArgs e)
        {

        }

        private void fechaNac_TextChanged(object sender, EventArgs e)
        {

        }

        private void edad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
