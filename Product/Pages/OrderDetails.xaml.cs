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

    private void sfButton_StateChanged(object sender, Syncfusion.Maui.Buttons.StateChangedEventArgs e)
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

            Navigation.PushAsync(new PaymentPage());
        }
        else
        {
            DisplayAlert("Error", "Complete all the Required Deatails", "OK");
        }
    }

    private void sfButton1_StateChanged(object sender, Syncfusion.Maui.Buttons.StateChangedEventArgs e)
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

            Navigation.PushAsync(new CheckoutPage());
        }
        else
        {
            DisplayAlert("Error", "Complete all the Required Deatails", "OK");
        }
    }

   
}
