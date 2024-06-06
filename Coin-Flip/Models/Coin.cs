using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Coin_Flip.Enums;

namespace Coin_Flip.Models
{
    internal class Coin
    {
        Lados Lado {  get; set; }
        public int LadoEscolhido { get; set; }

        public Coin()
        {

        }

        public String Jogar()
        {
            Random random = new Random();

            return random.Next(2) == 0? Lados.Cara.ToString(): Lados.Coroa.ToString() ;
        }
    }
}
