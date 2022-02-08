## 44 - Métodos estáticos

En los metodos estaticos debemos utilizar variables estaticas o definirlas a nivel de metodos.

ej

        public static double velocidad;

        public static void Conversor1()
        {
            velocidad += 20;
            //esto es valido, porque es definida dentro del metodo
            int valor = 20;
        }

ej No valido

         public static double velocidad;
         int valor = 5;

        public static void Conversor1()
        {
            velocidad += 20;
            //esto no es valido
            valor = 20;
        }
        

Para llamar a un metodo estatico dentro de una clase es con el nombre de la clase
y el nombre del metodo.

ej:

    Conversor.metodo();