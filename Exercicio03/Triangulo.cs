using System;

public enum TipoDoTriangulo
{
    Equilatero,
    Isosceles,
    Escaleno
}
class Triangulo
{

    public Vertice V1 { get; private set; }
    public Vertice V2 { get; private set; }
    public Vertice V3 { get; private set; }

    public Triangulo(Vertice v1, Vertice v2, Vertice v3)
    {

        if (!TrianguloValido(v1, v2, v3))
        {
            throw new Exception("Os vértices não formam um triângulo válido.");
        }

        V1 = v1;
        V2 = v2;
        V3 = v3;
    }

    public bool Igual(Triangulo outroTriangulo)
    {
        return (V1.Igual(outroTriangulo.V1) && V2.Igual(outroTriangulo.V2) && V3.Igual(outroTriangulo.V3))
               || (V1.Igual(outroTriangulo.V2) && V2.Igual(outroTriangulo.V3) && V3.Igual(outroTriangulo.V1))
               || (V1.Igual(outroTriangulo.V3) && V2.Igual(outroTriangulo.V1) && V3.Igual(outroTriangulo.V2));
    }

    public double Perimetro
    {
        get
        {
            return V1.Distancia(V2) + V2.Distancia(V3) + V3.Distancia(V1);
        }
    }

    public TipoDoTriangulo Tipo
    {
        get
        {
            if (TrianguloEquilatero())
            {
                return TipoDoTriangulo.Equilatero;
            }
            else if (TrianguloIsosceles())
            {
                return TipoDoTriangulo.Isosceles;
            }
            else
            {
                return TipoDoTriangulo.Escaleno;
            }
        }
    }

    public double Area
    {
        get
        {
            double semiPerimetro = Perimetro / 2;
            double ladoA = V1.Distancia(V2);
            double ladoB = V2.Distancia(V3);
            double ladoC = V3.Distancia(V1);

            double area = Math.Sqrt(semiPerimetro * (semiPerimetro - ladoA) * (semiPerimetro - ladoB) * (semiPerimetro - ladoC));
            return area;
        }
    }

    private bool TrianguloValido(Vertice v1, Vertice v2, Vertice v3)
    {
        double ladoA = v1.Distancia(v2);
        double ladoB = v2.Distancia(v3);
        double ladoC = v3.Distancia(v1);

        return ladoA + ladoB > ladoC && ladoB + ladoC > ladoA && ladoA + ladoC > ladoB;
    }

    private bool TrianguloEquilatero()
    {
        double ladoA = V1.Distancia(V2);
        double ladoB = V2.Distancia(V3);
        double ladoC = V3.Distancia(V1);

        return ladoA == ladoB && ladoB == ladoC;
    }

    private bool TrianguloIsosceles()
    {
        double ladoA = V1.Distancia(V2);
        double ladoB = V2.Distancia(V3);
        double ladoC = V3.Distancia(V1);

        return ladoA == ladoB || ladoB == ladoC || ladoA == ladoC;
    }
}

