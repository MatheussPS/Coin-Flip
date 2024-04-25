namespace Coin_Flip
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void EscolhaBtn_Clicked(object sender, EventArgs e)
        {
            Random random = new Random();

            var picker = (Picker)define_MoedaPicker;
            string msg = "Por favor, selecione uma opção!";

            try
            {
                int indexPicker = picker.SelectedIndex;

                int sortedCoin = random.Next(0, 2);

                if (sortedCoin == indexPicker){
                    msg = "Parabéns, você acertou";
                }
                else
                {
                    msg = "Quase!   Você errou";
                }

                moedaImg.Source = $"{picker.ItemsSource[sortedCoin]}";

                DisplayAlert(msg, $"A resposta correta é {picker.ItemsSource[sortedCoin]}", "OK!");

                
            }

            catch {
                DisplayAlert("Erro", msg, "OK!");
            }

            

           
        }
    }

}
