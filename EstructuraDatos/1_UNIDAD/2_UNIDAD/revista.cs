// Busqueda de revistas por letra (método recursivo)
namespace CatalogoDeRevistas
{
    // Clase que representa una revista
    public class Revista
    {
        public string Titulo { get; set; }
    }

   // Clase que gestiona el catálogo de revistas
    public class CatalogoRevistas
    {
        private List<Revista> revistas;

        // Constructor que inicializa la lista de revistas
        public CatalogoRevistas()
        {
            revistas = new List<Revista>();
        }

       // Agrega una nueva revista al catálogo
        public void AgregarRevista(string titulo)
        {
            revistas.Add(new Revista { Titulo = titulo });
        }

        // Búsqueda de revistas por la letra del abecedario
        public Revista BuscarPorLetra(char letra)
        {
            return revistas.Find(r => r.Titulo.StartsWith($"Revista {letra}:", StringComparison.OrdinalIgnoreCase));
        }

        // Ordena la lista de revistas alfabéticamente
        public void OrdenarCatalogo()
        {
            revistas.Sort((r1, r2) => string.Compare(r1.Titulo, r2.Titulo, StringComparison.OrdinalIgnoreCase));
        }
    }
}

namespace CatalogoDeRevistas
{
    // Clase que encapsula la ejecución de la aplicación en consola
    public static class ProgramaConsola
    {
        public static void Ejecutar()
        {
            CatalogoRevistas catalogo = new CatalogoRevistas();

            // Agregar 10 títulos predefinidos al catálogo
            catalogo.AgregarRevista("Revista A: La gran moda");
            catalogo.AgregarRevista("Revista B: Vistazo");
            catalogo.AgregarRevista("Revista C: Los jóvenes de hoy");
            catalogo.AgregarRevista("Revista D: Viva la vida");
            catalogo.AgregarRevista("Revista E: Detrás de cortinas");
            catalogo.AgregarRevista("Revista F: Secretos en el paraíso");
            catalogo.AgregarRevista("Revista G: Ecnamoda");
            catalogo.AgregarRevista("Revista H: Mientras usted duerme");
            catalogo.AgregarRevista("Revista I: La vida de un gato");
            catalogo.AgregarRevista("Revista J: Sport");

            // Asegurarse de que el catálogo esté ordenado
            catalogo.OrdenarCatalogo();

            // Mostrar el menú
            MostrarMenu(catalogo);
        }

        private static void MostrarMenu(CatalogoRevistas catalogo)
        {
            while (true)
            {
                Console.WriteLine("\n\n########################################################\nBienvenido al menú de selección de Revistas.\n########################################################\n\n");
                Console.WriteLine("1. Buscar revista por letra (recursiva)");
                Console.WriteLine("2. Salir");
                Console.Write("Seleccione una opción: ");

                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese la letra inicial de la revista (A, B, C, D, E, F, G, H, I, J.): ");
                        char letra = Console.ReadLine()[0];
                        Revista revistaEncontrada = catalogo.BuscarPorLetra(letra);
                        if (revistaEncontrada != null)
                        {
                            Console.WriteLine($"Revista encontrada: {revistaEncontrada.Titulo}");
                        }
                        else
                        {
                            Console.WriteLine("No se encontró ninguna revista con esa letra.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Saliendo del programa.");
                        return;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}