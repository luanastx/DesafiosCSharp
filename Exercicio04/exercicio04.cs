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

    public bool AddVertice(Vertice novoVertice)
    {

        if (vertices.Contains(novoVertice))
        {
            return false;
        }


        vertices.Add(novoVertice);
        return true;
    }

    public bool RemoveVertice(Vertice verticeParaRemover)
    {

        if (!vertices.Contains(verticeParaRemover))
        {
            return false;
        }

        vertices.Remove(verticeParaRemover);


        if (vertices.Count < 3)
        {
            throw new InvalidOperationException("Um polígono precisa de pelo menos 3 vértices.");
        }

        return true;
    }

    public double CalcularPerimetro()
    {
        double perimetro = 0;


        for (int i = 0; i < vertices.Count - 1; i++)
        {
            perimetro += vertices[i].Distancia(vertices[i + 1]);
        }


        perimetro += vertices[vertices.Count - 1].Distancia(vertices[0]);

        return perimetro;
    }

    public int NumeroDeVertices
    {
        get { return vertices.Count; }
    }
}




class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nExercicio 04\n");


        Vertice v1 = new Vertice(1, 2);
        Vertice v2 = new Vertice(4, 3);
        Vertice v3 = new Vertice(3, 5);

        Poligono poligono = new Poligono(v1, v2, v3);


        Vertice novoVertice = new Vertice(5, 6);
        bool adicionado = poligono.AddVertice(novoVertice);

        if (adicionado)
        {
            Console.WriteLine("Vértice adicionado com sucesso!");
        }
        else
        {
            Console.WriteLine("O vértice já existe no polígono.");
        }

        bool removido = poligono.RemoveVertice(v2);

        if (removido)
        {
            Console.WriteLine("Vértice removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Vértice não encontrado no polígono.");
        }


        double perimetro = poligono.CalcularPerimetro();
        Console.WriteLine("Perímetro do polígono: " + perimetro);


        int numeroVertices = poligono.NumeroDeVertices;
        Console.WriteLine("Número de vértices do polígono: " + numeroVertices);

    }
}
