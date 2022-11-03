using DataBindingMauiApp.Models;

namespace DataBindingMauiApp.Views;

public partial class ThirdPage : ContentPage
{
	public ThirdPage()
	{
        InitializeComponent();
        myCollectionView.ItemsSource = new List<Student>
        {
            new Student{Id=1,Name="Test",Gender="Unknown",Status="Active"},
            new Student{Id=1,Name="Test2",Gender="Unknown2",Status="Inactive"},
            new Student{Id=1,Name="Test3",Gender="Unknown2",Status="Active"},
        };
    }
}