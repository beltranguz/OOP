using OOP.Clase;
using OOP.Implementacion_de_Polimorfismo;

class Program
{
    static void Main(string[] args)
    {
        Figura Rectangulo = new Rectangulo(6, 8);
        Figura Circulo = new Circulo(6);
        Figura Triangulo = new Triangulo(4, 6);

        Console.WriteLine($"Area del Rectangulo: {Rectangulo.CalcularArea()}");
        Console.WriteLine($"Area del Circulo: {Circulo.CalcularArea()}");
        Console.WriteLine($"Area del Triangulo: {Triangulo.CalcularArea()}");
    }
}