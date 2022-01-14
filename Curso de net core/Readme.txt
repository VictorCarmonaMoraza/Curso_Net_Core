## 14 - Array de tipo string

-Los arrays siempre empiezan desde la posicion cero

//creacion de un array de tipo string de longitud 5.Sino ponemos las posiciones lanza error
string[] cadenas = new string[5];

//Imprimimos la longitud del array
Console.WriteLine("Resultado {0} ", cadenas.Length);

//Asignamos en la poscion cero de array el valor de "Alex"
cadenas[0] = "Alex";

//Si intentamos meter el la posicion 5 de attay el valor "Alex" saltara una excepcion porque no podemos almacenar
//en esa poscion porque al empezar en cero llegaria hasta 4
cadenas[5] = "Alex";

//Imprimimos la posicion 4 del array que sera la ultima a la que podemos asignar valores
Console.WriteLine("Resultado {0} ", cadenas[4]);

//Inicializacion de un array
string[] name = { "Alex","Carlos", "Alejandro", "Alba", "Lucia" };

 //Concatenamos posiciones de array name
 Console.WriteLine("Resultado {0} ", name[0] + " " + name[3]);
