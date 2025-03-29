using ShoppingList.ViewModels;

namespace ShoppingList.Pages
{
    public partial class MyRecipesPage : ContentPage
    {
        public MyRecipesPage()
        {
            InitializeComponent();

            BindingContext = new MyRecipes();
        }
    }
}
