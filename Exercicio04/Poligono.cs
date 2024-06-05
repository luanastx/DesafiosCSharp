using System;

public class Poligono
{
    private List<Vertice> vertices;

    public Poligono(params Vertice[] verticesIniciais)
    {
        if (verticesIniciais.Length < 3)
        {
            throw new ArgumentException("Um polígono precisa de pelo menos 3 vértices.");
        }

        this.vertices = new List<Vertice>(verticesIniciais);
    }

    public bool AddVertice(Vertice Nova)
    {

        if (vertices.Contains(Nova))
        {
            return false;
        }


        vertices.Add(Nova);
        return true;
    }

    public bool RemoveVertice(Vertice verticeRemovendo)
    {

        if (!vertices.Contains(verticeRemovendo))
        {
            return false;
        }

        vertices.Remove(verticeRemovendo);


        if (vertices.Count < 3)
        {
            throw new InvalidOperationException("Um polígono precisa de pelo menos 3 vértices.");
        }

        return true;
    }

    public double RetornaPerimetro()
    {
        double perimetro = 0;


        for (int i = 0; i < vertices.Count - 1; i++)
        {
            perimetro += vertices[i].Distancia(vertices[i + 1]);
        }


        perimetro += vertices[vertices.Count - 1].Distancia(vertices[0]);

        return perimetro;
    }

    public int QuantidadeVertices
    {
        get { return vertices.Count; }
    }
}
