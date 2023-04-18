using System.Diagnostics;

namespace FitLife.ViewModel
{
    public class FindGymViewModel : BaseViewModel
    {
        private IMap _map;

        public Command<string> FindGymCommand { get; }


        public FindGymViewModel(IMap map)
        {
            _map = map;
            FindGymCommand = new Command<string>(async (gymName) => await FindGymAsync(gymName));

        }

        public async Task FindGymAsync(string gymName)
        {
            try
            {
                var uri = new Placemark
                {
                    Thoroughfare = $"{gymName}"
                };

                await Map.OpenAsync(uri);

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw new Exception("Error. Could Not Open the Maps");
            }

        }
    }
}
