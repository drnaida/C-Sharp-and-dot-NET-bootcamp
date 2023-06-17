var temperature = new Temperature(TemperatureUnit.Celcius, 10);

enum TemperatureUnit
{
    Celcius,
    Fahrenheit,
    Kelvin
}

class Temperature
{
    public Temperature(TemperatureUnit unit, decimal value)
    {
        Unit = unit;
        Value = value;
    }

    public TemperatureUnit Unit { get; set; }
    public decimal Value { get; set; }

    public decimal ValueInCelcius
    {
        get
        {
            return Unit switch
            {
                TemperatureUnit.Celcius when Value > 100 => Math.Round(Value, 0),
                TemperatureUnit.Celcius => Value,
                TemperatureUnit.Fahrenheit => (Value - 32) * 5 / 9,
                TemperatureUnit.Kelvin => (Value - 273.15m),
                _ => 0,
            };
            
        }
    }
}