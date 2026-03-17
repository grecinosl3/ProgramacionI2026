/* ------Videos 11-20-------
//-----Condicionales-----
Console.WriteLine("---Nota final del alumno---");
int nota = 70;
if (nota >= 70)
{
    Console.WriteLine($"Felicidades pasastes el examen con: {nota}.");
}
else if (nota <70 && nota > 50)
{
    Console.WriteLine($"Debes repetir el examen con {nota}");
}
else
{
    Console.WriteLine($"Reprobaste el examen con: {nota}");
}
*/
/*
//-----Swith Case-----
Console.WriteLine("---Dias de la semana---");
Console.WriteLine("Ingresa el dia de la semana");
int dia = int.Parse(Console.ReadLine());
switch (dia)
{
    case 1: 
        Console.WriteLine("Hoy es Lunes");
        break;
    case 2: 
        Console.WriteLine("Hoy es Martes");
        break;
    case 3: 
        Console.WriteLine("Hoy es Miercoles");
        break;
    case 4: 
        Console.WriteLine("Hoy es Jueves");
        break;
    case 5: 
        Console.WriteLine("Hoy es Viernes");
        break;
    case 6: 
        Console.WriteLine("Hoy es Sabado");
        break;
    case 7: 
        Console.WriteLine("Hoy es Domingo");
        break;
}
*/

/*
//-----Swich expressions-----
//-----Swith Case-----
Console.WriteLine("---Calificaciones---");
Console.WriteLine("Ingresa tu nota");
int nota = int.Parse(Console.ReadLine());
string resultado = nota switch
{
    >= 80 => "Pasaste el examen",
    >= 60 and <= 69 => "Repetir examen",
    _ => "Reprobaste examen"
};
Console.WriteLine(resultado);
*/

/*
//----While-----
int numero = 1;
const int valor = 8;
Console.WriteLine($"Tabla del : {valor}");
while (numero <= 10)
{
    Console.Write($"{valor} X {numero}  = {valor * numero} \n");
    numero++;
    
}
Console.Write("Fin de la tabla");
*/
/*
//-----For-----
Console.WriteLine("Ingrese la tabla");
int vueltas = int.Parse(Console.ReadLine());
for (int f = 1; f <= vueltas; f++)
{
Console.WriteLine($"Numero de vuelta: {f}");

}
Console.WriteLine("Fin del bucle...");


//---Ejercicio tabla de multiplicar con For---
Console.WriteLine("Ingrese la tabla");
int numero = 1;
int valor = int.Parse(Console.ReadLine());
for (int f = 1; f <= 10; f++)
{
    Console.Write($"{valor} X {f}  = {valor * f} \n");

}
Console.WriteLine("Fin del bucle...");

//-----Do While-----
int numero;
do
{
    Console.Write("Introduce cero para salir: ");
    numero = int.Parse(Console.ReadLine());
    Console.WriteLine($"Numero colocado {numero} \nIntente de nuevo...");
} while (numero != 0);
Console.WriteLine($"Numero valido: {numero}");
Console.WriteLine("---Fin del programa---");


//-----------Videos 20-30-----------
//-----Break - Continue-----

for (int f = 0; f < 10; f+=2)
{
    if (f == 6)
    {
        //break;
        continue;
    }
    Console.Write($"Vuelta: {f}\n");
}
*/

//-----Clase Math-----
//Potencia
