using System;

class ListaTareas
{
    static string[] tareas = new string[100]; // Arreglo para guardar tareas
    static int totalTareas = 0;               // Cuántas tareas hay actualmente

    static void Main()
    {
        int opcion = 0;

        Console.WriteLine("=== LISTA DE TAREAS ===");

        while (opcion != 4)
        {
            Console.WriteLine("\n--- MENÚ ---");
            Console.WriteLine("1. Mostrar tareas");
            Console.WriteLine("2. Agregar tarea");
            Console.WriteLine("3. Eliminar tarea");
            Console.WriteLine("4. Salir");
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());

            if (opcion == 1)
            {
                MostrarTareas();
            }
            else if (opcion == 2)
            {
                AgregarTarea();
            }
            else if (opcion == 3)
            {
                EliminarTarea();
            }
            else if (opcion != 4)
            {
                Console.WriteLine("Opción no válida.");
            }
        }

        Console.WriteLine("¡Hasta luego!");
    }

    static void MostrarTareas()
    {
        if (totalTareas == 0)
        {
            Console.WriteLine("No hay tareas.");
            return;
        }

        Console.WriteLine("\n--- TAREAS PENDIENTES ---");
        for (int i = 0; i < totalTareas; i++)
        {
            Console.WriteLine($"{i + 1}. {tareas[i]}");
        }
    }

    static void AgregarTarea()
    {
        Console.Write("Escribe la nueva tarea: ");
        string nuevaTarea = Console.ReadLine();

        tareas[totalTareas] = nuevaTarea;
        totalTareas++;

        Console.WriteLine("¡Tarea agregada!");
    }

    static void EliminarTarea()
    {
        if (totalTareas == 0)
        {
            Console.WriteLine("No hay tareas para eliminar.");
            return;
        }

        MostrarTareas();
        Console.Write("¿Cuál tarea deseas eliminar? (número): ");
        int numero = int.Parse(Console.ReadLine());

        if (numero < 1 || numero > totalTareas)
        {
            Console.WriteLine("Número no válido.");
            return;
        }

        // Desplazar las tareas hacia arriba para llenar el hueco
        for (int i = numero - 1; i < totalTareas - 1; i++)
        {
            tareas[i] = tareas[i + 1];
        }

        totalTareas--;
        Console.WriteLine("¡Tarea eliminada!");
    }
}