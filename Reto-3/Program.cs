/*
 * Escribe un programa que se encargue de comprobar si un número es o no primo.
 * Hecho esto, imprime los números primos entre 1 y 100.
 */

Console.WriteLine("Introduce un número: ");
int numero = int.Parse(Console.ReadLine());

int[] numerosPrimos = new int[99];

ComprobacionNumero(numero);
NumerosPrimos();

// Comprobación del número primo
void ComprobacionNumero(int numero)
{
    bool isPrimo;

    if (numero == 2 || numero == 3 || numero == 5 || numero == 7)
    {
        isPrimo = true;
    }

    else if (numero % 2 == 0 || numero % 3 == 0 || numero % 5 == 0 || numero % 7 == 0)
    {
        isPrimo = false;
    }

    else
    {
        isPrimo = true;
    }

    if (isPrimo)
    {
        numerosPrimos.Append(numero);
        Console.WriteLine(numero + ", ");
    }
}

// Números primos entre 1 y 100
void NumerosPrimos()
{
    for (int i = 1; i< numerosPrimos.Length; i++)
    {
        
    }
}