using FitLife.Model;

namespace FitLife.ViewModel
{
    public class ExerciseDetailViewModel : BaseViewModel
    {
        private Exercise _selectedExercise;
        public Exercise SelectedExercise
        {
            get { return _selectedExercise; }
            set
            {
                if (_selectedExercise != value)
                {
                    _selectedExercise = value;
                    OnPropertyChanged(nameof(SelectedExercise));
                }
            }
        }

        public ExerciseDetailViewModel(Exercise exercise)
        {
            SelectedExercise = exercise;
            Title = exercise.Name;
        }


    }
}
