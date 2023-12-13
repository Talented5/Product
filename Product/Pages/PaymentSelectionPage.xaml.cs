namespace Product.Pages;

public partial class PaymentSelectionPage : ContentPage
{
	public PaymentSelectionPage()
	{
		InitializeComponent();
	}

    private void sfButton_StateChanged(object sender, Syncfusion.Maui.Buttons.StateChangedEventArgs e)
    {
       
           Navigation.PushAsync(new PaymentPage());
        
    }

    private void sfButton3_StateChanged(object sender, Syncfusion.Maui.Buttons.StateChangedEventArgs e)
    {
      
            Navigation.PushAsync(new CheckoutPage());
        
    }

    private void MenuFlyoutItem_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new OrderDetails());

    }
}