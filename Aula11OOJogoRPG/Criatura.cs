using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11OOJogoRPG
{
    //abstract significa que a classe nao pode ser instanciada como criatura, mas pode ser usada como classe
    public abstract class Criatura
    {
        public int VidaAtual { get; set; }
        public int VidaMax { get; set; }

        public Criatura(int  vidaAtual, int vidaMax)
        {
            VidaAtual = vidaAtual;
            VidaMax = vidaMax;
        }
    }
}
