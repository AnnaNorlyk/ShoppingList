using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;

namespace ShoppingList.ViewModels
{
    public partial class HomePage : ObservableObject
    {
        public HomePage()
        {
         
        }

        [RelayCommand]
        private async Task GoToMyRecipes()
        {

            await Shell.Current.GoToAsync("//MyRecipesPage");
        }

        [RelayCommand]
        private async Task GoToAddRecipes()
        {
            await Shell.Current.GoToAsync("//AddRecipesPage");
        }

        [RelayCommand]
        private async Task GoToNewList()
        {
            await Shell.Current.GoToAsync("//NewList");
        }
    }
}
