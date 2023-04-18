using FitLife.Model;
using FitLife.ViewModel;

namespace FitLife.Views;

public partial class WorkoutDetailPage : ContentPage
{
    public WorkoutDetailPage(Workout selectedWorkout)
    {
        InitializeComponent();
        BindingContext = new WorkoutDetailViewModel(selectedWorkout);
    }

}