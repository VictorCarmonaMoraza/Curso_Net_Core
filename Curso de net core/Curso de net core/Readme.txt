## 33 - Variables globales y metrodo que retorna datos de tipo string

Todas las variables creadas dentro de un metodo son variables locales.

class Program
    {
        //Variables Globales
        private String names;

        static void Main(string[] args)
        {
            var data = new Program();
            var name = data.metodoPrivado();
            //Variable local
            String namesLocal;
            Console.WriteLine(name);
            Console.ReadLine();
            //Console.ReadKey();
        }

        private int metodoPrivado()
        {
            //Variable Global
            names = "";
            //Variable local da error
            namesLocal = "";
            return Convert.ToInt16("yui");
        }
    }



