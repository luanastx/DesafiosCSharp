using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("\nExercicio 06\n");

        ListaIntervalo lista = new ListaIntervalo();

        lista.AddIntervalo(new Intervalo(DateTime.Now.AddHours(-1), DateTime.Now));
        lista.AddIntervalo(new Intervalo(DateTime.Now.AddHours(1), DateTime.Now.AddHours(2)));

        var intervalosOrdenados = lista.ImprimirIntervalo();

    }
}