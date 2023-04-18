using FitLife.Model;
using FitLife.ViewModel;

namespace FitLife.Views;

public partial class ExerciseDetailPage : ContentPage
{
    public ExerciseDetailPage(Exercise selectedExercise)
    {
        InitializeComponent();
        BindingContext = new ExerciseDetailViewModel(selectedExercise);
    }

}