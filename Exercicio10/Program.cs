using System;
using System.Collections.Generic;
using System.Linq;

Console.WriteLine("\nExercicio 10\n");

List<string> strlist = new() { "num 1", "num 2", "num 1", "num 3", "num 2" };

List<int> intlist = new() { 36, 10, 1, 2, 5, 36, 10, 2, 56 };

List<(string CPF, string Nome)> clientes = new()
        {
            ("12312312312", "João"),
            ("45623456789", "Maria"),
            ("12312312312", "João Silva")
        };

List<(string CPF, string Nome)> clienteUnico = clientes
    .DistinctBy(c => c.CPF)
    .ToList();


strlist = ExtensaoLista.RemovendoRepetido(strlist);
intlist = ExtensaoLista.RemovendoRepetido(intlist);

strlist.ForEach(e => Console.WriteLine($"{e} "));
intlist.ForEach(e => Console.WriteLine($"{e} "));
clienteUnico.ForEach(c => Console.WriteLine($"CPF: {c.CPF}, Nome: {c.Nome}"));
