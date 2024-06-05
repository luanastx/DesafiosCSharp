using System;
public class ListaIntervalo
{
    public List<Intervalo> intervalos = new List<Intervalo>();

    public bool AddIntervalo(Intervalo IntervaloAdicionado)
    {
        foreach (Intervalo intervalo in intervalos)
        {
            if (intervalo.TemIntersecao(IntervaloAdicionado))
            {
                return false;
            }
        }
        intervalos.Add(IntervaloAdicionado);
        return true;
    }

    public List<Intervalo> ImprimirIntervalo()
    {

        List<Intervalo> listaOrdenada = new List<Intervalo>(intervalos);
        listaOrdenada.Sort((x, y) => x.DataHoraInicial.CompareTo(y.DataHoraInicial));

        foreach (Intervalo intervalo in listaOrdenada)
        {
            Console.WriteLine(intervalo.DataHoraInicial);
        }

        return listaOrdenada;
    }
}