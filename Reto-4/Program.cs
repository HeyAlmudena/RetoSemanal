/*
*Crea una única función (importante que sólo sea una) que sea capaz
 * de calcular y retornar el área de un polígono.
 * - La función recibirá por parámetro sólo UN polígono a la vez.
 * - Los polígonos soportados serán Triángulo, Cuadrado y Rectángulo.
 * - Imprime el cálculo del área de un polígono de cada tipo.
 */

Console.WriteLine("Introduce un polígono: triángulo, cuadrado o rectángulo");
string poligono = Console.ReadLine().ToLower();

Console.WriteLine("Introduce altura: ");
int alturaPoligono = int.Parse(Console.ReadLine());
Console.WriteLine("Introduce base: ");
int basePoligono = int.Parse(Console.ReadLine());

int area = 0;

AreaPoligono(poligono);

void AreaPoligono(string poligono)
{  
    if (poligono == "triángulo")
    {
        area = (basePoligono * alturaPoligono) / 2;
        Console.WriteLine("El area del " + poligono + "es: " + area);
    }

    else if (poligono == "rectángulo" || poligono == "cuadrado")
    {
        area = (basePoligono * alturaPoligono);
        Console.WriteLine("El area del " + poligono + "es: " + area);
    }

    else
    {
        Console.WriteLine("El polígono es inválido");
    }
}