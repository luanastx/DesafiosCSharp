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

    public double Distancia(Vertice ab)
    {
        double dx = X - ab.X;
        double dy = Y - ab.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public void Move(double x, double y)
    {
        X = x;
        Y = y;
    }

    public bool Igual(Vertice ab)
    {
        return X == ab.X && Y == ab.Y;
    }
}



