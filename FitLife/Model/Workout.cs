namespace FitLife.Model
{
    public class Workout
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> ExercisesIds { get; set; }
    }

    public class WorkoutData
    {
        public static List<Workout> GetWorkouts()
        {
            return new List<Workout>()
            {
                new Workout()
                {
                    Id = 1,
                    Name = "Upper Body Workout",
                    ExercisesIds = new List<int>{1,3,4,5,6 }
                },
                new Workout()
                {
                    Id = 2,
                    Name = "Lower Body Workout",
                    ExercisesIds= new List<int>{2,7}

                }
            };
        }
    }
}
