namespace Product.Pages;

public partial class PaymentPage : ContentPage
{
	public PaymentPage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        img.ScaleTo(1.5);
        msg.ScaleTo(1);

        await img.ScaleTo(0.5);
        await img.ScaleTo(1.5);
        await img.ScaleTo(0.5);
        await img.ScaleTo(1.5);
        await img.ScaleTo(0.5);
        await img.ScaleTo(1.5);
        await img.ScaleTo(1);

        //ImageButton.FadeTo(1, length: 400);
        //await ImageButton.ScaleTo(1);
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CheckoutPage());
    }
}