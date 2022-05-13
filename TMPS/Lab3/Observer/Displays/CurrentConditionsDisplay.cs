namespace Observer.Displays
{
    public class CurrentConditionsDisplay : Display, Observer
    {
        private float temp;
        private float humidity;
        private Subject weatherData;

        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine(new String('-', 19));
            Console.WriteLine("|_____Current_____|");
            Console.WriteLine($"| Temperature = {temp}");
            Console.WriteLine($"| Humidity = {humidity}");
            Console.WriteLine(new String('-', 19));
            Console.WriteLine();
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            Display();
        }
    }
}