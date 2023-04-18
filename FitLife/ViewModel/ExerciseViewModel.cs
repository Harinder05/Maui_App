using FitLife.Model;
using System.Collections.ObjectModel;

namespace FitLife.ViewModel;

public partial class ExerciseViewModel : BaseViewModel
{
    public ObservableCollection<Exercise> ExercisesToShow { get; } = new ObservableCollection<Exercise>();
    public ExerciseViewModel()
    {
        Title = "Exercises List";
        foreach (Exercise exercise in ExerciseData.GetExercises())
        {
            ExercisesToShow.Add(exercise);
        }
    }
}