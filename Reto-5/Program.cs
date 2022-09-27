/*
 * Crea un programa que invierta el orden de una cadena de texto
 * sin usar funciones propias del lenguaje que lo hagan de forma automática.
 * - Si le pasamos "Hola mundo" nos retornaría "odnum aloH"
 */

Console.WriteLine("Escribe una frase: ");
string cadena = Console.ReadLine();

char[] cadenaDescompuesta = cadena.ToCharArray();
char[] cadenaInversa = new char[cadenaDescompuesta.Length];

for (int i = 0; i < cadenaDescompuesta.Length; i++)
{
    cadenaInversa[i] = cadenaDescompuesta[cadenaDescompuesta.Length - i - 1];
    Console.Write(cadenaInversa[i]);
}
