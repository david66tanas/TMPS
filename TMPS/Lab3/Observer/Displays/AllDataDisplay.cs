namespace Observer.Displays
{
    public class AllDataDisplay : Display, Observer
    {
        private float temp;
        private float humidity;
        private float pressure;
        private Subject weatherData;

        public AllDataDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine(new String('-', 19));
            Console.WriteLine("|_____AllData_____|");
            Console.WriteLine($"| Temperature = {temp}");
            Console.WriteLine($"| Humidity = {humidity}");
            Console.WriteLine($"| Pressure = {pressure}");
            Console.WriteLine(new String('-', 19));
            Console.WriteLine();
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temp = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }
    }
}