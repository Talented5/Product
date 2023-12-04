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
        Navigation.PushAsync(new CheckoutPage());
    }
}