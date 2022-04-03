using Microsoft.Maui.Essentials;

namespace TripsterApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            CounterLabel.Text = $"Current count: {count}";

            SemanticScreenReader.Announce(CounterLabel.Text);


            var myLocation = await Geolocation.GetLocationAsync();
            var otherLocation = new Location(47.32635424270523, -122.00971100077268);

            var distance = myLocation.CalculateDistance(otherLocation, DistanceUnits.Miles);

            CounterLabel.Text = $"Distance to Lumber House: {distance:0.##} Miles";
        }
    }
}