
//-----Imprimir en consola-----
//Console.WriteLine(45);
//Console.WriteLine("Informaticonfig");
//Console.WriteLine(50 + 60);
/*
//-----Tipos de datos-----
int = 1 25 355
double = 3.14 4,566
bool = true / false
char = 'a';
float = 1.50f
string = 'asdasadsad'
Object, class, interface
*/

//-----Variables-----
string minombre = "informaticonfig";
int edad = 20;
bool ACTIVO = false;
DateTime fecha = DateTime.Now;
float precio = 1.500f;
decimal descuento = 10.50m;
double descuento2 = 10.50;
//Console.WriteLine(minombre);
//Console.WriteLine(edad);
edad = 50;
//Console.WriteLine(edad);
//Console.WriteLine(fecha);
//Console.WriteLine(precio);
//Console.WriteLine(descuento);
//Console.WriteLine(descuento2);

Console.ReadKey();

//-----Uso de la concatenación-----
string nombre = "Ana";
int edad = 30;

//Console.WriteLine("Nombre de usuario: " + nombre +"\n" + "Edad: " + edad);

//Console.WriteLine($"Nombre usuario: {nombre}, edad: {edad}");
Console.ReadKey();

//-----CONSTANTES-----
var numero = 10.20;
//Console.WriteLine(numero);
numero = 3000;
//Console.WriteLine(numero);

const int numero2 = 150;
//Console.WriteLine("Valor de constante: " + numero2);

const double PI = 3.1416;
const string mensaje = "Bienvenidos!";
Console.ReadKey();

//----- Casting -----
//Implicito
int valor = 200;
double total = valor;
//Console.WriteLine("Implicito: " + total);

//Explicito 
double precio = 500.23;
int descuento = (int)precio;
//Console.WriteLine("Explicito: " + descuento);

char letra = 'A';
int codigoAsci = letra;
Console.WriteLine(codigoAsci);

string palabra = "123456";
int numero = Convert.ToInt32(palabra);
//Console.WriteLine(numero);
//Console.ReadKey();

//-----Operadores Aritmeticos-----

int valor1 = 90, valor2 = 70;
var valor3 = 10;

//Suma
int total = valor1 + valor2;
//Console.WriteLine($"Total de la suma: {total}");
//Resta
int diferencia = valor1 - valor2;
//Console.WriteLine($"Total de la resta: {diferencia}");
//Multiplicacion 
var producto = valor3 * valor2;
//Console.WriteLine($"Total de la multiplicación: {producto}");
//Division
var resultado = valor1 / valor3;
//Console.WriteLine($"El resultado es: {resultado}");
//Residuo
var modulo = valor2 % valor3;
//Console.WriteLine($"El residuo es: {modulo}");
Console.ReadKey();

//-----Entrada de datos-----
//Console.WriteLine("Introduzca un nombre: ");
string nombre = Console.ReadLine();
//Console.WriteLine("Introduzca su edad: ");
int edad = int.Parse(Console.ReadLine());
//Console.WriteLine("Indique su salario: ");
double salario = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine($"Su Nombre es: {nombre} y su Edad es: {edad} y su salario es: {salario}");
Console.ReadKey();

//-----Operadores incremento y decremento-----

int numero1 = 5;
//Console.WriteLine("Valor original: " + numero1);
numero1++;
//Console.WriteLine("Valor incrementado: " + numero1);
++numero1;
//Console.WriteLine("Valor incrementado: " + numero1);

int valor = 7;
int valor2 = valor++;
//Console.WriteLine("Valor incrementado: " + valor2);

Console.ReadKey();

//-----Operadores de Comparación-----
int a = 10, b=20;
string resultado;

resultado = (a > b)? "Si" : "No";
//Console.WriteLine(resultado);

resultado = (a >= b)? "Si" : "No";
//Console.WriteLine(resultado);
Console.ReadKey();

//-----Operadores Logicos-----
int numero1 = 12, numero2 = 90, numero3 = 5;
bool resultado; 
//And
resultado = numero1 < numero2 && numero1 > numero3;
Console.WriteLine(resultado);
// OR
resultado = numero1 < numero2 || numero1 > numero3;
//Console.WriteLine(resultado);
//Not 
resultado = numero1 < numero2 || numero1 > numero3;
//Console.WriteLine(!resultado);