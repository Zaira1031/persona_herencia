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
            // Se comprueba si alguno de los campos de texto está vacío o nulo.
            if (string.IsNullOrEmpty(nomC.Text) || string.IsNullOrEmpty(fechaNac.Text)
                || string.IsNullOrEmpty(edad.Text) || string.IsNullOrEmpty(dni.Text)
                || string.IsNullOrEmpty(carrera.Text))
            //(Docente.Checked && string.IsNullOrEmpty(sueldo.Text)*
            {
                // Si hay algún campo vacío, se muestra un mensaje de error.
                MessageBox.Show("Completar los espacios vacíos", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Si todos los campos están llenos, se muestra un mensaje de éxito.
                MessageBox.Show("Guardado con ÉXITO", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            // Borra el contenido del control 'nomC', e un campo de entrada de texto.
            nomC.Clear();

            // Borra el contenido del control 'fechaNac',  campo de entrada de texto para la fecha de nacimiento.
            fechaNac.Clear();

            // Borra el contenido del control 'edad',  campo de entrada de texto para la edad.
            edad.Clear();

            // Borra el contenido del control 'dni',  campo de entrada de texto para el número de identificación.
            dni.Clear();

            // Borra el contenido del control 'carrera',  campo de entrada de texto para la carrera o profesión.
            carrera.Clear();

            // Borra el contenido del control 'sueldo',  campo de entrada de texto para el sueldo.
            sueldo.Clear();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            // La función Application.Exit() cierra la aplicación actual.
            Application.Exit();

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
