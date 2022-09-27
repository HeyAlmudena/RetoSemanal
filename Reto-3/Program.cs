/*
 * Escribe un programa que se encargue de comprobar si un número es o no primo.
 * Hecho esto, imprime los números primos entre 1 y 100.
 */

int[] numerosPrimos = new int[] { };

for (int i = 1; i < 101; i++)
{
    if (NumeroPrimo(i))
    {
        numerosPrimos.Append(i);
        Console.WriteLine(i);
    }    
}

NumeroPrimo(8);

bool NumeroPrimo(int numero)
{  
    if (numero <= 1)
    {
        return false;
    }

    for (int i = 2; i < numero; i++)
    {
        if (numero%i == 0)
        {
            return false;
        }
    }

    return true;
}