using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contaBancaria_heranca
{
    interface IConta
    {
        

        void Debitar(double valor);



        void atualizarSaldos();

    }
}
