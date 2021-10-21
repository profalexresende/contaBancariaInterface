using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contaBancaria_heranca
{
    class ContaPoupanca:Conta
    {
        public double reajusteMensal { get; set; }

        public ContaPoupanca()
        {
            this.reajusteMensal = 0;
            this.saldo = 0;
        }

        public ContaPoupanca(double saldo,double reajusteMensal)
        {
            this.saldo = saldo;
            this.reajusteMensal = reajusteMensal;
        }
    }
}
