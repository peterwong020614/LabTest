using Question3.ViewModels;

namespace Question3;

public partial class User : ContentPage
{
	public User(UserViewModel userViewModel)
	{
		InitializeComponent();
		BindingContext = userViewModel;

    }
}