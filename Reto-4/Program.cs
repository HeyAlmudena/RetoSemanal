/*
*Crea una única función (importante que sólo sea una) que sea capaz
 * de calcular y retornar el área de un polígono.
 * - La función recibirá por parámetro sólo UN polígono a la vez.
 * - Los polígonos soportados serán Triángulo, Cuadrado y Rectángulo.
 * - Imprime el cálculo del área de un polígono de cada tipo.
 */

Triangle myTriangle = new Triangle();
Rectangle myRectangle = new Rectangle();
Square mySquare = new Square();

Console.WriteLine("El área del triángulo es: " + myTriangle.TriangleArea(baseTriangle: 20, heightTriangle: 20));
Console.WriteLine("El área del rectángulo es: " + myRectangle.RectangleArea(baseRectangle: 20, heightRectangle: 20));
Console.WriteLine("El área del cuadrado es: " + mySquare.SquareArea(baseSquare: 30, heightSquare: 30));

class Triangle {

    public double TriangleArea (double baseTriangle, double heightTriangle) {

        double areaTriangulo = (baseTriangle * heightTriangle) /2;
        return areaTriangulo;
    }
}

class Rectangle
{
    public double RectangleArea(double baseRectangle, double heightRectangle)
    {

        double areaRectangle = (baseRectangle * heightRectangle);
        return areaRectangle;
    }
}

class Square
{
    public double SquareArea(double baseSquare, double heightSquare)
    {
        double areaRectangle = (baseSquare * heightSquare);
        return areaRectangle;
    }
}