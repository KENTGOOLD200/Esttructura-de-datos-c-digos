// Ejercicio 1: Escribir un programa que almacene los vectores (1,2,3) y (-1,0,2) en dos listas y muestre por pantalla su producto escalar
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace ejercicio1{
        public class Programa_correr{
        public static void Proceso(){
            // Definimos los vectores como listas
            List<int> vector_a = new List<int>{1,2,3};
            List<int> vector_b = new List<int>{-1,0,2};
            
            // Calculo del producto escalar
            int p_escalar = 0;
            for (int i = 0; i < vector_a.Count; i++){
            p_escalar += vector_a[i]*vector_b[i];
            }

            // Ejecutar el proceso
            Console.WriteLine("\nEscribir un programa que almacene los vectores (1,2,3) y (-1,0,2) en dos listas y muestre por pantalla su producto escalar\n\n");
            Console.WriteLine($"Resultado:\nEl producto escalar de los vectores es: {p_escalar}");
        }
    }
}

// Ejercicio 2:Escribir un programa que almacene en una lista los números del 1 al 10 y los muestre por pantalla en orden inverso separados por comas.
namespace ejercicio2{
    public class Programa_correr{
        public static void Proceso(){
            // Creamos una lista del 1 al 10
            List<int> listanum = new List<int>();
            for (int i=1;i<=10;i++){
                listanum.Add(i);
            }

            // Invertimos la lista 
            listanum.Reverse();

            // Imprimimos los números en orden inverso separado por comas

            Console.WriteLine("\nEscribir un programa que almacene en una lista los números del 1 al 10 y los muestre por pantalla en orden inverso separados por comas.\n\nResultado:");
            Console.WriteLine(string.Join(",",listanum));
        }
    }
}

// Ejercicio 3: Escribir un programa que almacene el abecedario en una lista, elimine de la lista las letras que ocupen posiciones múltiplos de 3, y muestre por pantalla la lista resultante.
namespace ejercicio3{
    public class Programa_correr{
        public static void Proceso(){
            // Inicializamos una lista con el abecedario
            List<char> abc = new List<char>();
            for(char caracter='a';caracter<='z';caracter++){
                abc.Add(caracter);
            }
            // Proceso de eliminar las posiviones multiplos de 3
            for(int i=abc.Count-1;i>=0;i--){
                if ((i+1)%3==0){
                    abc.RemoveAt(i);
                }
            }

            // Imprimir lista resultante
            Console.WriteLine("\nEscribir un programa que almacene el abecedario en una lista, elimine de la lista las letras que ocupen posiciones múltiplos de 3, y muestre por pantalla la lista resultante.\n\nResultado:\n");
            Console.WriteLine(string.Join(",",abc));
        }   
    }
}

// Ejercicio 4: Escribir un programa que almacene en una lista los siguientes precios, 50, 75, 46, 22, 80, 65, 8, y muestre por pantalla el menor y el mayor de los precios.
namespace ejercicio4{
    public class Programa_correr{
        public static void Proceso(){
            // Inicializar una lista con precios
            List<int> precios = new List<int> {
                50,75,46,22,80,65,8
            };
            // Encontrar el precio mayor y el precio menor
            int precio_menor = int.MaxValue;
            int precio_mayor = int.MinValue;

            foreach (int precio in precios)
            {
                if(precio<precio_menor){
                    precio_menor = precio;
                }
                if(precio>precio_mayor){
                    precio_mayor = precio;
                }
            }

            // Imprimir los resultados
            Console.WriteLine("\nEscribir un programa que almacene en una lista los siguientes precios, 50, 75, 46, 22, 80, 65, 8, y muestre por pantalla el menor y el mayor de los precios.\n\nResultado:\n");
            Console.WriteLine($"El precio menor es: {precio_menor}\nEl precio mayor es: {precio_mayor}");
        }
    }
}

// Ejercicio 5: Escribir un programa que pregunte por una muestra de números, separados por comas, los guarde en una lista y muestre por pantalla su media y desviación típica.
namespace ejercicio5{
    public class Programa_correr{
        public static void Proceso(){
            // Solicitar muestra de números al usuario
            Console.WriteLine("Introduzca su muestra de números SEPARADOS POR COMAS:");
            String Solicitud = Console.ReadLine();

            // Conversión de la entrada en números enteros
            List<Double>muestra = Solicitud.Split(',').Select(double.Parse).ToList();

            // Proceso de cálculo de media
            Double media = muestra.Average();

            // Calcular desviación típica
            Double suma_de_cuadrados = muestra.Select(num=>Math.Pow(num-media,2)).Sum();
            Double desviación = Math.Sqrt(suma_de_cuadrados/muestra.Count);

            // Imprimimos resultados
            Console.WriteLine("\nEscribir un programa que pregunte por una muestra de números, separados por comas, los guarde en una lista y muestre por pantalla su media y desviación típica.\n\nResultado:\n");
            Console.WriteLine($"La media es: {media}\nLa desviación típica es: {desviación}");
        }
    }
}


// Menu que ejecuta todos los ejercicios
public static class Menusemana5{
    public static void Run(){
        // Bucle que llama a las funciones que ejecutan los ejercicios y nos da sus resultados
        while (true)
        {
            Console.WriteLine("\n\n########################################################\nBienvenido al menú de selección de ejercicios de listas.\n########################################################\n\nSeleccione el ejercicio que desea ejecutar:\n(1) Ejercicio 1\n(2) Ejercicio 2\n(3) Ejercicio 3\n(4) Ejercicio 4\n(5) Ejercicio 5\n(6) Salir\n");
            string opcion_escojer = Console.ReadLine();
            Console.WriteLine();
            switch (opcion_escojer)
            {
                case "1":   
                    descripcion("Usted ha seleccionado la opción 1...");
                    ejercicio1.Programa_correr.Proceso();
                    break;
                case "2":
                    descripcion("Usted ha seleccionado la opción 2...");
                    ejercicio2.Programa_correr.Proceso();
                    break;
                case "3":
                    descripcion("Usted ha seleccionado la opción 3...");
                    ejercicio3.Programa_correr.Proceso(); 
                    break;
                case "4":
                    descripcion("Usted ha seleccionado la opción 4...");
                    ejercicio4.Programa_correr.Proceso();
                    break;
                case "5":
                    descripcion("Usted ha seleccionado la opción 5...");
                    ejercicio5.Programa_correr.Proceso();
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
            static void descripcion(string descripcion){
                Console.WriteLine(descripcion);
            }
        }
    }
}

// Ejecutar el menú y todos los procesos
public class Imprimir{
    public static void Main(){
        Menusemana5.Run();
    }
} 

