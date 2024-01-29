using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_Final_Verção_2
{
    abstract internal class Serviços
    {
        public Serviços()
        {
            nome = "";
            gmail = "";
            obg = "\n\nObrigado por nos escolher!!";
        }

        string nome, gmail;
        public string obg;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Gmail
        {
            get { return gmail; }
            set { gmail = value; }
        }

        protected string MengInicio(string n)
        {
            return "Em breve iremos contactar consigo Sr./Sr.ᵃ " + n + "\n\n\nOs seus dados: ";
        }

        public abstract string Meng(string n, string g);

        ~Serviços() 
        { }    
    }
}
