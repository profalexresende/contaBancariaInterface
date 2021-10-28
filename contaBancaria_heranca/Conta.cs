using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contaBancaria_heranca
{
    class Conta
    {
        public double saldo { get; set; }

        public Conta()
        {
            saldo = 0;
        }

        public void Creditar(double valor)
        {
            saldo += valor;
            MessageBox.Show("Depósito efetuado");
        }
    }
}
