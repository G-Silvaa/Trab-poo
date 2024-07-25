using System;
using System.Collections.Generic;

namespace Entities {
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
}
