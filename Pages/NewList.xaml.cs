using ShoppingList.ViewModels;

namespace ShoppingList.Pages
{
    public partial class NewListPage : ContentPage
    {
        public NewListPage()
        {
            InitializeComponent();

            BindingContext = new NewList();
        }
    }
}
