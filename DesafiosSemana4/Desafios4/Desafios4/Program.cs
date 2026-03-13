/*
//Desafio 1
static void desafio1()
{
    Console.WriteLine("--- Bienvenido ---");
    Console.WriteLine("Ingresa un número entero positivo: ");
    
    string numero = Console.ReadLine();
    int limite = int.Parse(numero);
    
    Console.WriteLine("Los numero pares son: ");
    
    for (int i = 1; i <= limite;  i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
}
desafio1();
*/

/*
//Desafio2
static void desafio2()
{
    Console.WriteLine("--- Bienvenido ---");
    Console.WriteLine("Ingrese un numero entero positivo: ");
    int numero = int.Parse(Console.ReadLine());

    int divisores = 0;

    for (int i = 1; i <= numero; i++)
    {
        if (numero % i == 0)
        {
            divisores++;
        }
    }

    if (divisores == 2)
    {
        Console.WriteLine($"El numero {numero} es primo");
    }
    else
    {
        Console.WriteLine($"El numero {numero} no es primo");
    }
}
desafio2();
*/

/*
//Desafio3
static void desafio3() 
{
    Console.WriteLine("--- Bienvenido ---");
    Console.WriteLine("Programa para calcular el puntaje promedio");

    double suma = 0;
    int contadorNotas = 0;

    while (true)
    {
        Console.WriteLine("Ingrese una nota (1-10) o escriba 'fin' para terminar: ");
        string entrada = Console.ReadLine();

        if (entrada == "fin")
        {
            break;
        }
        else
        {
            try 
            {
                // Intentamos convertir la entrada a número
                double nota = Convert.ToDouble(entrada);

                // Si llega aquí, es un número. Ahora validamos el rango:
                if (nota >= 1 && nota <= 10)
                {
                    suma += nota;
                    contadorNotas++;
                }
                else
                {
                    Console.WriteLine("Error: La nota debe estar entre 1 y 10.");
                }
            }
            catch (FormatException)
            {
                // Si el usuario escribió letras en lugar de números, cae aquí
                Console.WriteLine("Error: Eso no es un número válido.");
            }
        }
    }
    if (contadorNotas > 0)
    {
        double promedio = suma / contadorNotas;
        Console.WriteLine($"El promedio de las {contadorNotas} notas es: {promedio}");
    }
    else
    {
        Console.WriteLine("No se ingresaron notas.");
    }
}
desafio3();
Console.ReadKey();
*/