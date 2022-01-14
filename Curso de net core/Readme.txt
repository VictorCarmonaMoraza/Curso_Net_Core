## 12 - Estructura condicionales anidadas

-Se trata de hacer condiciones dentro de otras condiciones.

 if (valor1!=valor2 || valor3== valor4)
            {
                if (valor3 == valor4)
                {
                    Console.WriteLine("Resultado {0} ", "La comparacion devolvio un true");
                }
                else
                {
                    Console.WriteLine("Resultado {0} ", "La comparacion devolvio un false");
                }
                
            }