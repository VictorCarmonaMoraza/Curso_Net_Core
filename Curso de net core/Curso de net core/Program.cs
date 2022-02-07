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

        //Constructor
        public Program(String cadena)
        {
            this.cadena = cadena;
            n = cadena.Length;
            Mayusculas = new string[n];
            Minusculas = new string[n];
            tempMy = new string[n];
            tempMn = new string[n];
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

        public string minusculas()
        {
            for (int i = 0; i < n; i++)
            {
                //IsLower indica si un caracter unicode esta categorizado como una letra minuscula
                if (Char.IsLower(cadena[i]))
                {
                    //Arreglo que almacenara los caracteres en minuscula
                    tempMn[i] = Convert.ToString(cadena[i]);
                }
            }
            //Recorremos el arreglo tempMn
            for (int i = 0; i < tempMn.Length; i++)
            {
                //Comporbamos que el arreglo no esta vacio
                if (tempMn[i] != null)
                {
                    //Agregamos el elemento al arreglo de minusculas
                    Minusculas[i] = tempMn[i];
                    //
                    verMinusculas = $"{verMinusculas},{Minusculas[i]}";
                }
            }
            return verMinusculas;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un texto");
            //Leeemos por teclado 
            var cadena = Console.ReadLine();
            var data = new Program(cadena);
            Console.ReadLine();
            //Console.ReadKey();
        }


    }
}
