using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace trilha_net_explorando_desafio.Models {
    public class Reserva {
        private Suite suite;
        private int dias;

        public Suite Suite {
            get {
                return suite;
            }
        }


        public int Dias {
            get {
                return dias;
            }
        }

        public void AdicionarSuite(Suite suite) {
            this.suite = suite;
        }

        public void DefinirDias(int dias) {
            this.dias = dias;
        }

        public void ReservarSuite(List<Pessoa> hospedes) {
            if (suite.Ocupacao) {
                throw new Exception("Suite já está ocupada");
            }

            if (suite.Capacidade < hospedes.Count) {
                throw new Exception("Quantidade de hóspedes excede a capacidade da suite");
            }

            suite.Ocupacao = true;
            suite.AdicionarHospedes(hospedes);
        }

        public void CancelarReserva() {
            suite.Ocupacao = false;
            suite.Hospedes.Clear();
        }

        public int TotalHospedes() {
            if (suite.Ocupacao) {
                return suite.Hospedes.Count;
            }
            return 0;
        }

        public decimal ValorTotalReserva() {
            if (dias >= 10) {
                return suite.ValorDiaria * dias * 0.9M;
            }

            return suite.ValorDiaria * dias;
        }

        public override string ToString() {
            if (suite.Ocupacao) {
                return $"Suite: {suite.Numero}\nHóspedes: ({TotalHospedes()})\n  {string.Join("\n  ", suite.Hospedes)}\nDias: {dias}\nValor total: {ValorTotalReserva():F2}";
            }
            return $"Suite Vazia";
        }

    }
}