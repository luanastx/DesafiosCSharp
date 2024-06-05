using System;

public class Piramide
{
    public int Tamanho { get; set; }

    public Piramide(int n)
    {
        if (n < 1)
        {
            throw new ArgumentException("O valor de N deve ser maior ou igual a 1.");
        }
        Tamanho = n;
    }

    public void MontarPiramide()
    {
        for (int i = 1; i <= Tamanho; i++)
        {

            for (int j = i; j < Tamanho; j++)
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



