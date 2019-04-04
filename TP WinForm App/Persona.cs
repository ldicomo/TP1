using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_WinForm_App
{
    class Persona
    {
        //atributos-propiedades (2 en 1)
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Edad { get; set; }
        public string Sexo { get; set; }
        public string Música { get; set; }
        public string Color { get; set; }

        //constructores
        public Persona(string nombre, string apellido, string edad, string sexo, string música, string color)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Sexo = sexo;
            Música = música;
            Color = color;
        }
     }
 }

