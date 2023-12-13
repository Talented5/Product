namespace Product
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(CartPage), typeof(CartPage));
            Routing.RegisterRoute(nameof(CheckoutPage), typeof(CheckoutPage));
            Routing.RegisterRoute(nameof(OrderDetails), typeof(OrderDetails));
            Routing.RegisterRoute(nameof(PaymentSelectionPage), typeof(PaymentSelectionPage));
        }
    }
}
