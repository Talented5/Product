using System.ComponentModel.DataAnnotations;

namespace Product.Pages;

public partial class OrderDetails : ContentPage
{
    public OrderDetails()
    {
        InitializeComponent();
    }

    private void sfButton_Clicked(object sender, EventArgs e)
    {
        //var rm = (Product.Models.Model)DataForm.DataObject;

        //if (rm.FirstName != null &&
        //    rm.LastName != null &&
        //    rm.ContactNumber != null &&
        //    rm.Email != null &&
        //    rm.Password != null &&
        //    rm.RePassword != null &&
        //    rm.Address != null &&
        //    rm.Country != null &&
        //    rm.City != null)
        {

            Navigation.PushAsync(new CheckoutPage());
        }
        //else
        //{
        //    DisplayAlert("Error", "Complete all the Required Deatails", "OK");
        //}
    }
}