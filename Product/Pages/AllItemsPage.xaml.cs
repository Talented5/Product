namespace Product.Pages;

public partial class AllItemsPage : ContentPage
{
	private readonly AllItemViewModel _allPizzaViewModel;
	public AllItemsPage(AllItemViewModel allPizzaViewModel)
	{
		_allPizzaViewModel = allPizzaViewModel;
		InitializeComponent();
		BindingContext = _allPizzaViewModel;
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
		if (_allPizzaViewModel.FromSearch)
		{ 
			await Task.Delay(100);
			searchBar.Focus();
		}
    }

    private void searchBar_TextChanged(object sender, TextChangedEventArgs e)
    {
		if(!string.IsNullOrWhiteSpace(e.OldTextValue)
			&& string.IsNullOrWhiteSpace(e.NewTextValue))
		{
			_allPizzaViewModel.SearchPizzasCommand.Execute(null);
		}
			
		

    }
}