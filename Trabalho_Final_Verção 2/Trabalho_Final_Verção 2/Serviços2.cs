using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final_Verção_2
{
    internal class Serviços2 : Serviços
    {
        string morada;
        int tele;

        public string Morada
        {
            get { return morada; }
            set { morada = value; }
        }

        public int Tele
        {
            get { return tele; }
            set { tele = value; }
        }

        public override string Meng(string n, string g)
        {
            return MengInicio(n) + "\n\nNome: " + n + "\nGmail: " + g + "\nMorada: " + Morada + "\nTelemóvel: " + Tele + obg;
        }

        public Serviços2()
        { }

        ~Serviços2()
        { }
    }
}
