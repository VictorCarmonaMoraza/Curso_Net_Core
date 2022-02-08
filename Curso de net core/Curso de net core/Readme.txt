## 45 y 46 - Clase estática y Conversor de velocidades

Las clases esticas deben de tener sus metodos y variables estaticos.

A una clase estatica no se le puede crear un metodo constructor a no ser que sea estatico.

         //Metodo constructor static
        static Conversor()
        {

        }

Los constructores estaticos no pueden tener los modificadores de acceso public ni private.

-Ejemplos no valido con private:

        private static Conversor()
        {

        }

-Ejemplos no valido con public:

        public static Conversor()
        {

        }

odas las variables estaticas debeos incializarlas para que no mantengan el valor.