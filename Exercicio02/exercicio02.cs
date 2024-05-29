using System;

public class Vertice
{
    public double X { get; private set; }
    public double Y { get; private set; }

    public Vertice(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double Distancia(Vertice outro)
    {
        double dx = X - outro.X;
        double dy = Y - outro.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public void Move(double x, double y)
    {
        X = x;
        Y = y;
    }

    public bool Igual(Vertice outro)
    {
        return X == outro.X && Y == outro.Y;
    }
}


class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nExercicio 02\n");

        Vertice v1 = new Vertice(1.0, 2.0);
        Vertice v2 = new Vertice(4.0, 6.0);

        double distancia = v1.Distancia(v2);
        Console.WriteLine($"A distância entre v1 e v2 é: {distancia}");

        bool saoIguais = v1.Igual(v2);
        Console.WriteLine($"v1 e v2 são iguais? {saoIguais}");

        v1.Move(4.0, 6.0);
        saoIguais = v1.Igual(v2);
        Console.WriteLine($"v1 e v2 são iguais após mover v1? {saoIguais}");
    }
}


