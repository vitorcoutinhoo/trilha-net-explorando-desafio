using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_net_explorando_desafio.Models {
    public class Pessoa(string nome, string sobrenome, string contato)
    {
        private string _nome = nome;
        private string _sobrenome = sobrenome;
        private string _contato = contato; // Telefone

        public string NomeCompleto { 
            get {
                return $"{_nome} {_sobrenome}";
            }
        }
        
        // Básico, mas o certo seria ter um método para atualizar cada campo
        public void AtualizarPessoa(string nome, string sobrenome, string contato) {
            _nome = nome;
            _sobrenome = sobrenome;
            _contato = contato;
        }

        public override string ToString() {
            return $"Nome: {NomeCompleto}, Contato: {long.Parse(_contato):(##) #####-####}";
        }
    }
}