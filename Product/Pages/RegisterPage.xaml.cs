namespace Product.Pages;

public partial class RegisterPage : ContentPage
{
	public RegisterPage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        string FullName, LastName, ContactNumber, Email, Password;

        FullName = ((Entry)this.FindByName("FullNameEntry")).Text;

        LastName = ((Entry)this.FindByName("LastNameEntry")).Text;

        ContactNumber = ((Entry)this.FindByName("ContactNumberEntry")).Text;

        Email = ((Entry)this.FindByName("EmailEntry")).Text;
        Password = ((Entry)this.FindByName("PasswordEntry")).Text;

        if (FullName == "Team" || LastName == "team" || ContactNumber == "1234567890" || Email == "123@gmail.com" || Password == "321")
        {

            DisplayAlert("Sucess", "Registration Sucessfull", "Done");
        }
        else 
        {
            DisplayAlert("Failed", "Fill the Details", "Retry");
        }
    }
}