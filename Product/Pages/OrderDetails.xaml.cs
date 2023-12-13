using System.ComponentModel.DataAnnotations;

namespace Product.Pages;

public partial class OrderDetails : ContentPage
{
    public OrderDetails()
    {
        InitializeComponent();
    }

   

    private async void MenuFlyoutItem_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
    }

    

    private void Button_Clicked(object sender, EventArgs e)
    {
        var rm = (Product.Models.Model)DataForm.DataObject;

        if (rm.FirstName != null &&
           rm.LastName != null &&
           rm.ContactNumber != null &&
        rm.Email != null &&
          rm.Password != null &&
           rm.ConformPassword != null &&
           rm.Password == rm.ConformPassword &&
          rm.Address != null &&
            rm.Country != null &&
            rm.City != null)
        {

            Navigation.PushAsync(new PaymentSelectionPage());
        }
        else
        {
            DisplayAlert("Error", "Complete all the Required Deatails", "OK");
        }
    }
}
