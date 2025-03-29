
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;

namespace ShoppingList.ViewModels
{
    public partial class MyRecipes : ObservableObject
    {
        public MyRecipes()
        {
          
        }

        [RelayCommand]
        private async Task GoHome()
        {
            await Shell.Current.GoToAsync("//HomePage");
        }
    }
}
