## 23-La estructura While

//creamos una variable de tipo bool
            var valor = true;
            var count = 1;
//Est es un bucle infinito porque al ser siempre verdadero nunca para su ejecucion
            while (valor)
            {
                Console.WriteLine("Resultado {0}", count);
            }


//Ahora pararemos la ejecucion mediante una condicion y el incremento de una variable
                
//creamos una variable de tipo bool
            var valor = true;
            var count = 1;
            while (valor)
            {
            //Cuando la variable couny sea igual a 6, la variable valor tomara el valor de false
            //y se parara
                if (count == 6)
                {
                    valor = false;
                }
                //incrementamos en una unidad la variable contador
                count++;
                Console.WriteLine("Resultado {0}", count);
            }