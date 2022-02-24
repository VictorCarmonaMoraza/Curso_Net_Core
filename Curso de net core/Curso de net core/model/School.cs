using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso_de_net_core.model
{
    public class School
    {
        public List<Estudiante> students { get; set; }

        public School()
        {
            students = new List<Estudiante>();
        }

        /// <summary>
        /// Se añade un nuevo estudiante a la lista
        /// </summary>
        /// <param name="nuevoEstudiante">nuevo estudiante a agregar</param>
        public void addStudent(Estudiante nuevoEstudiante)
        {
            students.Add(nuevoEstudiante);
        }

        public bool buscarPorNombre(string name)
        {
            bool encontrado = false;
            int i = 0;

            while (encontrado == false && i < students.Count)
            {
                //Buscamos en la coleccion de objetos un estudiante por su nombre
                if (students[i].Nombre.Equals(name))
                {
                    encontrado = true;
                }
                else
                {
                    i++;
                }
            }
            if (encontrado)
            {
                Console.WriteLine("Name: " + students[i].Nombre + "\n" +
                    "Last Name: " + students[0].LastName + "\n" +
                    "Edad: " + students[i].Edad + "\n" +
                    "Qualification: " + students[i].Calificacion);
                    return false;
            }
            else
            {
                Console.WriteLine("No existe el nombre, intente nuevamente...!");
                return true;
            }
           
        }
    }
}
