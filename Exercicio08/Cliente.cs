using System;

class Cliente
{
    public string nome;
    public long cpf;
    public DateTime dataNascimento;
    public float rendaMensal;
    public char estadoCivil;
    public int quantDependentes;

    public Cliente(string nome, long cpf, DateTime dataNascimento, float rendaMensal, char estadoCivil, int qtdDependentes)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.dataNascimento = dataNascimento;
        this.rendaMensal = rendaMensal;
        this.estadoCivil = estadoCivil;
        this.quantDependentes = qtdDependentes;
    }

    public static string ValidandoNome(string nome)
    {
        while (nome.Length < 5)
        {
            Console.WriteLine("Favor, inserir nome de pelo menos 5 caracteres: ");
            nome = Console.ReadLine();
        }
        return nome;
    }

    public static long ValidandoCPF(string cpf)
    {
        while (cpf.Length != 11)
        {
            Console.WriteLine("Favor, inserir CPF de 11 dígitos: ");
            cpf = Console.ReadLine();
        }
        return long.Parse(cpf);
    }

    public static DateTime ValidandoNascimento(string data)
    {
        DateTime date;
        while (!DateTime.TryParse(data, out date) || (DateTime.Now - date).TotalDays < 365 * 18)
        {
            Console.WriteLine("A data deve dar pelo menos 18 anos: ");
            data = Console.ReadLine();
        }
        return date;
    }

    public static float ValidandoRendaMensal(string renda)
    {
        float valorRenda;

        while (!float.TryParse(renda, out valorRenda) || !renda.Contains(',') || !DuasCasasDecimais(renda) || valorRenda >= 0)
        {
            Console.WriteLine("O valor deve ter vírgula na casa decimal e ser maior ou igual a zero (duas casas decimais): ");
            renda = Console.ReadLine();
        }

        return valorRenda;
    }

    private static bool DuasCasasDecimais(string renda)
    {
        string[] partes = renda.Split(',');
        if (partes.Length != 2)
            return false;

        return partes[1].Length == 2;
    }


    public static char ValidandoEstadoCivil(string estadoCivil)
    {
        while (estadoCivil.ToUpper() != "C" && estadoCivil.ToUpper() != "S" && estadoCivil.ToUpper() != "V" && estadoCivil.ToUpper() != "D")
        {
            Console.WriteLine("Favor inserir um estado civil válido (C c / S s / V v / D d): ");
            estadoCivil = Console.ReadLine();
        }
        return char.ToUpper(estadoCivil[0]);
    }

    public static int ValidandoQuantDependentes(string quantidade)
    {
        int dependentes;
        while (!int.TryParse(quantidade, out dependentes) || dependentes < 0 || dependentes > 10)
        {
            Console.WriteLine("Quantidade válida de dependentes entre 0 e 10: ");
            quantidade = Console.ReadLine();
        }
        return dependentes;
    }

    public void ImprimirCliente()
    {
        Console.WriteLine();
        Console.WriteLine("==========Imprimindo cliente===========");
        Console.WriteLine("Nome: " + this.nome);
        Console.WriteLine("CPF: " + this.cpf);
        Console.WriteLine("Nascimento: " + this.dataNascimento.ToString("dd/MM/yyyy"));
        Console.WriteLine("Renda mensal: " + this.rendaMensal);
        Console.WriteLine("Estado civil: " + this.estadoCivil);
        Console.WriteLine("Quantidade de dependentes: " + this.quantDependentes);
    }
}
