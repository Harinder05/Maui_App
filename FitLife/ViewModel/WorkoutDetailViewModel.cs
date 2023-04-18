using FitLife.Model;
using System.ComponentModel;

namespace FitLife.ViewModel
{
    public class WorkoutDetailViewModel : BaseViewModel
    {
        private Workout _selectedWorkout;
        public Workout SelectedWorkout
        {
            get { return _selectedWorkout; }
            set
            {
                if (_selectedWorkout != value)
                {
                    _selectedWorkout = value;
                    OnPropertyChanged(nameof(SelectedWorkout));
                    OnPropertyChanged(nameof(ExercisesLeftToDo));
                }
            }
        }


        private List<Exercise> _listexercises;
        public List<Exercise> ListOfExercisesToShow => _listexercises;

        public int ExercisesLeftToDo => _listexercises.Count(e => !e.IsCompleted);

        private List<Exercise> GetWorkoutExercises()
        {
            var allExercises = ExerciseData.GetExercises();
            var exerciseToShowBasedOnWorkout = new List<Exercise>();
            foreach (var exerciseId in SelectedWorkout.ExercisesIds)
            {
                var matchedExercise = allExercises.FirstOrDefault(e => e.Id == exerciseId);
                if (matchedExercise != null)
                {
                    matchedExercise.PropertyChanged += Exercise_PropertyChanged;
                    exerciseToShowBasedOnWorkout.Add(matchedExercise);
                }
            }
            return exerciseToShowBasedOnWorkout;
        }

        private void Exercise_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Exercise.IsCompleted))
            {
                OnPropertyChanged(nameof(ExercisesLeftToDo));
            }
        }

        public WorkoutDetailViewModel(Workout workout)
        {
            SelectedWorkout = workout;
            _listexercises = GetWorkoutExercises();
        }
    }
}
