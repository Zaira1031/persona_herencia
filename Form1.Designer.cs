
namespace persona_herencia
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.persona = new System.Windows.Forms.RadioButton();
            this.validar = new System.Windows.Forms.Button();
            this.docente = new System.Windows.Forms.RadioButton();
            this.alumno = new System.Windows.Forms.RadioButton();
            this.empleado = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Salir = new System.Windows.Forms.Button();
            this.limpiar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.sueldoT = new System.Windows.Forms.TextBox();
            this.carreraT = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.TextBox();
            this.edadT = new System.Windows.Forms.TextBox();
            this.fechaNac = new System.Windows.Forms.TextBox();
            this.nomC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.persona);
            this.groupBox1.Controls.Add(this.validar);
            this.groupBox1.Controls.Add(this.docente);
            this.groupBox1.Controls.Add(this.alumno);
            this.groupBox1.Controls.Add(this.empleado);
            this.groupBox1.Location = new System.Drawing.Point(197, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // persona
            // 
            this.persona.AutoSize = true;
            this.persona.Location = new System.Drawing.Point(7, 89);
            this.persona.Name = "persona";
            this.persona.Size = new System.Drawing.Size(106, 17);
            this.persona.TabIndex = 4;
            this.persona.Text = "Soy una Persona";
            this.persona.UseVisualStyleBackColor = true;
            // 
            // validar
            // 
            this.validar.Location = new System.Drawing.Point(15, 112);
            this.validar.Name = "validar";
            this.validar.Size = new System.Drawing.Size(85, 36);
            this.validar.TabIndex = 3;
            this.validar.Text = "VALIDAR";
            this.validar.UseVisualStyleBackColor = true;
            this.validar.Click += new System.EventHandler(this.validar_Click);
            // 
            // docente
            // 
            this.docente.AutoSize = true;
            this.docente.Location = new System.Drawing.Point(7, 66);
            this.docente.Name = "docente";
            this.docente.Size = new System.Drawing.Size(102, 17);
            this.docente.TabIndex = 2;
            this.docente.Text = "Soy un Docente";
            this.docente.UseVisualStyleBackColor = true;
            this.docente.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // alumno
            // 
            this.alumno.AutoSize = true;
            this.alumno.Location = new System.Drawing.Point(7, 43);
            this.alumno.Name = "alumno";
            this.alumno.Size = new System.Drawing.Size(95, 17);
            this.alumno.TabIndex = 1;
            this.alumno.Text = "Soy un alumno";
            this.alumno.UseVisualStyleBackColor = true;
            this.alumno.CheckedChanged += new System.EventHandler(this.alumno_CheckedChanged);
            // 
            // empleado
            // 
            this.empleado.AutoSize = true;
            this.empleado.Location = new System.Drawing.Point(7, 20);
            this.empleado.Name = "empleado";
            this.empleado.Size = new System.Drawing.Size(107, 17);
            this.empleado.TabIndex = 0;
            this.empleado.Text = "Soy un empleado";
            this.empleado.UseVisualStyleBackColor = true;
            this.empleado.CheckedChanged += new System.EventHandler(this.empleado_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Salir);
            this.groupBox2.Controls.Add(this.limpiar);
            this.groupBox2.Controls.Add(this.guardar);
            this.groupBox2.Controls.Add(this.sueldoT);
            this.groupBox2.Controls.Add(this.carreraT);
            this.groupBox2.Controls.Add(this.dni);
            this.groupBox2.Controls.Add(this.edadT);
            this.groupBox2.Controls.Add(this.fechaNac);
            this.groupBox2.Controls.Add(this.nomC);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(21, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 252);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(211, 180);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(95, 43);
            this.Salir.TabIndex = 13;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // limpiar
            // 
            this.limpiar.Location = new System.Drawing.Point(110, 180);
            this.limpiar.Name = "limpiar";
            this.limpiar.Size = new System.Drawing.Size(95, 43);
            this.limpiar.TabIndex = 12;
            this.limpiar.Text = "Limpiar";
            this.limpiar.UseVisualStyleBackColor = true;
            this.limpiar.Click += new System.EventHandler(this.limpiar_Click);
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(9, 180);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(95, 43);
            this.guardar.TabIndex = 4;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // sueldoT
            // 
            this.sueldoT.Location = new System.Drawing.Point(176, 153);
            this.sueldoT.Name = "sueldoT";
            this.sueldoT.Size = new System.Drawing.Size(100, 20);
            this.sueldoT.TabIndex = 11;
            // 
            // carreraT
            // 
            this.carreraT.Location = new System.Drawing.Point(176, 127);
            this.carreraT.Name = "carreraT";
            this.carreraT.Size = new System.Drawing.Size(100, 20);
            this.carreraT.TabIndex = 10;
            this.carreraT.TextChanged += new System.EventHandler(this.carreraT_TextChanged);
            // 
            // dni
            // 
            this.dni.Location = new System.Drawing.Point(176, 101);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(100, 20);
            this.dni.TabIndex = 9;
            // 
            // edadT
            // 
            this.edadT.Location = new System.Drawing.Point(176, 75);
            this.edadT.Name = "edadT";
            this.edadT.Size = new System.Drawing.Size(100, 20);
            this.edadT.TabIndex = 8;
            this.edadT.TextChanged += new System.EventHandler(this.edad_TextChanged);
            // 
            // fechaNac
            // 
            this.fechaNac.Location = new System.Drawing.Point(176, 49);
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.Size = new System.Drawing.Size(100, 20);
            this.fechaNac.TabIndex = 7;
            this.fechaNac.TextChanged += new System.EventHandler(this.fechaNac_TextChanged);
            // 
            // nomC
            // 
            this.nomC.Location = new System.Drawing.Point(176, 17);
            this.nomC.Name = "nomC";
            this.nomC.Size = new System.Drawing.Size(100, 20);
            this.nomC.TabIndex = 6;
            this.nomC.TextChanged += new System.EventHandler(this.nomC_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "SUELDO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CARRERA/PUESTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNI / MATRICULA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "FECHA DE NACIMIENTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE COMPLETO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EDAD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "PERSONA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button validar;
        private System.Windows.Forms.RadioButton docente;
        private System.Windows.Forms.RadioButton alumno;
        private System.Windows.Forms.RadioButton empleado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button limpiar;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.TextBox sueldoT;
        private System.Windows.Forms.TextBox carreraT;
        private System.Windows.Forms.TextBox dni;
        private System.Windows.Forms.TextBox edadT;
        private System.Windows.Forms.TextBox fechaNac;
        private System.Windows.Forms.TextBox nomC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton persona;
    }
}

