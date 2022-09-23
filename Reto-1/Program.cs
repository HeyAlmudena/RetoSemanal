// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
 * Escribe una función que reciba dos palabras (String) y retorne verdadero o falso (Bool) según sean o no anagramas.
 * - Un Anagrama consiste en formar una palabra reordenando TODAS las letras de otra palabra inicial.
 * - NO hace falta comprobar que ambas palabras existan.
 * - Dos palabras exactamente iguales no son anagrama.
 */

string myFirstWord;
string mySecondWord;

Console.WriteLine("Escribe la primera palabra: ");
myFirstWord = Console.ReadLine();

Console.WriteLine("Escribe la segunda palabra: ");
mySecondWord = Console.ReadLine();

Anagrama(myFirstWord, mySecondWord);

static bool Anagrama(string firstWord, string secondWord)
{
    int counter = 0;

    foreach (char word in firstWord)
    {
        if (secondWord.Contains(word))
        {
            counter++;
        }

        else
        {
            Console.WriteLine("Esto no es un anagrama.");
            return false;
        }
    }

    if (counter == firstWord.Length)
    {
        Console.WriteLine("Esto sí es un anagrama.");
    }

    return true;
}

