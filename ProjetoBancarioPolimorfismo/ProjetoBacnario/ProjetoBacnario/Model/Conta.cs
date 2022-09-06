using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBacnario
{
    abstract class Conta
    {
        private double saldo;

        public double getSaldo()
        {
            return saldo;
        }
        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }
        public virtual void creditar(double valor)
        {
            valor += saldo;
        }
        public virtual void debitar(double valor)
        {
            if (valor < saldo)
            {
                valor -= saldo;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }
        }
        public abstract void atualizarSaldo();
    }
}
