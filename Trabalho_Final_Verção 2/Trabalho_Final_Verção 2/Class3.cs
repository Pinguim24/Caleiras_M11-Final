using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final_Verção_2
{
    internal class Class3
    {
        public double total;

        public double valor, valor2, valor3, valor4;

        public int quant, quant2, quant3, quant4;

        public int cont, cont2, cont3, cont4;
       


        public double Quantidade()
        {
            return valor = quant * 12;
        }

        public double Quantidade2()
        {
            return valor2 = Math.Round(quant2 * 2.5, 2);
        }

        public double Quantidade3()
        {
            return valor3 = quant3 * 3;
        }

        public double Quantidade4()
        {
            return valor4 = quant4 * 9;
        }

        public double Total() 
        { 
            return Math.Round(Quantidade() + Quantidade2() + Quantidade3() + Quantidade4(), 2);
        }
        public Class3()
        { }

        ~Class3()
        { }
    }
}
