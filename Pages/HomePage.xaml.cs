using ShoppingList.ViewModels;

namespace ShoppingList.Pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomePage();
        }
    }
}
