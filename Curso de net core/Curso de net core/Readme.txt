## 24-La estructura do While

-Estructura do while

            do
            {
                if (count == 6)
                {
                    valor = false;
                }
                count++;
                Console.WriteLine("Ejecucion de do while {0}", count);

            } while (valor);

-Parada del do while con un break

            do
            {
                if (count == 6)
                {
                    //Podemos parar la ejecucion con la palabra break
                    //Esta palabra para toda la ejecucion y ya no se ejecuta ninguna linea mas hacia abajo
                    break;
                }
                count++;
                Console.WriteLine("Ejecucion de do while con break {0}", count);

            } while (valor);

