using System;
using Entities;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Cadastro de Funcionário:");
        Console.Write("Nome: ");
        string nomeFuncionario = Console.ReadLine();
        Console.Write("Matrícula: ");
        string matriculaFuncionario = Console.ReadLine();
        Console.Write("CNPJ da Prestadora de Serviço: ");
        string cnpjPrestadora = Console.ReadLine();

        Funcionario funcionario = new Funcionario(nomeFuncionario, matriculaFuncionario, cnpjPrestadora);

        Console.WriteLine("\nCadastro de Cidadão:");
        Console.Write("CPF: ");
        string cpfCidadao = Console.ReadLine();
        Console.Write("Nome: ");
        string nomeCidadao = Console.ReadLine();
        Console.Write("Idade: ");
        int idadeCidadao = int.Parse(Console.ReadLine());
        Console.Write("Vacinado (true/false): ");
        bool vacinadoCidadao = bool.Parse(Console.ReadLine());

        Cidadao cidadao = new Cidadao(cpfCidadao, nomeCidadao, idadeCidadao, vacinadoCidadao);

        funcionario.CadastrarCidadao(cidadao);

        Console.WriteLine("\nLogin de Cidadão:");
        Console.Write("CPF: ");
        string cpfLogin = Console.ReadLine();

        bool loginSucesso = funcionario.LoginCidadao(cpfLogin);
        if (loginSucesso) {
            Console.WriteLine("Login bem-sucedido! Cidadão cadastrado.");
        } else {
            Console.WriteLine("Cidadão não cadastrado.");
        }
    }
}
