## 20 - Instruccion de seleccion switch

 //declaramos variable
            var data =5;
//Comprobamos si existe algun caso donde se cumple que data se corresponde con alguno de los casos
 switch (data)
            {
                case 5:
                    Console.WriteLine("Este es el numero que viene en la data y es 5");
                    break;
                case 4:
                    Console.WriteLine("Este es el numero que viene en la data y es 4");
                    break;

                default:
                    Console.WriteLine("No es ningun numero");
                    break;
            }