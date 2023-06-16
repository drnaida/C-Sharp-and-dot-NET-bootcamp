ICar tesla = new TeslaModels();
ICar nissan = new NissanMicro();

Console.WriteLine($"{tesla.GetModel()}: {tesla.GetTopSpeed()} km/h");
Console.WriteLine($"{nissan.GetModel()}: {nissan.GetTopSpeed()} km/h");

public interface ICar
{
    string GetModel();
    int GetTopSpeed();
}


public class TeslaModels : ICar
{
    public string GetModel()
    {
        return "Tesla model 5";
    }

    public int GetTopSpeed()
    {
        return 282;
    }
}

public class NissanMicro : ICar
{
    public string GetModel()
    {
        return "Nissan Micro";
    }

    public int GetTopSpeed()
    {
        return 283;
    }
}