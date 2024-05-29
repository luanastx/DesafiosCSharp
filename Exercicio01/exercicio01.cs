using System;

public class Piramide
{
    public int N { get; set; }

    public Piramide(int n)
    {
        if (n < 1)
        {
            throw new ArgumentException("O valor de N deve ser maior ou igual a 1.");
        }
        N = n;
    }

    public void Desenha()
    {
        for (int i = 1; i <= N; i++)
        {

            for (int j = i; j < N; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }

            for (int j = i - 1; j >= 1; j--)
            {
                Console.Write(j);
            }

            Console.WriteLine();
        }
    }
}

class Programa
{
    static void Main(string[] args)
    {

        Console.WriteLine("\nExercicio 01\n");

        try
        {
            int n = 4;
            Piramide piramide = new Piramide(n);
            piramide.Desenha();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro na execução da pirâmide: " + ex.Message);
        }
    }
}



