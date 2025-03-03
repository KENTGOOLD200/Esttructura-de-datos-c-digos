// Creación de Diccionario (ingles - español) (español - ingles)
public class Diccionario{
    // Diccionario para inglés-español
    static Dictionary<string, string> ingles_español = new Dictionary<string, string>{
        {"time", "tiempo"},
        {"person", "persona"},
        {"year", "año"},
        {"way", "camino"},
        {"day", "día"},
        {"thing", "cosa"},
        {"man", "hombre"},
        {"world", "mundo"},
        {"life", "vida"},
        {"hand", "mano"},
        {"part", "parte"},
        {"child", "niño/a"},
        {"eye", "ojo"},
        {"woman", "mujer"},
        {"place", "lugar"},
        {"work", "trabajo"},
        {"week", "semana"},
        {"case", "caso"},
        {"point", "punto"},
        {"government", "gobierno"},
        {"company", "empresa"}
    };

    // Diccionario para español-inglés
    static Dictionary<string, string> español_ingles = new Dictionary<string, string>{
        {"tiempo", "time"},
        {"persona", "person"},
        {"año", "year"},
        {"camino", "way"},
        {"día", "day"},
        {"cosa", "thing"},
        {"hombre", "man"},
        {"mundo", "world"},
        {"vida", "life"},
        {"mano", "hand"},
        {"parte", "part"},
        {"niño", "child"},
        {"ojo", "eye"},
        {"mujer", "woman"},
        {"lugar", "place"},
        {"trabajo", "work"},
        {"semana", "week"},
        {"caso", "case"},
        {"punto", "point"},
        {"gobierno", "government"},
        {"empresa", "company"}
    };

    // Menú interactivo que encapsula todos los métodos
    public static void MostrarMenu(){
        while (true){
            Console.WriteLine("\n\n###########################################################");
            Console.WriteLine("Bienvenido al Diccionario (inglés-español)(español-inglés)");
            Console.WriteLine("###########################################################\n\nMENU\nSeleccione una opción:");
            Console.WriteLine("1. Traducir una frase");
            Console.WriteLine("2. Ingresar más palabras al diccionario");
            Console.WriteLine("3. Imprimir diccionario inglés-español");
            Console.WriteLine("4. Imprimir diccionario español-inglés");
            Console.WriteLine("5. Salir");
            Console.Write("Su opción elegida: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion){
                case 1:
                    Traducir_Frase();
                    break;
                case 2:
                    Ingresar_Palabra();
                    break;
                case 3:
                    Imprimir_Diccionario(ingles_español, "Inglés - Español");
                    break;
                case 4:
                    Imprimir_Diccionario(español_ingles, "Español - Inglés");
                    break;
                case 5:
                    Console.WriteLine("Usted ha seleccionado 'Salir'.\nSALIENDO...");
                    return;
                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");
                    break;
            }
        }
    }

    // Método para traducir una frase
    static void Traducir_Frase(){
        Console.Write("Ingrese la frase: ");
        string frase = Console.ReadLine();
        string[] palabras = frase.Split(' ');

        for (int i = 0; i < palabras.Length; i++){
            string palabra = palabras[i].ToLower().Trim(',', '.', '!', '?'); // Convertir palabra a minúscula y eliminar puntuación
            if (ingles_español.ContainsKey(palabra)){
                palabras[i] = ingles_español[palabra];
            }
            else if (español_ingles.ContainsKey(palabra)){
                palabras[i] = español_ingles[palabra];
            }
        }

        string fraseTraducida = string.Join(" ", palabras);
        Console.WriteLine("Su frase traducida es: " + fraseTraducida);
    }
    // Método para ingresar nuevas palabras al diccionario
    static void Ingresar_Palabra(){
        Console.Write("Ingrese la palabra en inglés: ");
        string palabra_Ingles = Console.ReadLine().ToLower();
        Console.Write("Ingrese la traducción en español: ");
        string palabra_Espanol = Console.ReadLine().ToLower();
        
        // Agregar palabra a ambos diccionarios
        if (!ingles_español.ContainsKey(palabra_Ingles)){
            ingles_español.Add(palabra_Ingles, palabra_Espanol);
        }
        if (!español_ingles.ContainsKey(palabra_Espanol)){
            español_ingles.Add(palabra_Espanol, palabra_Ingles);
        }

        Console.WriteLine("La palabra ha sido agregada al diccionario.");
    }

    // Método para imprimir el diccionario
    static void Imprimir_Diccionario(Dictionary<string, string> diccionario, string titulo){
        Console.WriteLine("=========================================");
        Console.WriteLine("Diccionario " + titulo);
        Console.WriteLine("=========================================");
        foreach (var entrada in diccionario){
            Console.WriteLine(entrada.Key + " - " + entrada.Value);

        }

    }
}

// Llamar al menú para ejecutar el programa
public class Ejecutar_11{
    static void Main(){
        Diccionario.MostrarMenu();
    }
}
