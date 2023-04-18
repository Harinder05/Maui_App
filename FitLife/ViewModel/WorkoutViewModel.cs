using FitLife.Model;
using System.Collections.ObjectModel;

namespace FitLife.ViewModel;
public partial class WorkoutViewModel : BaseViewModel
{


    public ObservableCollection<Workout> WorkoutsToShow { get; } = new ObservableCollection<Workout>();

    public WorkoutViewModel()
    {
        Title = "Workouts";
        foreach (Workout workout in WorkoutData.GetWorkouts())
        {
            WorkoutsToShow.Add(workout);
        }

    }
}






