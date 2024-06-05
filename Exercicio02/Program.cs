using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nExercicio 02\n");

        Vertice v1 = new Vertice(1.0, 2.0);
        Vertice v2 = new Vertice(4.0, 6.0);

        double distancia = v1.Distancia(v2);
        Console.WriteLine($"A distância entre v1 e v2 é: {distancia}");

        bool iguais = v1.Igual(v2);
        Console.WriteLine($"v1 e v2 são iguais? {iguais}");

        v1.Move(4.0, 6.0);
        iguais = v1.Igual(v2);
        Console.WriteLine($"v1 e v2 são iguais após mover v1? {iguais}");
    }
}
