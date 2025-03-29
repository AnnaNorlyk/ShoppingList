using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;

namespace ShoppingList.ViewModels
{
    public partial class NewList : ObservableObject
    {
        public NewList()
        {
        }

        [RelayCommand]
        private async Task GoHome()
        {
            await Shell.Current.GoToAsync("//HomePage");
        }

       
    }
}
