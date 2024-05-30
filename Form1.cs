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
                || string.IsNullOrEmpty(edadT.Text) || string.IsNullOrEmpty(dni.Text)
                || string.IsNullOrEmpty(carreraT.Text) ||
                (docente.Checked && string.IsNullOrEmpty(sueldoT.Text) ||
                (empleado.Checked && string.IsNullOrEmpty(sueldoT.Text))))

            {
                // Si hay algún campo vacío, se muestra un mensaje de error.
                MessageBox.Show("Completar los espacios vacíos", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Si todos los campos están llenos, se muestra un mensaje de éxito.
                MessageBox.Show("Guardado con ÉXITO", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Si todos los campos están llenos, se muestra un mensaje de éxito.
            // MessageBox.Show("Guardado con ÉXITO", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (alumno.Checked)
            {
                MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + nomC.Text + "\nFecha de Nac: " + fechaNac.Text
                + "\nEdad: " + edadT.Text + "\nMatricula: " + dni.Text + "\nCarrera: " + carreraT.Text);
            }
            else
            {
                if (docente.Checked || empleado.Checked)
                {
                    MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + nomC.Text + "\nFecha de Nac: " + fechaNac.Text
                 + "\nEdad: " + edadT.Text + "\nDNI: " + dni.Text + "\nPuesto: " + carreraT.Text + "\nSueldo: " + sueldoT.Text);
                }

                else
                {
                    MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + nomC.Text + "\nFecha de Nac: " + fechaNac.Text
                     + "\nEdad: " + edadT.Text);
                }
            }
        }
        private void limpiar_Click(object sender, EventArgs e)
        {
            // Borra el contenido del control 'nomC', e un campo de entrada de texto.
            nomC.Clear();

            // Borra el contenido del control 'fechaNac',  campo de entrada de texto para la fecha de nacimiento.
            fechaNac.Clear();

            // Borra el contenido del control 'edad',  campo de entrada de texto para la edad.
            edadT.Clear();

            // Borra el contenido del control 'dni',  campo de entrada de texto para el número de identificación.
            dni.Clear();

            // Borra el contenido del control 'carrera',  campo de entrada de texto para la carrera o profesión.
            carreraT.Clear();

            // Borra el contenido del control 'sueldo',  campo de entrada de texto para el sueldo.
            sueldoT.Clear();
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

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C:/Users/carlo/Desktop/Proyecto_P2-main/Imagenes/Docente.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label6.Visible = true;
            sueldoT.Visible = true;
        }

        private void alumno_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C:/Users/carlo/Desktop/Proyecto_P2-main/Imagenes/Alumno.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label6.Visible = false;
            sueldoT.Visible = false;
        }

        private void empleado_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C:/Users/carlo/Desktop/Proyecto_P2-main/Imagenes/Empleado.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
            label6.Visible = true;
            sueldoT.Visible = true;
        }

        private void validar_Click(object sender, EventArgs e)
        {
            if (empleado.Checked)
            {
                string nom = nomC.Text;
                string fech = fechaNac.Text;
                int edad = Convert.ToInt32(edadT.Text);
                int mat = Convert.ToInt32(dni.Text);
                string puesto = carreraT.Text;
                float sueldo = Convert.ToSingle(sueldoT.Text);
                Empleado empleado = new Empleado(nom, edad, fech, puesto, sueldo);

            }
            else if (alumno.Checked)
            {
                string nom = nomC.Text;
                string fech = fechaNac.Text;
                int edad = Convert.ToInt32(edadT.Text);
                int mat = Convert.ToInt32(dni.Text);
                string carrera = carreraT.Text;
                float sueldo = Convert.ToSingle(sueldoT.Text);
                Alumno alumno = new Alumno(nom, edad, fech, carrera, mat);
            }
            else if (docente.Checked)
            {
                string nom = nomC.Text;
                string fech = fechaNac.Text;
                int edad = Convert.ToInt32(edadT.Text);
                int mat = Convert.ToInt32(dni.Text);
                string puesto = carreraT.Text;
                float sueldo = Convert.ToSingle(sueldoT.Text);
                Docente docente = new Docente(nom, edad, fech, puesto, sueldo);
            }
            else
            {
                string nom = nomC.Text;
                string fech = fechaNac.Text;
                int edad = Convert.ToInt32(edadT.Text);
            }
        }

        private void carreraT_TextChanged(object sender, EventArgs e)
        {

        }

        private void sueldoT_TextChanged(object sender, EventArgs e)
        {

        }

        private void persona_CheckedChanged(object sender, EventArgs e)
        {
            string rutaImagen = "C:/Users/carlo/Desktop/Proyecto_P2-main/Imagenes/Persona.png";
            pictureBox1.BackgroundImage = Image.FromFile(rutaImagen);
        }
    }
}
