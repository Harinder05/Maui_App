using FitLife.ViewModel;

namespace FitLife.Views;

public partial class FindGymPage : ContentPage
{
    public IMap _map;
    public FindGymPage()
    {
        InitializeComponent();
        BindingContext = new FindGymViewModel(_map);
    }

}