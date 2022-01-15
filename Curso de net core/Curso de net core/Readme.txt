## 18 La estructura bucle ciclo Foreach

//Creamos una array de tipo string
            string[] name = { "Alejandor", "Victor", "Carlos" };

//Recorremos el array anterior con un ciclo for y un ciclo foreach

-CICLO FOR
for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("Resultado {0}", name[i]);
            }

            Console.WriteLine("--------------------");

-CICLO FOREACH
foreach (var item in name)
            {
                Console.WriteLine("Resultado {0}", item);
            }