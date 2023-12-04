namespace Product.Pages;

public partial class HomePage : ContentPage
{
	private readonly HomeViewModel _homeViewModel;
	public HomePage(HomeViewModel homeViewModel)
	{
		InitializeComponent();
		_homeViewModel = homeViewModel;
		BindingContext = _homeViewModel;
	}

    private void BackButton_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}