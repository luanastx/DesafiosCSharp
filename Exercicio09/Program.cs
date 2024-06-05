using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nExercicio 09\n");

        Motor motor01 = new Motor(1.6);
        Carro audi = new Carro("1234", "conversivel", motor01);
        Console.WriteLine("Velocidade do Audi é: " + audi.CalculandoVelocidade() + "km/h");
    }
}
