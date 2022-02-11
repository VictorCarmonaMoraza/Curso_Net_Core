using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_net_core
{
    public class Estudiante
    {
        private String nombre;

        //Getter and setter y inicializacion
        public String Nombre { get; set; } = "Victor";

        public String Apellido { 
            set {
                nombre = value;
            } 
        }
    }
}
