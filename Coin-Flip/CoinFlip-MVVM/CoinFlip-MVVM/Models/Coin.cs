using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinFlip_MVVM.Enums;

namespace CoinFlip_MVVM.Models
{
    internal class Coin
    {

        public Coin()
        {

        }

        public String Jogar()
        {
            Random random = new Random();

            return random.Next(2) == 0 ? Lados.Cara.ToString() : Lados.Coroa.ToString();
        }
    }
}
