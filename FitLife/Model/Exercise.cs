using FitLife.ViewModel;

namespace FitLife.Model
{
    public class Exercise : BaseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Instructions { get; set; }
        public string Image { get; set; }

        public string Howmany { get; set; }

        private bool _isCompleted;
        public bool IsCompleted
        {
            get { return _isCompleted; }
            set
            {
                if (_isCompleted != value)
                {
                    _isCompleted = value;
                    OnPropertyChanged(nameof(IsCompleted));
                }
            }
        }
    }


    public class ExerciseData
    {
        public static List<Exercise> GetExercises()
        {
            return new List<Exercise>()
            {
                new Exercise()
                {
                    Id = 1,
                    Name = "Push-ups",
                    Description = "Upper body exercise",
                    Instructions = "1. Start in a plank position with your hands placed slightly wider than shoulder-width apart and your feet hip-width apart. Your body should form a straight line from your head to your heels.\n2. Lower your body towards the ground by bending your elbows, keeping them close to your sides.\n3. Keep your core and glutes engaged to maintain a straight line from your head to your heels.\n4. Lower your body until your chest touches the ground or your elbows form a 90-degree angle.\n5. Push your body back up to the starting position by extending your arms and pushing through your chest and shoulders.",
                    Image = "pushup.png",
                    Howmany = "3 Sets with 8-10 Reps",
                    IsCompleted = false
                },
                new Exercise()
                {
                    Id = 2,
                    Name = "Squats",
                    Description = "Lower body exercise",
                    Instructions = "1. Start with your feet shoulder-width apart and your toes pointing forward or slightly outward.\n2. Lower your body by bending your knees and hips, keeping your back straight and your chest up.\n3. Continue lowering your body until your thighs are parallel to the ground or lower.\n4. Push your body back up to the starting position by extending your legs and pushing through your heels.",
                    Image = "squat.jpeg",
                    Howmany = "3 Sets with 8-10 Reps",
                    IsCompleted = false
                },
                new Exercise()
                {
                    Id = 3,
                    Name = "Plank",
                    Description = "Core exercise",
                    Instructions = "1. Start in a push-up position with your hands shoulder-width apart and your feet hip-width apart.\n2. Keep your core and glutes engaged and your back flat.\n3. Hold this position for as long as you can without letting your hips sag or your lower back arch.",
                    Image = "plank.jpeg",
                    Howmany = "3 Sets of 30 sec hold",
                    IsCompleted = false
                },
                new Exercise()
                {
                    Id = 4,
                    Name = "Shoulder Press",
                    Description = "Upper body exercise",
                    Instructions = "1. Stand with your feet shoulder-width apart, holding dumbbells at shoulder height, palms facing forward. \n2. Press the dumbbells overhead, fully extending your arms. \n3. Slowly lower the dumbbells back to shoulder height. \n4. Repeat for the desired number of repetitions.",
                    Image = "shoulderpress.jpeg",
                    Howmany = "3 Sets of 8-12 reps",
                    IsCompleted = false
                },
                new Exercise()
                {
                    Id = 5,
                    Name = "Bent Over Rows",
                    Description = "Upper body exercise",
                    Instructions = "1. Stand with your feet hip-width apart, holding a dumbbell in each hand. \n2. Bend your knees slightly and hinge forward at the hips, keeping your back straight. \n3. Pull the dumbbells towards your chest, squeezing your shoulder blades together. \n4. Lower the dumbbells back to the starting position. \n5. Repeat for the desired number of repetitions.",
                    Image = "bentoverrows.jpg",
                    Howmany = "3 Sets of 6-10 reps",
                    IsCompleted = false
                }
                ,new Exercise()
                {
                    Id = 6,
                    Name = "Russian Twists",
                    Description = "Core exercise",
                    Instructions = "1. Sit on the floor with your knees bent, feet flat on the ground, and hold a weight with both hands. \n2. Lean back slightly, keeping your back straight, and lift your feet off the ground. \n3. Rotate your torso to the right, touching the weight to the floor beside your right hip. \n4. Rotate your torso to the left, touching the weight to the floor beside your left hip. \n5. Repeat for the desired number of repetitions.",
                    Image = "russiantwists.jpg",
                    Howmany = "1 Sets of 15 reps",
                    IsCompleted = false
                }
                ,new Exercise()
                {
                    Id = 7,
                    Name = "Mountain Climbers",
                    Description = "Full body exercise",
                    Instructions = "1. Start in a plank position with your hands shoulder-width apart. \n2. Bring your right knee towards your chest. \n3. Quickly switch legs, bringing your left knee towards your chest while extending your right leg back. \n4. Continue alternating legs for the desired number of repetitions.",
                    Image = "mountainclimber.jpg",
                    Howmany = "2 Sets of 8 reps",
                    IsCompleted = false
                }
            };
        }
    }
}
