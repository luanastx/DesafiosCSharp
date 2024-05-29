using System;

class Intervalo
{
    private DateTime dataHoraInicio;
    private DateTime dataHoraFim;

    public Intervalo(DateTime dataHoraInicio, DateTime dataHoraFim)
    {
        if (dataHoraInicio > dataHoraFim)
        {
            throw new ArgumentException("Data/hora inicial deve ser anterior à data/hora final.");
        }

        this.dataHoraInicio = dataHoraInicio;
        this.dataHoraFim = dataHoraFim;
    }

    public DateTime DataHoraInicio
    {
        get { return dataHoraInicio; }
    }

    public DateTime DataHoraFim
    {
        get { return dataHoraFim; }
    }

    public bool TemIntersecao(Intervalo outroIntervalo)
    {

        if (this.DataHoraFim >= outroIntervalo.DataHoraInicio)
        {

            if (this.DataHoraInicio <= outroIntervalo.DataHoraFim)
            {
                return true;
            }
        }

        return false;
    }

    public bool SaoIguais(Intervalo outroIntervalo)
    {
        return (this.DataHoraInicio == outroIntervalo.DataHoraInicio) && (this.DataHoraFim == outroIntervalo.DataHoraFim);
    }

    public TimeSpan Duracao
    {
        get { return dataHoraFim - dataHoraInicio; }
    }
}

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nExercicio 05\n");


        Intervalo intervalo1 = new Intervalo(new DateTime(2024, 05, 28, 10, 0, 0), new DateTime(2024, 05, 28, 12, 0, 0));
        Intervalo intervalo2 = new Intervalo(new DateTime(2024, 05, 28, 11, 30, 0), new DateTime(2024, 05, 28, 13, 0, 0));


        Console.WriteLine("Intervalo 1:");
        Console.WriteLine("Data/Hora Início: " + intervalo1.DataHoraInicio);
        Console.WriteLine("Data/Hora Fim: " + intervalo1.DataHoraFim);
        Console.WriteLine("Duração: " + intervalo1.Duracao.ToString());

        Console.WriteLine("\nIntervalo 2:");
        Console.WriteLine("Data/Hora Início: " + intervalo2.DataHoraInicio);
        Console.WriteLine("Data/Hora Fim: " + intervalo2.DataHoraFim);
        Console.WriteLine("Duração: " + intervalo2.Duracao.ToString());


        if (intervalo1.TemIntersecao(intervalo2))
        {
            Console.WriteLine("\nOs intervalos se interseccionam!");
        }
        else
        {
            Console.WriteLine("\nOs intervalos não se interseccionam.");
        }


        if (intervalo1.SaoIguais(intervalo2))
        {
            Console.WriteLine("\nOs intervalos são iguais!");
        }
        else
        {
            Console.WriteLine("\nOs intervalos não são iguais.");
        }
    }
}


