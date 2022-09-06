using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBacnario
{
    class ContaCorrente : Conta
    {
        private double limiteEspecial;

        public double getLimiteEspecial()
        {
            return limiteEspecial;
        }
        public void setLimiteEspecial(double limiteEspecial)
        {
            this.limiteEspecial = limiteEspecial;
        }

        public ContaCorrente()
        {
            setSaldo(0);
            limiteEspecial = 0;
        }
        public ContaCorrente(double LimiteEspecial, double Saldo)
        {
            this.limiteEspecial = LimiteEspecial;
            setSaldo(Saldo);
        }

        public override void debitar(double valor)
        {
            if(valor <= getSaldo() + getLimiteEspecial())
            {
                setSaldo(getSaldo() - valor );
            }
        }

        public override void atualizarSaldo()
        {
            if (getSaldo() < 0)
            {
                setSaldo(getSaldo() * 1.08);
            }
        }
    }
}
