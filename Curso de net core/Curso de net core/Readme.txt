## 39 - Parámetros de métodos palabras claves ref, out

            
            int data = 67;
            //reflejara el valor de data fuera del metodo, aqui vale 70
            //necesitamos inicializar la variable data
            new Program().metodo(ref data);

            //Con esto no tenemos que inicializar la variable data, aqui vale 70
            new Program().metodo2(out data);
        }

        private void metodo(ref int valor)
        {
            valor = 50 + 20;
            //Console.WriteLine(valor);
        }

        private void metodo2(out int valor)
        {
            valor = 50 + 20;
            //Console.WriteLine(valor);
        }