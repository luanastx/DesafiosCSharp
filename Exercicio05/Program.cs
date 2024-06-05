using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nExercicio 05\n");


        Intervalo intervalo01 = new Intervalo(new DateTime(2024, 05, 28, 10, 0, 0), new DateTime(2024, 05, 28, 12, 0, 0));
        Intervalo intervalo02 = new Intervalo(new DateTime(2024, 05, 28, 11, 30, 0), new DateTime(2024, 05, 28, 13, 0, 0));


        Console.WriteLine("Intervalo 1:");
        Console.WriteLine("Data/Hora Início: " + intervalo01.DataHoraInicial);
        Console.WriteLine("Data/Hora Fim: " + intervalo01.DataHoraFinal);
        Console.WriteLine("Duração: " + intervalo01.Duracao.ToString());

        Console.WriteLine("\nIntervalo 2:");
        Console.WriteLine("Data/Hora Início: " + intervalo02.DataHoraInicial);
        Console.WriteLine("Data/Hora Fim: " + intervalo02.DataHoraFinal);
        Console.WriteLine("Duração: " + intervalo02.Duracao.ToString());


        if (intervalo01.TemIntersecao(intervalo02))
        {
            Console.WriteLine("\nOs intervalos se interseccionam!");
        }
        else
        {
            Console.WriteLine("\nOs intervalos não se interseccionam.");
        }


        if (intervalo01.SaoIguais(intervalo02))
        {
            Console.WriteLine("\nOs intervalos são iguais!");
        }
        else
        {
            Console.WriteLine("\nOs intervalos não são iguais.");
        }
    }
}