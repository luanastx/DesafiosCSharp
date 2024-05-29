using System;

public enum TipoTriangulo
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

        if (!VerificaTrianguloValido(v1, v2, v3))
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

    public TipoTriangulo Tipo
    {
        get
        {
            if (IsEquilatero())
            {
                return TipoTriangulo.Equilatero;
            }
            else if (IsIsosceles())
            {
                return TipoTriangulo.Isosceles;
            }
            else
            {
                return TipoTriangulo.Escaleno;
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

    private bool VerificaTrianguloValido(Vertice v1, Vertice v2, Vertice v3)
    {
        double ladoA = v1.Distancia(v2);
        double ladoB = v2.Distancia(v3);
        double ladoC = v3.Distancia(v1);

        return ladoA + ladoB > ladoC && ladoB + ladoC > ladoA && ladoA + ladoC > ladoB;
    }

    private bool IsEquilatero()
    {
        double ladoA = V1.Distancia(V2);
        double ladoB = V2.Distancia(V3);
        double ladoC = V3.Distancia(V1);

        return ladoA == ladoB && ladoB == ladoC;
    }

    private bool IsIsosceles()
    {
        double ladoA = V1.Distancia(V2);
        double ladoB = V2.Distancia(V3);
        double ladoC = V3.Distancia(V1);

        return ladoA == ladoB || ladoB == ladoC || ladoA == ladoC;
    }
}


class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nExercicio 03\n");

        Vertice v1 = new Vertice(0.0, 0.0);
        Vertice v2 = new Vertice(0.0, 3.0);
        Vertice v3 = new Vertice(4.0, 0.0);

        try
        {
            Triangulo triangulo = new Triangulo(v1, v2, v3);
            Console.WriteLine($"O perímetro do triângulo é: {triangulo.Perimetro}");
            Console.WriteLine($"A área do triângulo é: {triangulo.Area}");
            Console.WriteLine($"O tipo do triângulo é: {triangulo.Tipo}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro na execução do triângulo: " + ex.Message);
        }
    }
}
