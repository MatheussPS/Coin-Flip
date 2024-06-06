using Coin_Flip.ViewModels;
namespace Coin_Flip.View
  
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CoinView : ContentPage
    {
        public CoinView()
        {
            InitializeComponent();
            BindingContext = new CoinViewModel();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}