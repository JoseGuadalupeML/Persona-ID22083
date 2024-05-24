using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace persona_herencia
{
    class Persona //clase padre
    {
        //variables
        //atributos
        //metodos
        public string Nombre { get; set; }
        public string FechaNa { get; set; }
        public string Edad { get; set; }
        //colocar todos los comentarios necesarios para explicar
        //el funcinamiento de su código
        //aqui va el constructor para cargar datos en las cajas de memoria

        //nombre, edad, fecha de nacimiento(es un tipo cadena!!!!! string)
    }
    class Alumnos : Persona
    {
        // Atributos de la clase 'Alumno'
        // Constructor de la clase 'Alumno'
        // Métodos de la clase 'Alumno'
        public string Matricula { get; set; }
        public string Carrera { get; set; }
        //colocar todos los comentarios necesarios para explicar
        //el funcinamiento de su código
    }
    class Empleado : Persona //clase hija
    {
        // Atributos de la clase 'Alumno'
        // Constructor de la clase 'Alumno'
        // Métodos de la clase 'Alumno'
        public string Dni { get; set; }
        public string Puesto { get; set; }
        public string Sueldo { get; set; }
        //colocar todos los comentarios necesarios para explicar
        //el funcinamiento de su código
    }

    class Docente : Persona //clase Hija
    {
        // Atributos de la clase 'Alumno'
        // Constructor de la clase 'Alumno'
        // Métodos de la clase 'Alumno'
        public string Dni { get; set; }
        public string Puesto { get; set; }
        public string Sueldo { get; set; }
        //colocar todos los comentarios necesarios para explicar
        //el funcinamiento de su código
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

