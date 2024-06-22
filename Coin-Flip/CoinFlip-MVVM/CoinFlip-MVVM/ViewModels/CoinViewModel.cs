using CoinFlip_MVVM.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoinFlip_MVVM.ViewModels
{
    public partial class CoinViewModel : ObservableObject
    {
        [ObservableProperty]
        private String escolha_sistema;

        [ObservableProperty]
        private String resultado;

        [ObservableProperty]
        private String imagem;

        [ObservableProperty]
        private String escolha;

        public ICommand JogarCommand { get; }

        public CoinViewModel()
        {
            JogarCommand = new Command(Jogar);
            Escolha_sistema = "Cara";
            Resultado = "Joguem!";
            Imagem = "cara.jpg";
            Escolha = "Cara";
        }

        public void Jogar()
        {
            Coin coin = new Coin();

            String jogada = coin.Jogar();

            Resultado = Escolha == jogada ? "Você venceu" : "Você perdeu";

            Escolha_sistema = jogada;

            Imagem = $"{jogada}.jpg";

        }



    }

}
