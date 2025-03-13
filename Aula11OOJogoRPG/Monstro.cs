using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11OOJogoRPG
{
    public class Monstro : Criatura
    {
        public string NomeMonstro { get; set; }
        public int DanoMax { get; set; }
        public Monstro(string nomeMonstro, int danoMax, int vidaAtual, int vidaMax) : base(vidaAtual, vidaAtual)
        {
            NomeMonstro = nomeMonstro;
            DanoMax = danoMax;
        }
    }
}
