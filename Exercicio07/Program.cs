
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nExercicio 07\n");

        Console.WriteLine("Números de Armstrong de 1 a 10000:");

        for (int numero = 1; numero <= 10000; numero++)
        {
            if (numero.IsArmstrong())
            {
                Console.WriteLine(numero);
            }
        }
    }
}
