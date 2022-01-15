## 22 - Switch 2

Esta declaracion de variable que acepta tres datos es nuevo en c#
//Creamos una lista de objetos
            var (a, b, opcion) = (2, 6, "+");
            var resultado = opcion switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b
            };

            Console.WriteLine("Resultado {0}", resultado);