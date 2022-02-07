using System;
using System.Text;

namespace Curso_de_net_core
{
    class Program
    {
        //Variables Globales
        private String cadena;
        private String verMayusculas = "";
        private String verMinusculas = "";
        private int n;
        private string[] Mayusculas;
        private string[] Minusculas;
        private string[] tempMy;
        private string[] tempMn;

        static void Main(string[] args)
        {
            var data = new Program();
            Console.ReadLine();
            //Console.ReadKey();
        }

        private String Mayuscula()
        {
            for (int i = 0; i < n; i++)
            {
                //IsUpper indica si un caracter Unicode esta categorizado com una letra mayuscula
                if (Char.IsUpper(cadena[i]))
                {
                    tempMy[i] = Convert.ToString(cadena[i]);
                }
            }
            //Recooremos el arreglo temporal anterior
            for (int i = 0; i < tempMy.Length; i++)
            {
                if (tempMy[i] != null)
                {
                    Mayusculas[i] = tempMy[i];
                    verMayusculas = $"{verMayusculas},{Mayusculas[i]}";
                }
            }
            return verMayusculas;
        }


    }
}
