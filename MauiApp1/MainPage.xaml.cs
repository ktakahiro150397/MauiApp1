using MauiApp1.ViewModels;

namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	MainPageViewModel vm;
	
	public MainPage()
	{
		InitializeComponent();

		vm = new MainPageViewModel();
		this.BindingContext = vm;
    }
}