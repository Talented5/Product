


using Product.Services;
using System.Reflection.Metadata;

namespace Product.ViewModels
{
    public partial class HomeViewModel : ObservableObject
    {
        private readonly ItemService _itemService;
        public HomeViewModel(ItemService itemService)
        {
            _itemService = itemService;
            Items = new(_itemService.GetPopularPizzas());
        }
        public ObservableCollection<Item> Items { get; set; }
        [RelayCommand]
        private async Task GoToAllItemsPage(bool fromSearch = true)
        {
            var parameters = new Dictionary<string, object>
            {
                [nameof(AllItemViewModel.FromSearch)] = fromSearch


            };
            await Shell.Current.GoToAsync(nameof(AllItemsPage), animate : true,parameters);
        }
        [RelayCommand]
        private async Task GoToMobilePage(bool fromSearch = false)
        {
            var parameters = new Dictionary<string, object>
            {
                [nameof(AllItemViewModel.FromSearch)] = fromSearch


            };
            await Shell.Current.GoToAsync(nameof(MobilePage), animate: true, parameters);
        }
        
        [RelayCommand]
        private async Task GoToCategoryPage(Item pizza)
        {
          

            await Shell.Current.GoToAsync(nameof(MobilePage), animate: true );
        }
    }
}
