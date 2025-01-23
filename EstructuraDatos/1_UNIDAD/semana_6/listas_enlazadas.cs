

// Crear un programa que maneje N° cantidad de datos de tipo entero en dos listas por el inicio. 
//Debe existir un ciclo de carga para la primera lista y otro ciclo de carga para laDebe existir un ciclo de carga para la primera lista y otro ciclo de carga para la segunda lista.segunda lista.
//Una vez cargados los datos en las listas, el programa debe comparar las dos listas paraUna vez cargados los datos en las listas, el programa debe comparar las dos listas para
//verificar si ambas listas son iguales enverificar si ambas listas son iguales en tamaño y contenido, es decir que sitamaño y contenido, es decir que si tienen la mismatienen la misma
//cantidad de datos y si los datos están cargados en el mismo orden. Una vez realizada, lacantidad de datos y si los datos están cargados en el mismo orden. Una vez realizada, la
//verificación. El programa debe mostrar:verificación. El programa debe mostrar:
//a.a. Si las listas sonSi las listas son iguales en tamaño y eniguales en tamaño y en contenido.contenido.
//b.b. Si las listas sonSi las listas son iguales en tamaño pero no eniguales en tamaño pero no en contenido.contenido.
//c.c. No tienen el mismo tamaño niNo tienen el mismo tamaño ni contenido.contenido.
using System.ComponentModel;

namespace ejercicioS6_1
{
    public class Ejercicio{
        public static void Procesar(){
             // solicitar el tamaño de las listas al usuario
             Console.Write("Ingrese el tamaño de sus listas por favor: ");
             int n = int.Parse(Console.ReadLine());

             // Cargar las dos listas
             Console.WriteLine("Cargando datos de la primera lista");
             List<int> lista1 = Cargardatos(n);

             Console.WriteLine("Cargando datos de la segunda lista:");
             List<int> lista2 = Cargardatos(n);

             // Comparar las listas y mostrar resultados
             string resultadofinal = Comparacion(lista1, lista2);
        }
       static List<int> Cargardatos(int tamaño){
        List<int> lista = new List<int>();
         for (int i = 0; i < tamaño; i++){
           Console.Write($"Ingrese el número {i + 1}: ");
           int num = int.Parse(Console.ReadLine());
           lista.Add(num);
           }
           return lista;
       }
       static string Comparacion(List<int> lista1, List<int> lista2){
        if (lista1.Count != lista2.Count){
            return "No tienen el mismo tamaño ni contenido.";
        }
        for (int i = 0; i < lista1.Count; i++)
        {
            if (lista1[i] != lista2[i])
            {
                return "Las listas son iguales en tamaño pero no en contenido.";
            }
        }
        
        return "Las listas son iguales en tamaño y en contenido.";
    }
}


//Crear un programa que maneje N° cantidad de datos de tipo real en una lista. Una vez
//cargados los datos en lista, el programa debe calcular el promedio de todos los datoscargados los datos en lista, el programa debe calcular el promedio de todos los datos
//cargados. Posteriormente, el programa debe cargar los datos menores o igual al promedio encargados. Posteriormente, el programa debe cargar los datos menores o igual al promedio en
//una segunda lista, y los mayores en una tercera lista. Al finalizar este proceso, el programauna segunda lista, y los mayores en una tercera lista. Al finalizar este proceso, el programa
//debe mostrar lo siguiente:debe mostrar lo siguiente:
//a.a. Los datos cargados en laLos datos cargados en la lista principal.lista principal.
//b.b. El promedio.El promedio.
//c.c. Los datos cuyo valor sea igual o menor al promedio de todos los datos.Los datos cuyo valor sea igual o menor al promedio de todos los datos.
//d.d. Los datos que sean mayores al promedio de todos los datos.Los datos que sean mayores al promedio de todos los datos
namespace ejercicioS6_2
{
    public class Ejercicio{
        public static void Procesar(){
            // Solicitar el tamaño de la lista al usuario
            Console.Write("Ingrese la cantidad de datos por favor: ");
             int n = int.Parse(Console.ReadLine());

            List<double> listaPrincipal = new List<double>();

             // Cargar los datos en la lista principal
             for (int i = 0; i < n; i++){
                Console.Write($"Ingrese el dato {i + 1}: ");
                double dato = double.Parse(Console.ReadLine());
                listaPrincipal.Add(dato);
             }

             // Calcular el promedio de todos los datos
             double suma = 0;
             foreach (double dato in listaPrincipal){
                suma += dato;
             }
             
             double promedio = suma / listaPrincipal.Count;

             // Crear las listas para datos menores o iguales al promedio y mayores al promedio
            List<double> listaMenoresIguales = new List<double>();
        List<double> listaMayores = new List<double>();

        foreach (double dato in listaPrincipal){
            if (dato <= promedio){
                listaMenoresIguales.Add(dato);
            }
            else{
                listaMayores.Add(dato);
            }
        }
        // Mostrar los resultados
         Console.WriteLine("Datos cargados en la lista principal:");
         foreach (double dato in listaPrincipal){
            Console.WriteLine(dato);
         }

         Console.WriteLine("Datos mayores al promedio:");
         foreach (double dato in listaMayores){
            Console.WriteLine(dato);
         }
    }
}

// Menu que ejecuta todos los ejercicios
public static class Menusemana6{
    public static void Run(){
        // Bucle que llama a las funciones que ejecutan los ejercicios y nos da sus resultados
        while (true)
        {
            Console.WriteLine("\n\n########################################################\nBienvenido al menú de selección de ejercicios de listas enlazada.\n########################################################\n\nSeleccione el ejercicio que desea ejecutar:\n(1) Ejercicio 1\n(2) Ejercicio 2\n(3) Salir\n");
            string opcion_escojer = Console.ReadLine();
            Console.WriteLine();
            switch (opcion_escojer)
            {
                case "1":   
                    descripcion("Usted ha seleccionado la opción 1...");
                    ejercicioS6_1.Ejercicio.Procesar();
                    break;
                case "2":
                    descripcion("Usted ha seleccionado la opción 2...");
                    ejercicioS6_2.Ejercicio.Procesar();
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
public class Imprimir{
    public static void Main(){
        Menusemana6.Run();
    }
} 
}
}

