namespace Product.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

  

    private void submit_Clicked(object sender, EventArgs e)
    {
        string username, password;

        username = ((Entry)this.FindByName("UsernameEntry")).Text;

        password = ((Entry)this.FindByName("PasswordEntry")).Text;
        if (username == "Team" || password == "1210")
        {
            Navigation.PushAsync(new MainPage());
        }
        else
        {
            DisplayAlert("Error", "Invalid Username or Password", "ok");
        }

    }
}
