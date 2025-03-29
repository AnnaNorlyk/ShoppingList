using ShoppingList.ViewModels;

namespace ShoppingList.Pages
{
    public partial class AddRecipesPage : ContentPage
    {
        public AddRecipesPage()
        {
            InitializeComponent();

            BindingContext = new MyRecipes();
        }
    }

}
