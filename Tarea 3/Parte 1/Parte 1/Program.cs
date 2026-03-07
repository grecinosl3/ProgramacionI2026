/*
 //-------------- En este mismo archivo estan agregado la parte 1 y 2 de la tarea --------------

//Desafio 1
static void Programa(){
    Console.WriteLine("---Bienvenido---");
    Console.WriteLine("Ingresa tu nombre: ");
    string nombre = Console.ReadLine();

    int suma = 0;
    int ingreso;
    
    for (int i = 1; i <= 3; i++)
    {
        Console.WriteLine($"Ingrese el ingreso del mes: {i}");
        ingreso = int.Parse(Console.ReadLine());
        suma += ingreso;

    }
    int promedio = suma / 3;
    Console.WriteLine($"Su promedio es: {promedio}");
    
    Console.WriteLine($"Tu nombre es: {nombre}, tu ingreso es: {suma} y tu promedio es: {promedio}");
}
Programa();



//------------Desafio 2------------

namespace Desafios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----Bienvenido----");
            Console.WriteLine("Ingrese un numero: ");
            double numero = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero: ");
            double numero2 = double.Parse(Console.ReadLine());
            double resultado = Calculadora.sumar(numero, numero2);
        }
    }
};

//-----Desafio 3-----
static void Menu()
{
    Console.WriteLine("---Bienvenido---");
    try
    {
        Console.WriteLine("Ingrese un numero: ");
        string numero = Console.ReadLine();
        //Convertimos a tipo double
        double numero1 = double.Parse(numero);
        Console.WriteLine("Ingrese otro numero: ");
        numero =  Console.ReadLine();
        double numero2 = double.Parse(numero);
        double suma = numero1 + numero2;
        Console.WriteLine("La suma es: " + suma);
    }
    catch (Exception ex)
    {
        Console.WriteLine("La aplicacion fallo debido a " + ex.Message);
    }
    finally
    {

    }
    Console.WriteLine("El programa ha terminado...");
}
Menu();
//----------Fin Desafio 3----------


//----------Desafio 4----------
using System;

class SistemaLogin()
{
    static string usuarioRegistrado = "";
    static string passwordRegistrado = "";
    static bool hayusuario = false;

    static void Main()
    {
        int opcion = 0;
        while (opcion !=3)
        {
            Console.WriteLine("--- MENU PRINCIPAL---");
            Console.WriteLine("1. Registrarse ");
            Console.WriteLine("2. Iniciar Sesión ");
            Console.WriteLine("3. Salir ");
            Console.WriteLine("Elige una opcion para continuar ");
            
            opcion = int.Parse(Console.ReadLine());
            
            if (opcion == 1)
            {
                registrarse();
            }
            else if (opcion == 2)
            {
                iniciarSesion();
            }
            else if (opcion == 3)
            {
                Console.WriteLine("Gracias, Hasta luego");
            }
            else
            {
                Console.WriteLine("Opcion no valida");
            }
        } 
    }
        
    static void registrarse()
    {
        Console.WriteLine("---Registro---");
        if (hayusuario == true)
        {
            Console.WriteLine("Ya hay un usuario registrado");
            return;
        }
        
        Console.Write("Escribe un nombre de usuario: ");
        string usuario = Console.ReadLine();

        Console.Write("Escribe una contraseña: ");
        string password = Console.ReadLine();

        if (usuario == "" || password == "")
        {
            Console.WriteLine("El usuario y la contraseña no pueden estar vacios");
        }
        else
        {
            usuarioRegistrado = usuario;
            passwordRegistrado = password;
            hayusuario = true;
            Console.WriteLine("Usuario registrado con exito");
        }
    }

    static void iniciarSesion()
    {
        Console.WriteLine("--- INICIO DE SESIÓN ---");

        if (hayusuario == false)
        {
            Console.WriteLine("Debes registrarte primero");
            return;
        }
        
        Console.Write("Escribe un nombre de usuario: ");
        string usuario = Console.ReadLine();
        
        Console.Write("Escribe una contraseña");
        string password = Console.ReadLine();

        if (usuario == usuarioRegistrado && password == passwordRegistrado)
        {
            Console.WriteLine($"Bienvenido {usuario} con exito");
        }
        else if (usuario != usuarioRegistrado)
        {
            Console.WriteLine("El usuario no existe");
        }
        else
        {
            Console.WriteLine("Contraseña incorrecta");
        } 
    }
}
//----- Fin del desafio 4 -----


//----- Desafio 5 ------

using System.Diagnostics;

class Juego
{
    static int Puntaje = 0;
    static string JugadorRecord = "";


    static void PuntajeObtenido(int puntaje, string nombreJugador)
    {
        if (puntaje > Puntaje)
        {
            Puntaje = puntaje;
            JugadorRecord = nombreJugador;
            Console.WriteLine($"La nueva puntuacion mas alta es: {Puntaje}");
            Console.WriteLine($"La puntuación mas alta fue lograda por : {JugadorRecord}");
        }
        else
        {
            Console.WriteLine(
                $"La puntuación mas alta de {Puntaje}, no se ha podido superar, y aún está mano de {JugadorRecord} ");
        }
        
    }
    static void Main()
    {
        PuntajeObtenido(150, "Gerson");
        PuntajeObtenido(200, "Enrique");
        PuntajeObtenido(100, "Luis");
    }
}
//----- Fin del desafio 5 ------

*/
