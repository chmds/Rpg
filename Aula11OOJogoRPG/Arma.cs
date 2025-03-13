using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11OOJogoRPG
{
    public class Arma
    {
        public string NomeArma { get; set; }
        public int DanoMin { get; set; }
        public int DanoMax { get; set; }

        public Arma(string nomeArma, int danoMin, int danoMax)
        {
            NomeArma = nomeArma;
            DanoMin = danoMin;
            DanoMax = danoMax;
        }
    }
}
