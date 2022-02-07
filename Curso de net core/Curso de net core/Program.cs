using System;

namespace Curso_de_net_core
{
    class Program
    {
        
        //Constructor
        public Program()
        {
            
        }

        //Constructor con parametro
        public Program(String name)
        {

        }

        //Constructor con parametro
        public Program(String name, int age)
        {

        }

        /*Este constructor es parecido al anterior pero con los campos cambiados por lo que
        no genera conflictor*/
        public Program(int age, String name)
        {

        }

        static void Main(string[] args)
        {
            var data = new Program("Victor",52);
            Console.ReadLine();
           
        }
    }
}
