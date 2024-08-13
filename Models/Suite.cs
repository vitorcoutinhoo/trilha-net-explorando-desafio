using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_net_explorando_desafio.Models {
    public class Suite (int numero, string tipo){

        private int _numero = numero;
        private string _tipo = tipo;
        private bool _ocupada = false;
        private List<Pessoa> hospedes = [];

        public int Numero { 
            get {
                return _numero;
            } 
        }

        public int Capacidade { 
            get {
                if (_tipo == "Premium") {
                    return 3;
                }

                return 2;
            } 

        }

        public List<Pessoa> Hospedes { 
            get {
                return hospedes;
            }
            set {
                hospedes = value;
            }
        }

        public decimal ValorDiaria { 
            get {
                if (_tipo == "Premium") {
                    return 450M;
                }

                return 200M;
            } 
        }

        public bool Ocupacao { 
            get {
                return _ocupada;
            }
            set {
                _ocupada = value;
            } 
        }

        public void AlterarTipo(string tipo) {
            _tipo = tipo;
        }

        public void AdicionarHospedes(List<Pessoa> novosHospedes) {
            Hospedes = novosHospedes;
        }

        public void RemoverHospedes() {
            Hospedes = [];
        }

        public override string ToString() {
            string ocupadaStatus = _ocupada ? "Ocupada" : "Disponível";
            return $"Suite: {_numero}\nTipo: {_tipo}\nOcupacao: {ocupadaStatus}";
        }

    }
}