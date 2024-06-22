namespace CoinFlip_MVVM.Views;

public partial class CoinView : ContentPage
{
	public CoinView()
	{
		InitializeComponent();
		BindingContext = new CoinFlip_MVVM.ViewModels.CoinViewModel();
	}
}