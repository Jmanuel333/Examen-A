/*INSTITUTO TECNOLÓGICO SUPERIOR DE CINTALAPA
PROGRAMACION ORIENTADA A OBJETOS
DOCENTE:JORGE IVÁN BERMUDEZ RODRIGUEZ
ALUMNO: JOSÉ MANUEL CRUZ MARTÍNEZ*/
using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear instancias de la clase Auto para cada uno de los automóviles disponibles
        Auto[] autos =
        {
            new Auto("Mazda", 450000, "usado"),
            new Auto("Mercedes", 150000, "nuevo"),
            new Auto("Chevrolet", 90000, "usado"),
            new Auto("Bocho", 18000, "nuevo"),
            new Auto("BMW", 600000, "nuevo")
        };

        int opcion;
        string seleccion = "";

        do
        {
            Console.WriteLine("Qué desea hacer:");
            Console.WriteLine("1 - Comprar");
            Console.WriteLine("2 - Vender");
            Console.WriteLine("3 - Alquilar");
            Console.WriteLine("4 - Salir");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        seleccion = "comprado";
                        break;

                    case 2:
                        seleccion = "vendido";
                        break;

                    case 3:
                        seleccion = "alquilado";
                        break;

                    case 4:
                        Console.WriteLine("Ha seleccionado Salir.");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                if (opcion == 1 || opcion == 2 || opcion == 3)
                {
                    Console.WriteLine("---- Autos disponibles ----");
                    Console.WriteLine("1 - Mazda");
                    Console.WriteLine("2 - Mercedes");
                    Console.WriteLine("3 - Chevrolet");
                    Console.WriteLine("4 - Renault");
                    Console.WriteLine("5 - BMW");
                    Console.Write("Seleccione un auto: ");

                    if (int.TryParse(Console.ReadLine(), out int opcionAuto) && opcionAuto >= 1 && opcionAuto <= 5)
                    {
                        Console.WriteLine($"Ha {seleccion} un {autos[opcionAuto - 1].Nombre} por {autos[opcionAuto - 1].Precio:C} {autos[opcionAuto - 1].Condicion}.");
                    }
                    else
                    {
                        Console.WriteLine("Opción no válida. Ingrese un número de auto válido.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Opción no válida. Ingrese un número válido.");
            }

            Console.WriteLine();
        } while (opcion != 4);
    }
}
