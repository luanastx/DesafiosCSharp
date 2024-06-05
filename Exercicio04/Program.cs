using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nExercicio 04\n");


        Vertice v1 = new Vertice(1, 2);
        Vertice v2 = new Vertice(4, 3);
        Vertice v3 = new Vertice(3, 5);

        Poligono poligono = new Poligono(v1, v2, v3);

        Vertice VerticeNovo = new Vertice(5, 6);

        bool adicionado = poligono.AddVertice(VerticeNovo);

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


        double perimetro = poligono.RetornaPerimetro();
        Console.WriteLine("Perímetro do polígono: " + perimetro);


        int numeroVertices = poligono.QuantidadeVertices;
        Console.WriteLine("Número de vértices do polígono: " + numeroVertices);

    }
}
