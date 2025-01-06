using FigurasGeometricas;

cabecera(); // Usa la función para agregar cabecera
while (true) // Bucle para que se repitan las opciones constantemente
{
    menu(); // Llama a la interfáz de menú
    string opcion_semana = Console.ReadLine(); // Lee la tecla que seleccionemos
    Console.WriteLine();
    switch (opcion_semana) // Switch para escojer varias opciones
    {
        case "0":
            titulo("Ha seleccionado 'Salir', ¡Que tenga un excelente día :D..!");
            pie_pagina(); // Usa la funciòn para agregar pié de página
            return;
        case "1":
            titulo("Ha seleccionado la Semana 1 'Tipos de datos básicos'.\nLo sentimos, no hay códigos programados para esa semana."); // Agrega título usando la función título
            break;
        case "2":
            titulo("Ha seleccionado la Semana 2 'POO'.\nLo sentimos, no hay códigos programados para esa semana."); // Agrega título usando la función título
            break;
        case "3":
            titulo("Ha seleccionado la Semana 3 'Arrays y Matrices'.\n"); // Agrega título usando la función título
            Programa.Run();
            break;
        case "4":
            titulo("Ha seleccionado la Semana 4 'Tipos de Datos Estructurados'.\n"); // Agrega título usando la función título
            APPprograma.Run();
            break;
        case "5":
            titulo("Ha seleccionado la Semana 5.\n¡Estará listo próximamente!."); // Agrega título usando la función título
            break;
        case "6":
            titulo("Ha seleccionado la Semana 6.\n¡Estará listo próximamente!."); // Agrega título usando la función título
            break;
        case "7":
            titulo("Ha seleccionado la Semana 7.\n¡Estará listo próximamente!."); // Agrega título usando la función título
            break;
        case "8":
            titulo("Ha seleccionado la Semana 8.\n¡Estará listo próximamente!."); // Agrega título usando la función título
            break;
        case "9":
            titulo("Ha seleccionado la Semana 9.\n¡Estará listo próximamente!."); // Agrega título usando la función título
            break;
        case "10":
            titulo("Ha seleccionado la Semana 10.\n¡Estará listo próximamente!."); // Agrega título usando la función título
            break;
        case "11":
            titulo("Ha seleccionado la Semana 11.\n¡Estará listo próximamente!."); // Agrega título usando la función título
            break;
        case "12":
            titulo("Ha seleccionado la Semana 12.\n¡Estará listo próximamente!."); // Agrega título usando la función título
            break;
        case "13":
            titulo("Ha seleccionado la Semana 13.\n¡Estará listo próximamente!."); // Agrega título usando la función título
            break;
        case "14":
            titulo("Ha seleccionado la Semana 14.\n¡Estará listo próximamente!."); // Agrega título usando la función título
            break;
        case "15":
            titulo("Ha seleccionado la Semana 15.\n¡Estará listo próximamente!."); // Agrega título usando la función título
            break;
        case "16":
            titulo("Ha seleccionado la Semana 16.\n¡Estará listo próximamente!."); // Agrega título usando la función título
            break;
                
        default: 
        Console.WriteLine("Opciòn no válida, seleccione una opción nuevamente.");
            break;
    }

    pie_pagina(); // Usa la funciòn para agregar pié de página
} 
static void pie_pagina(){ // Función para agregar pié de página
    Console.WriteLine("\n-----------------------\nCreado por @KENTGOOL200\n\n");
} 

static void cabecera(){ // Función para presentar nustro algoritmos, dar contexto al mismo y decorarlo mediante una cabecera
    Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n+++++           UNIVERSIDAD ESTATAL AMAZÓNICA           +++++\n+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\nBienvenido a su gestor de códigos 'Estructura de datos 2024'.\n");
    }

static void menu(){ // Función para agregar una interfáz de menu
     Console.WriteLine("SELECCIONE UNA SEMANA:\n1 (Semana 1)\n2 (Semana 2)\n3 (Semana 3)\n4 (Semana 4)\n5 (Semana 5)\n6 (Semana 6)\n7 (Semana 7)\n8 (Semana 8)\n9 (Semana 9)\n10 (Semana 10)\n11 (Semana 11)\n12 (Semana 12)\n13 (Semana 13)\n14 (Semana 14)\n15 (Semana 15)\n16 (Semana 16)\n-----------------\n0 (Salir)\n");
}

static void titulo(string titulo){ // Función para agregar título de manera ordenada
    Console.WriteLine("=======================================");
    Console.WriteLine(titulo);
    Console.WriteLine("=======================================");
}