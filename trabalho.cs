using System;
using System.Collections.Generic;

public class Funcionario {
    public string Nome { get; set; }
    public string Matricula { get; set; }
    public string CnpjPrestadora { get; set; }

    private List<Cidadao> cidadaosCadastrados;

    public Funcionario(string nome, string matricula, string cnpjPrestadora) {
        Nome = nome;
        Matricula = matricula;
        CnpjPrestadora = cnpjPrestadora;
        cidadaosCadastrados = new List<Cidadao>();
    }

    public void CadastrarCidadao(Cidadao cidadao) {
        // Verifica se o cidadão já está cadastrado
        if (cidadaosCadastrados.Exists(c => c.CPF == cidadao.CPF)) {
            Console.WriteLine("Cidadão já cadastrado!");
            return;
        }
        cidadaosCadastrados.Add(cidadao);
    }

    public bool LoginCidadao(string cpf) {
        // Verifica se o cidadão está cadastrado
        return cidadaosCadastrados.Exists(c => c.CPF == cpf);
    }
}

public class Cidadao {
    public string CPF { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
    public bool Vacinado { get; set; }

    public Cidadao(string cpf, string nome, int idade, bool vacinado) {
        CPF = cpf;
        Nome = nome;
        Idade = idade;
        Vacinado = vacinado;
    }
}

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