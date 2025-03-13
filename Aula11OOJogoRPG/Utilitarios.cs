using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11OOJogoRPG
{
    //Não precisa instanciar objeto entao deixa static
    public static class Utilitarios
    {
        public static int SortearNumero(int min, int max)
        {
            //retornar um número randomico
            return Random.Shared.Next(min, max + 1);
        }
    }
}
