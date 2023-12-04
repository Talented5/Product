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
        Shell.Current.GoToAsync($"//{nameof(CheckoutPage)}");
    }
}