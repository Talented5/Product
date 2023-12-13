namespace Product.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

  

    private async void submit_Clicked(object sender, EventArgs e)
    {
        string username, password;

        username = ((Entry)this.FindByName("UsernameEntry")).Text;

        password = ((Entry)this.FindByName("PasswordEntry")).Text;
        if (username == "Team" && password == "1111")
        {
            await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
        }
        else
        {
             await DisplayAlert("Error", "Invalid Username or Password", "ok");
        }

    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new RegisterPage());
    }
}
