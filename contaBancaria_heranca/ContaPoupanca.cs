﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contaBancaria_heranca
{
    class ContaPoupanca: Conta, IConta
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

        public void atualizarSaldos(double reajuste)
        {
            double saldoAnterior = this.saldo;
            saldo += saldo * (reajuste / 100);

            MessageBox.Show("Saldo Anterior: " + saldoAnterior.ToString() +
                    "\nSaldo Atual: " + this.saldo);
        }

        public void atualizarSaldos()
        {
           
        }

        public void Debitar(double valor)
        {
            if (valor <= this.saldo )
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
