using DataBindingMauiApp.Views;

namespace DataBindingMauiApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
        //First Method of Navigation
        //Navigation.PushAsync(new SecondPage());
        //Navigation.PushAsync(new SecondPage(1));


        //Second Method of Navigation
        //Shell.Current.GoToAsync("SecondPage");
        await Shell.Current.GoToAsync($"{nameof(SecondPage)}?id=1&name=abc");
    }
}

