using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nExercicio 08\n");

        Console.WriteLine("===== Cadastro de Cliente =====");

        Console.Write("Nome: ");
        string nome = Cliente.ValidandoNome(Console.ReadLine());

        Console.Write("CPF: ");
        long cpf = Cliente.ValidandoCPF(Console.ReadLine());

        Console.Write("Data de Nascimento (dd/mm/yyyy): ");
        DateTime dataNascimento = Cliente.ValidandoNascimento(Console.ReadLine());

        Console.Write("Renda Mensal: ");
        float rendaMensal = Cliente.ValidandoRendaMensal(Console.ReadLine());

        Console.Write("Estado Civil (C/S/V/D): ");
        char estadoCivil = Cliente.ValidandoEstadoCivil(Console.ReadLine());

        Console.Write("Quantidade de Dependentes: ");
        int qtdDependentes = Cliente.ValidandoQuantDependentes(Console.ReadLine());

        Cliente cliente = new Cliente(nome, cpf, dataNascimento, rendaMensal, estadoCivil, qtdDependentes);
        cliente.ImprimirCliente();
    }
}