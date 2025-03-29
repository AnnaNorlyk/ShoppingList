using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ShoppingList.ViewModels
{
    public partial class AddRecipes : ObservableObject
    {
        public AddRecipes()
        {

        }

        [RelayCommand]
        private async Task GoHome()
        {
            await Shell.Current.GoToAsync("//HomePage");
        }
    }
}
