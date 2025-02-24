using System;
using System.Collections.Generic;
using System.Linq;

namespace vacuna_ej
{
    // Definimos clase ciudadano
    public class Ciudadano
    {
        public int Id { get; set; } // Id del ciudadano
        public string Nombre { get; set; } // Nombre del ciudadano
        public string Vacuna { get; set; } // Vacuna colocada
        public bool RecibioDosDosis { get; set; } // Identifica si recibió dosis de vacuna
    }
    
    // Clase que ejecuta los ejercicios
    public class Ejecutar
    {
        // Vacío para poner ejercicios
        public static void ejercicios()
        {
            // Inicialización del generador de números aleatorios
            Random rand = new Random();

            // Crear el conjunto ficticio de 500 ciudadanos
            var ciudadanos = new HashSet<Ciudadano>();
            for (int i = 1; i <= 500; i++)
            {
                ciudadanos.Add(new Ciudadano
                {
                    Id = i,
                    Nombre = "Ciudadano " + i, // Asignar nombre ficticio
                    Vacuna = null, // Inicialmente sin vacuna
                    RecibioDosDosis = false // Inicialmente no ha recibido dos dosis
                });
            }

            // Mezclar la lista de ciudadanos de forma aleatoria
            var ciudadanosList = ciudadanos.OrderBy(c => rand.Next()).ToList();

            // Crear el conjunto ficticio de 75 ciudadanos vacunados con Pfizer
            var vacunadosPfizer = ciudadanosList.Take(75).ToHashSet();
            foreach (var c in vacunadosPfizer)
            {
                c.Vacuna = "Pfizer";
            }

            // Crear el conjunto ficticio de 75 ciudadanos vacunados con AstraZeneca
            var vacunadosAstraZeneca = ciudadanosList.Skip(75).Take(75).ToHashSet();
            foreach (var c in vacunadosAstraZeneca)
            {
                c.Vacuna = "AstraZeneca";
            }

            // Asignar dos dosis a algunos ciudadanos (por ejemplo, 10 ciudadanos al azar)
            var dosDosisCiudadanos = ciudadanosList.OrderBy(c => rand.Next()).Take(10).ToList();
            foreach (var c in dosDosisCiudadanos)
            {
                c.RecibioDosDosis = true;
                c.Vacuna = "Pfizer"; // Asignar una vacuna a los ciudadanos con dos dosis
            }

            // Bucle que llama a las funciones que ejecutan los ejercicios y nos da sus resultados
            while (true)
            {
                Console.WriteLine("\n\n########################################################\nBienvenido al menú de selección de ciudadanos vacunados.\n########################################################\n\nSeleccione la consulta que desea realizar:\n(1) Listado de ciudadanos\n(2) Ciudadanos vacunados con Pfizer\n(3) Ciudadanos vacunados con AstraZeneca\n(4) Ciudadanos que recibieron ambas vacunas\n(5) Ciudadanos no vacunados\n(6) Salir\n");
                string opcion_escojer = Console.ReadLine();
                Console.WriteLine();
                switch (opcion_escojer)
                {
                    case "1":
                        descripcion("Usted ha seleccionado la opción 1...");
                        Console.WriteLine("Listado de todos los ciudadanos:");
                        ciudadanos.ToList().ForEach(c => Console.WriteLine(c.Nombre));
                        break;
                    case "2":
                        descripcion("Usted ha seleccionado la opción 2...");
                        // Listado de ciudadanos que solamente han recibido la vacuna de Pfizer
                        var soloPfizer = ciudadanos.Where(c => c.Vacuna == "Pfizer" && !c.RecibioDosDosis).ToList();
                        Console.WriteLine("\nListado de ciudadanos que solamente han recibido la vacuna de Pfizer:");
                        soloPfizer.ForEach(c => Console.WriteLine(c.Nombre));
                        break;
                    case "3":
                        descripcion("Usted ha seleccionado la opción 3...");
                        // Listado de ciudadanos que solamente han recibido la vacuna de AstraZeneca
                        var soloAstraZeneca = ciudadanos.Where(c => c.Vacuna == "AstraZeneca" && !c.RecibioDosDosis).ToList();
                        Console.WriteLine("\nListado de ciudadanos que solamente han recibido la vacuna de AstraZeneca:");
                        soloAstraZeneca.ForEach(c => Console.WriteLine(c.Nombre));
                        break;
                    case "4":
                        descripcion("Usted ha seleccionado la opción 4...");
                        // Listado de ciudadanos que han recibido las dos vacunas
                        var dosDosis = ciudadanos.Where(c => c.RecibioDosDosis).ToList();
                        Console.WriteLine("\nListado de ciudadanos que han recibido las dos vacunas:");
                        dosDosis.ForEach(c => Console.WriteLine(c.Nombre));
                        break;
                    case "5":
                        descripcion("Usted ha seleccionado la opción 5...");
                        // Listado de ciudadanos que no se han vacunado
                        var noVacunados = ciudadanos.Where(c => c.Vacuna == null).ToList();
                        Console.WriteLine("Listado de ciudadanos que no se han vacunado:");
                        noVacunados.ForEach(c => Console.WriteLine(c.Nombre));
                        break;

                    // Mensaje que nos ayuda a cerrar el Menú
                    case "6":
                        descripcion("Usted ha seleccionado la opción salir...");
                        return;

                    // Mensaje de error por opciones no válidas
                    default:
                        descripcion("Opción no valida, seleccione una opción nuevamente.");
                        break;
                }
            }

            // Función para mostrar descripciones
            static void descripcion(string descripcion)
            {
                Console.WriteLine(descripcion);
            }
        }
    }
}

// Ejecutar el menú y todos los procesos
public class Imprimir_10
{
    public static void Main()
    {
        vacuna_ej.Ejecutar.ejercicios();
    }
}
