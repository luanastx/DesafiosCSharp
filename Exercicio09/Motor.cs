using System;


public class Motor
{
    private double cilindrada;
    private Carro carro;
    public double Cilindrada { get { return cilindrada; } }

    public Motor(double cilindrada)
    {
        if (cilindrada <= 0.0)
            throw new Exception("Cilindrada informada é inválida.");

        this.cilindrada = cilindrada;
    }

    public void AssociarCarro(Carro carro)
    {
        if (carro == null)
            throw new Exception("O carro tem que existir.");

        if (this.carro != null)
            throw new Exception("O motor já está em um carro");

        this.carro = carro;
    }
}
