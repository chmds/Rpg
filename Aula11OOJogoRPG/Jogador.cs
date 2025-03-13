using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11OOJogoRPG
{
    public class Jogador : Criatura
    {
        public Monstro MonstroAtual { get; set; }
        public Arma ArmaAtual { get; set; }
        public Jogador(int vidaAtual, int vidaMax) : base(vidaAtual, vidaMax)
        {

        }

        public int AtacarMonstro()
        {
            int dano = Utilitarios.SortearNumero(ArmaAtual.DanoMin, ArmaAtual.DanoMax);

            MonstroAtual.VidaAtual -= dano;

            return dano;
        }

        public int SerAtacado()
        {
            int dano = Utilitarios.SortearNumero(1, MonstroAtual.DanoMax);

            VidaAtual -= dano;

            return dano;
        }
    }
}
