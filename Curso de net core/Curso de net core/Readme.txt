## 21 - Switch 1

Esta es nueva forma de hacer un switch y no esta en toda las versiones, solo creo que esta en las ultimas 
versiones de .net core

//declaramos variable
            var data = 2;
            var resultado = data switch
            {
                1 => "Alex",
                2 => "Victor",
                3 => "Lucia"
            };

            Console.WriteLine("Resultado {0}", resultado);