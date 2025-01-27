using System.Reflection.Metadata.Ecma335;

// Numeral 1: Tomando en cuenta la teoría de la clase sobre pilas, resuelva el código en C# la verificación  de una operación matemática se encuentran balanceados: Ej: {7+(8*5)-[(9-7)+(4+1)]} resultado => formula balanceada.
namespace ejercicio1_7
{
    //Verificación de balanceo de operaciones matemáticas en C#
    public class Inicio{
        public static bool EstaBalanceada(string formula){
            Stack<char> pila = new Stack<char>();
            foreach (char c in formula){
                if (c == '(' || c == '[' || c == '{'){
                     pila.Push(c);  // Agrega símbolos de apertura a la pila
                }
                else if (c == ')' || c == ']' || c == '}'){
                    if (pila.Count == 0 || !Coinciden(pila.Pop(), c)){
                        return false;  // La fórmula no está balanceada
                    }
                }
            }
            return pila.Count == 0;  // La fórmula está balanceada si la pila está vacía
        }
        public static bool Coinciden(char apertura, char cierre){
             return (apertura == '(' && cierre == ')') ||
                    (apertura == '[' && cierre == ']') ||
                    (apertura == '{' && cierre == '}');

        }
        // Llamar a las funciones que resuelven el ejercicio
        public static void Run(){
            string formula = "{[2*(3+4)]/(5-1)} + (6/(2+1))";
            Console.WriteLine(formula + (EstaBalanceada(formula) ? " es una Fórmula balanceada" : " es una Fórmula no balanceada"));
        }
    }
    


// Numeral 2: Realice un algoritmo en C# y el uso de pilas para resolver el problema de las torres de Hanoi.
namespace ejercicio2_7
{
    //Algoritmo de las Torres de Hanoi usando pilas en C#
    public class Inicio{
        public static void MoverDiscos(int n, Stack<int> origen, Stack<int> destino, Stack<int> auxiliar){
            if (n == 1){
                destino.Push(origen.Pop());  // Mueve un disco
                MostrarTorres(origen, destino, auxiliar);
                return;
            }
            MoverDiscos(n - 1, origen, auxiliar, destino);  // Mueve n-1 discos al auxiliar
            destino.Push(origen.Pop());  // Mueve el disco restante al destino
            MostrarTorres(origen, destino, auxiliar);
            MoverDiscos(n - 1, auxiliar, destino, origen);  // Mueve n-1 discos al destino

        }
        public static void MostrarTorres(Stack<int> origen, Stack<int> destino, Stack<int> auxiliar){
            // Método para mostrar el estado actual de las torres
            Console.WriteLine("Torre Origen: " + ImprimirTorre(origen));
            Console.WriteLine("Torre Destino: " + ImprimirTorre(destino));
            Console.WriteLine("Torre Auxiliar: " + ImprimirTorre(auxiliar));
            Console.WriteLine();
        }

        // Método para ver el estado de las torres
        public static string ImprimirTorre(Stack<int> torre){
            return string.Join(", ", torre.ToArray());
        }

        // Llamar a las funciones que resuelven el algoritmo
        public static void Run(){
            int numeroDeDiscos = 3;
            Stack<int> torreOrigen = new Stack<int>();
            Stack<int> torreDestino = new Stack<int>();
            Stack<int> torreAuxiliar = new Stack<int>();

            for (int i = numeroDeDiscos; i >= 1; i--){
                torreOrigen.Push(i);  // Llena la torre de origen
            }
            MostrarTorres(torreOrigen, torreDestino, torreAuxiliar);
            MoverDiscos(numeroDeDiscos, torreOrigen, torreDestino, torreAuxiliar);
        }
    }
}




// Menu que ejecuta todos los ejercicios
public static class Menusemana7{
    public static void Run(){
        // Bucle que llama a las funciones que ejecutan los ejercicios y nos da sus resultados
        while (true)
        {
            Console.WriteLine("\n\n########################################################\nBienvenido al menú de selección de ejercicios de PILAS.\n########################################################\n\nSeleccione el ejercicio que desea ejecutar:\n(1) Ejercicio 1\n(2) Ejercicio 2\n(3) Salir\n");
            string opcion_escojer = Console.ReadLine();
            Console.WriteLine();
            switch (opcion_escojer)
            {
                case "1":   
                    descripcion("Usted ha seleccionado la opción 1...");
                    ejercicio1_7.Inicio.Run();
                    break;
                case "2":
                    descripcion("Usted ha seleccionado la opción 2...");
                    ejercicio2_7.Inicio.Run();
                    break;
                // Mensaje que nos ayuda a cerrar el Menú
                case "3": 
                    descripcion("Usted ha seleccionado la opción salir...");
                    return;
                
                // Mensaje de error por opciones no válidas
                default:
                    descripcion("Opción no valida, seleccione una opción nuevamente.");
                    break;
            }
            static void descripcion(string descripcion){
                Console.WriteLine(descripcion);
            }
        }
    }
}

// Ejecutar el menú y todos los procesos
public class Imprimir_sem7{
    public static void Main(){
        Menusemana7.Run();
    }
} 
}

