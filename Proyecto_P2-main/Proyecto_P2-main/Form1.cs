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

        private void guardar_Click_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked) //checa si el boton es seleccionado para utilizar la clase alumno
            {
                MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + textBox1.Text + "\nFecha de Nac: " + textBox2.Text
                + "\nEdad: " + textBox3.Text + "\nMatricula: " + textBox4.Text + "\nCarrera: " + textBox5.Text, "Alumno",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                if (radioButton1.Checked || radioButton3.Checked)
                {
                    MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + textBox1.Text + "\nFecha de Nac: " + textBox2.Text + "\nEdad: " + textBox3.Text + "\nDNI: " + textBox4.Text + "\nPuesto: " + textBox5.Text + "\nSueldo: " + textBox6.Text, "Empleado o Docente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("DATOS GUARDOS" + "\nNombre: " + textBox1.Text + "\nFecha de Nac: " + textBox2.Text + "\nEdad: " + textBox3.Text, "Persona", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void limpiar_Click_1(object sender, EventArgs e)
        {
            // se hace de tarea
            // debe de borrar las cajas de texto
            textBox1.Clear(); //borra lo de textbox1
            textBox2.Clear();//borra lo de textbox2
            textBox3.Clear();//borra lo de textbox3
            textBox4.Clear();//borra lo de textbox4
            textBox5.Clear();//borra lo de textbox5
            textBox6.Clear();//borra lo de textbox6
        }

        private void Salir_Click_1(object sender, EventArgs e)
        {
            // se hace de tarea
            // debe de terminar la ejecucion de la interfaz
            Application.Exit(); //sale de aplicacion
        }

        private void validar_Click(object sender, EventArgs e)
        { 
            // esto se hace de tarea todos los valores
            // deben de almacenarse en su
            // caja de memoria correspondiente
            // usando la clase hija que corresponda
            if (radioButton1.Checked)
            {
                string nom = textBox1.Text;
                string fech = textBox2.Text;
                int edad = Convert.ToInt32(textBox3.Text);
                int mat = Convert.ToInt32(textBox4.Text);
                string carrera = textBox5.Text;
                Alumno alumno = new Alumno(nom, edad, fech, carrera, mat); 
            }
            else if (radioButton2.Checked)
            {
                string nom = textBox1.Text;
                string fech = textBox2.Text;
                int edad = Convert.ToInt32(textBox3.Text);
                int mat = Convert.ToInt32(textBox4.Text);
                string puesto = textBox5.Text;
                float sueldo = Convert.ToSingle(textBox6.Text);
                Empleado empleado = new Empleado(nom, edad, fech, puesto, sueldo);
            }
            else if (radioButton3.Checked)
            {
                string nom = textBox1.Text;
                string fech = textBox2.Text;
                int edad = Convert.ToInt32(textBox3.Text);
                int mat = Convert.ToInt32(textBox4.Text);
                string puesto = textBox5.Text;
                float sueldo = Convert.ToSingle(textBox6.Text);
                Docente docente = new Docente(nom, edad, fech, puesto, sueldo);
            }
            else if (radioButton4.Checked)
            {
                string nom = textBox1.Text;
                string fech = textBox2.Text;
                int edad = Convert.ToInt32(textBox3.Text);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //cuadro de imagen / propiedad / carpeta recurso / nombre de la imagen
            pictureBox1.Image = Properties.Resources.Alumno___copia;
            label6.Visible = false;
            textBox6.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Empleado;
            label4.Visible = true;
            textBox4.Visible = true;
            label5.Visible = true;
            textBox5.Visible = true;
            label6.Visible = true;
            textBox6.Visible = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Docente;
            label4.Visible = true;
            textBox4.Visible = true;
            label5.Visible = true;
            textBox5.Visible = true;
            label6.Visible = true;
            textBox6.Visible = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.perosna;
            label4.Visible = false;
            textBox4.Visible = false;
            label5.Visible = false;
            textBox5.Visible = false;
            label6.Visible = false;
            textBox6.Visible = false;
        }
    }
}
