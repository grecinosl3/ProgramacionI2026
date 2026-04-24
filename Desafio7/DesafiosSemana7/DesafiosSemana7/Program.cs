using System;

class ToTiTo
{
    // Arreglo multidimensional 3x3 que representa el tablero
    static char[,] tablero = new char[3, 3];

    static void Main()
    {
        InicializarTablero();
        char jugadorActual = 'X';
        bool juegoTerminado = false;

        Console.WriteLine("------ BIENVENIDO AL TOTITO -----");

        while (!juegoTerminado)
        {
            MostrarTablero();
            Console.WriteLine($"Turno del jugador: {jugadorActual}");

            // Pedir fila
            Console.Write("Ingresa la fila (0, 1 o 2): ");
            int fila = int.Parse(Console.ReadLine());

            // Pedir columna
            Console.Write("Ingresa la columna (0, 1 o 2): ");
            int columna = int.Parse(Console.ReadLine());

            // Validar que la casilla esté vacía
            if (tablero[fila, columna] != ' ')
            {
                Console.WriteLine("Esa casilla ya está ocupada. Intenta de nuevo.");
                continue;
            }

            // Colocar la ficha del jugador
            tablero[fila, columna] = jugadorActual;

            // Verificar si ganó
            if (VerificarGanador(jugadorActual))
            {
                MostrarTablero();
                Console.WriteLine($"¡El jugador {jugadorActual} GANÓ!");
                juegoTerminado = true;
            }
            // Verificar empate
            else if (VerificarEmpate())
            {
                MostrarTablero();
                Console.WriteLine("¡Es un EMPATE!");
                juegoTerminado = true;
            }
            else
            {
                // Cambiar turno
                jugadorActual = (jugadorActual == 'X') ? 'O' : 'X';
            }
        }

        Console.WriteLine("Gracias por jugar.");
    }

    // Llena el tablero con espacios vacíos
    static void InicializarTablero()
    {
        for (int fila = 0; fila < 3; fila++)
        {
            for (int columna = 0; columna < 3; columna++)
            {
                tablero[fila, columna] = ' ';
            }
        }
    }

    // Muestra el tablero en consola
    static void MostrarTablero()
    {
        Console.WriteLine("\n  0   1   2");
        for (int fila = 0; fila < 3; fila++)
        {
            Console.Write(fila + " ");
            for (int columna = 0; columna < 3; columna++)
            {
                Console.Write($" {tablero[fila, columna]} ");
                if (columna < 2) Console.Write("|");
            }
            Console.WriteLine();
            if (fila < 2) Console.WriteLine("  ---|---|---");
        }
        Console.WriteLine();
    }

    // Verifica si el jugador actual ganó
    static bool VerificarGanador(char jugador)
    {
        // Revisar filas
        for (int fila = 0; fila < 3; fila++)
        {
            if (tablero[fila, 0] == jugador &&
                tablero[fila, 1] == jugador &&
                tablero[fila, 2] == jugador)
                return true;
        }

        // Revisar columnas
        for (int columna = 0; columna < 3; columna++)
        {
            if (tablero[0, columna] == jugador &&
                tablero[1, columna] == jugador &&
                tablero[2, columna] == jugador)
                return true;
        }

        // Revisar diagonal principal (\)
        if (tablero[0, 0] == jugador &&
            tablero[1, 1] == jugador &&
            tablero[2, 2] == jugador)
            return true;

        // Revisar diagonal inversa (/)
        if (tablero[0, 2] == jugador &&
            tablero[1, 1] == jugador &&
            tablero[2, 0] == jugador)
            return true;

        return false;
    }

    // Verifica si todas las casillas están llenas (empate)
    static bool VerificarEmpate()
    {
        for (int fila = 0; fila < 3; fila++)
        {
            for (int columna = 0; columna < 3; columna++)
            {
                if (tablero[fila, columna] == ' ')
                    return false; // Aún hay casillas vacías
            }
        }
        return true; // Todas llenas = empate
    }
}