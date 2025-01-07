using System;
using System.Collections.Generic;

// Definir record representando al paciente
public record Paciente(string Nombre, int Edad, string Identificación);

// Definir un Struct para representar un Turno.
public struct Turno {
    public Paciente Paciente{get;} // Paciente del turno
    public DateTime Fecha{get;} // Fecha del turno
    public string Especialidad{get;} //Especialidad mèdica para asignar turno

    // Constructor para crear los datos del turno
    public Turno(Paciente paciente, DateTime fecha, string especialidad){
        Paciente = paciente;
        Fecha = fecha;
        Especialidad = especialidad;
    }
}

// Clase que maneja la agenda de turnos
public class Agenda{
    private List<Turno> turnos;
    public Agenda(){
        turnos = new List<Turno>();
    }
    
    // Método para agregar turnos a la agenda
    public void Agregar_turno(Turno turno){
        turnos.Add(turno);
    }

    // Mostrar los turnos almacenados en la agenda
    public void Mostrar_turnos(){
        foreach (var turno in turnos){
            Console.WriteLine($"\nPaciente: {turno.Paciente.Nombre}, Edad: {turno.Paciente.Edad}, Identificación: {turno.Paciente.Identificación}, Especialidad: {turno.Especialidad}, Fecha: {turno.Fecha}");
        }
    }

    //  Matriz de obtención de turnos por la especialidad
    public Turno[,] ObtenerMatizTurnosPorEspecialidad(string especialidad){
        
        // Filtrar turnos por especialidas específica
        var turnosFiltrados = turnos.FindAll(t => t.Especialidad == especialidad);

        // Matríz  con fila para cualquier turno
        Turno[,] matrizTurnos = new Turno[turnosFiltrados.Count, 1];
        
        for (int i = 0; i < turnosFiltrados.Count; i++){
            matrizTurnos[i, 0] = turnosFiltrados[i];    
        }
        return matrizTurnos;
    }
}

// Clase principal de la aplicación 
public partial class APPprograma{
    // Método para un menú interactivo
    public static void Run(){
        var agenda = new Agenda();
        string[] especialidades = {"Dermatología", "Odontología", "Neurología", "Pediatría"};

        while (true){
            Console.WriteLine("\n===============================================\nGestiòn de turnos (Clínica Privada 'San Pedro')\n===============================================\n\nSeleccione el trámite que desea realizar:\n1. Agregar paciente:\n2. Mostrar turnos:\n3. Salir:");
            Console.Write("Selecciona una opción: ");
            var opcion = Console.ReadLine();

            if (opcion == "1"){
                Console.Write("\nNombre:");
                var nombre = Console.ReadLine();
                Console.Write("Edad:");
                var edad = int.Parse(Console.ReadLine());
                Console.Write("Identificación:");
                var identificacion = Console.ReadLine();
                Console.WriteLine("\nEspecialidades Disponibles:");
                for (int i = 0; i < especialidades.Length; i++){
                    Console.WriteLine($"{i + 1}. {especialidades[i]}");
                }
                Console.Write("Selecciona una especialidad: ");
                var especialidad = especialidades[int.Parse(Console.ReadLine()) - 1];
                Console.WriteLine();

                // Crear el paciente y su turno asignado
                var paciente = new Paciente(nombre, edad, identificacion);
                var turno = new Turno(paciente, DateTime.Now, especialidad);

                // Añadir turno a nuestra agenda
                agenda.Agregar_turno(turno);

                // Mostrar turno asignado y sus datos
                Console.WriteLine($"\nDatos del turno asignado:\nPaciente: {turno.Paciente.Nombre}\nEdad: {turno.Paciente.Edad}\nIdentificación: {turno.Paciente.Identificación}\nEspecialidad: {turno.Especialidad}\nFecha: {turno.Fecha}");

            }
            else if (opcion == "2"){
                // Mostrar los turnos de la agenda
                agenda.Mostrar_turnos();
            }
            else if (opcion == "3"){
                // Salir del programa
                Console.WriteLine("\nusted ha elegido Salir. Cerrando el programa....");
                break;
            }
            else{
                Console.WriteLine("\nOpción no valida, por favor, elige unas de las opciones mostradas en pantalla.");
            }
        }
    }
}


// Ejecutar programa. Normalmente lo suelo hacer desde la aplicaciòn de consola
public class Correr(){
    public static void Main(){
        APPprograma.Run();
    }
}