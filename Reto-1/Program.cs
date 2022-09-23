/*
 * Escribe una función que reciba dos palabras (String) y retorne verdadero o falso (Bool) según sean o no anagramas.
 * - Un Anagrama consiste en formar una palabra reordenando TODAS las letras de otra palabra inicial.
 * - NO hace falta comprobar que ambas palabras existan.
 * - Dos palabras exactamente iguales no son anagrama.
 */

#region INTRODUCCIÓN DE VARIABLES
string palabraUno;
string palabraDos;

Console.WriteLine("Escribe la primera palabra: ");
palabraUno = Console.ReadLine().ToLower();

Console.WriteLine("Escribe la segunda palabra: ");
palabraDos = Console.ReadLine().ToLower();
#endregion

Anagrama(palabraUno, palabraDos);

static void Anagrama(string palabraUno, string palabraDos)
{
    char [] primeraPalabra = palabraUno.ToCharArray();
    char [] segundaPalabra = palabraDos.ToCharArray();

    Array.Sort(primeraPalabra);
    Array.Sort(segundaPalabra);

    string primeraPalabraString = new string (primeraPalabra);
    string segundaPalabraString = new string(segundaPalabra);

    if (palabraUno.Length != palabraDos.Length || palabraUno == palabraDos || primeraPalabraString != segundaPalabraString)
    {
        Console.WriteLine("NO ES UN ANAGRAMA.");
    }

    if (primeraPalabraString == segundaPalabraString)
    {
        Console.WriteLine("SÍ ES UN ANAGRAMA.");
    }
}

