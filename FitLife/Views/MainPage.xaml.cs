using FitLife.Model;
using FitLife.ViewModel;

namespace FitLife.Views;

public partial class MainPage : ContentPage
{


    public MainPage(ExerciseViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }


    async void OnExerciseTapped(object sender, EventArgs e)
    {
        var tappedGrid = sender as Grid;
        var selectedExercise = tappedGrid.BindingContext as Exercise;
        if (selectedExercise != null)
        {
            var detailsPage = new ExerciseDetailPage(selectedExercise);
            await Navigation.PushAsync(detailsPage);
        };

    }

}

