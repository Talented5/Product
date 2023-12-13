
using Product.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.ViewModels
{
    [QueryProperty(nameof(FromSearch), nameof(FromSearch))]
    public partial class AllItemViewModel : ObservableObject
    {
        private readonly ItemService _itemService;
            public AllItemViewModel(ItemService itemService)
        { 
            _itemService = itemService;
            Items = new(_itemService.GetallPizzas());
        }
        public ObservableCollection<Item> Items { get; set; }

        [ObservableProperty]
        private bool _fromSearch;

        [ObservableProperty] 
        private bool _searching;


        [RelayCommand]
        private async Task SearchPizzas(string searchTerm)
        {
            Items.Clear();
            Searching = true;
            await Task.Delay(1000);
            foreach (var pizza in _itemService.SearchPizzas(searchTerm))
            {
                Items.Add(pizza);

            }
            Searching = false;

        }
        [RelayCommand]
        private async Task GoToDetailsPage(Item pizza)
        {
            var parameters = new Dictionary<string, object>
            {
                [nameof(DetailsViewModel.Pizza)] = pizza


            };
            await Shell.Current.GoToAsync(nameof(DetailPage), animate: true, parameters);
        }
    }
}
