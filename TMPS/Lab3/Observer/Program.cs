using Observer;
using Observer.Displays;

WeatherData weatherData = new WeatherData();
CurrentConditionsDisplay currentConditionsDisplay = new CurrentConditionsDisplay(weatherData);

weatherData.SetMeasurements(10, 20, 30);

AllDataDisplay AllDataDisplay = new AllDataDisplay(weatherData);

weatherData.SetMeasurements(15, 60, 50);

weatherData.RemoveObserver(currentConditionsDisplay);

weatherData.SetMeasurements(1, 1, 1);