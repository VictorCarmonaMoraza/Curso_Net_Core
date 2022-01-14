## 13 - El operador condicional

Aqui vamos a sustituir la estructura condicional if else por otra mas corta

        var data = valor1 != valor2;
            //if (data)
            //{
            //    name = "Alex";
            //}
            //else
            //{
            //    name = "Joel";
            //}
            //Si el valor de data es true, la variable name tomara el valor de "Alex" mientras
            //en caso de que sea false tomara el valor de "Joel"
            name = data ? "Alex" : "Joel";
            Console.WriteLine("Resultado {0} ", name);