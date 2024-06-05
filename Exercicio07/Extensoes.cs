using System;

public static class Extensoes
{
    public static bool IsArmstrong(this int numero)
    {
        if (numero <= 0)
        {
            return false;
        }

        string textoNum = numero.ToString();
        int numDigitos = textoNum.Length;
        int somaPotencias = 0;

        foreach (char digito in textoNum)
        {
            int digitoInt = int.Parse(digito.ToString());
            somaPotencias += (int)Math.Pow(digitoInt, numDigitos);
        }

        return numero == somaPotencias;
    }
}
