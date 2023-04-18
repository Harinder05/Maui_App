using FitLife.Model;
using FitLife.ViewModel;

namespace FitLife.Views;

public partial class WorkoutPage : ContentPage
{
    public WorkoutPage(WorkoutViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

    async void OnWorkoutTapped(object sender, EventArgs e)
    {
        var tappedFrame = sender as Frame;
        var selectedWorkout = tappedFrame.BindingContext as Workout;
        if (selectedWorkout != null)
        {
            var workoutDetailsPage = new WorkoutDetailPage(selectedWorkout);
            await Navigation.PushAsync(workoutDetailsPage);
        };

    }

}