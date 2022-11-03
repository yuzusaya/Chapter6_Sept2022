using DataBindingMauiApp.ViewModels;

namespace DataBindingMauiApp.Views;

public partial class MVVMPage : ContentPage
{
	public MVVMPage()
	{
		InitializeComponent();
        BindingContext = new MVVMViewModel();
    }
}