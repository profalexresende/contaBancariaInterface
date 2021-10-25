using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contaBancaria_heranca
{
    class ContaCorrente:Conta
    {
        public double limiteEspecial { get; set; }

        public ContaCorrente()
        {
            this.limiteEspecial = 0;
            this.saldo = 0;
        }

        public ContaCorrente(double saldo,double limiteEspecial)
        {
            this.limiteEspecial = limiteEspecial;
            this.saldo = saldo;
        }

        public override void debitar(double valor)
        {
            if (valor <= this.saldo + this.limiteEspecial)
            {
                saldo -= valor;
                MessageBox.Show("Saque efetuado");
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente");
            }
        }

    }
}
