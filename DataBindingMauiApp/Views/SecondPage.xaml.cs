namespace DataBindingMauiApp.Views;

[QueryProperty(nameof(RecordId), "id")]
[QueryProperty(nameof(Name), "name")]
public partial class SecondPage : ContentPage
{
    //public new int Id{get;set;}
    public int RecordId { get; set; }
    public string Name { get; set; }
    public SecondPage()
    {
        InitializeComponent();
    }

    public SecondPage(int id)
    {
        InitializeComponent();
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        Console.WriteLine($"{RecordId},{Name}");
        //First Method of Navigation
        //avigation.PopAsync();
        //Navigation.PopToRootAsync();

        //Second Method of Navigation
        Shell.Current.GoToAsync("..");
    }
}