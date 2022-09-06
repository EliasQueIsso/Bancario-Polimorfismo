using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBacnario
{
    class ContaPoupanca : Conta
    {
        private double reajusteMensal;

        public double getReajusteMensal()
        {
            return reajusteMensal;
        }

        public void setReajusteMensal(double reajustemensal)
        {
            this.reajusteMensal = reajustemensal;
        }
        public ContaPoupanca()
        {
            reajusteMensal = 0;
            setSaldo(0);
        }
        public ContaPoupanca(double reajusteMensal, double saldo)
        {
            this.reajusteMensal = reajusteMensal;
            setSaldo(saldo);
        }

        public override void atualizarSaldo()
        {
            Console.WriteLine("O seu saldo é: " + getSaldo());
        }
        public void atualizarSaldos(double reajuste)
        {
            setReajusteMensal((getReajusteMensal() * getSaldo()) + getSaldo());
        }
    }
}
