using System;
public class Intervalo
{
    public DateTime DataHoraInicial { get; set; }
    public DateTime DataHoraFinal { get; set; }

    public Intervalo(DateTime dataHoraInicio, DateTime dataHoraFim)
    {
        if (dataHoraInicio > dataHoraFim)
        {
            throw new ArgumentException("Data/hora inicial deve ser anterior à data/hora final!");
        }

        this.DataHoraInicial = dataHoraInicio;
        this.DataHoraFinal = dataHoraFim;
    }

    public bool TemIntersecao(Intervalo ab)
    {
        return this.DataHoraFinal >= ab.DataHoraInicial && this.DataHoraInicial <= ab.DataHoraFinal;
    }

    public bool SaoIguais(Intervalo ab)
    {
        return this.DataHoraInicial == ab.DataHoraInicial && this.DataHoraFinal == ab.DataHoraFinal;
    }

    public TimeSpan Duracao
    {
        get { return DataHoraFinal - DataHoraInicial; }
    }
}
