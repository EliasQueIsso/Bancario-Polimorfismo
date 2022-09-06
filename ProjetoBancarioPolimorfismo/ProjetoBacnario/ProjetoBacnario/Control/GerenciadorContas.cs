using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBacnario
{
    class GerenciadorContas
    {
        private double saldoTotal;
        public double getSaldoTotal()
        {
            return saldoTotal;
        }
        public void setSaldoTotal(double saldoTotal)
        {
            this.saldoTotal = saldoTotal;
        }

        public GerenciadorContas()
        {
            saldoTotal = 0;
        }
        public GerenciadorContas(double saldoTotal)
        {
            this.saldoTotal = saldoTotal;
        }

        public void totalizarSaldos(Conta conta)
        {
            saldoTotal += conta.getSaldo();
        }
    }
}
