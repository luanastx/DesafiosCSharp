using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nExercicio 03\n");

        Vertice v1 = new Vertice(0.0, 0.0);
        Vertice v2 = new Vertice(0.0, 3.0);
        Vertice v3 = new Vertice(4.0, 0.0);


        Triangulo triangulo = new Triangulo(v1, v2, v3);
        Console.WriteLine($"O perímetro do triângulo é: {triangulo.Perimetro}");
        Console.WriteLine($"A área do triângulo é: {triangulo.Area}");
        Console.WriteLine($"O tipo do triângulo é: {triangulo.Tipo}");
    }

}
