using System;

public class Carro
{
    private string placa;
    private string modelo;
    private Motor motor;

    public string Placa { get { return placa; } }
    public string Modelo { get { return modelo; } }
    public Motor Motor { get { return motor; } }

    public Carro(string placa, string modelo, Motor motor)
    {
        if (placa.Length < 1)
            throw new ArgumentException("A placa tem que ser valida.");

        if (modelo.Length < 1)
            throw new ArgumentException("O modelo tem que ser valida.");

        if (motor == null)
            throw new ArgumentException("O carro nunca deve ficar sem motor.");

        this.placa = placa;
        this.modelo = modelo;
        this.motor = motor;
    }

    public void SubstituindoMotor(Motor motor)
    {
        if (motor == null)
            throw new ArgumentException("O carro está sem motor.");

        this.motor = motor;
    }

    public int CalculandoVelocidade()
    {
        if (motor.Cilindrada <= 1.0)
        {
            return 140;
        }
        else if (motor.Cilindrada <= 1.6)
        {
            return 160;
        }
        else if (motor.Cilindrada <= 2.0)
        {
            return 180;
        }
        else
        {
            return 220;
        }
    }
}
