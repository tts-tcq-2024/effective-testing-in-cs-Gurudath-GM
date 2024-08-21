public interface INetworkAlert
{
    int SendAlert(float celsius);
}

public class NetworkAlertStub : INetworkAlert
{
    public int SendAlert(float celsius)
    {
        Console.WriteLine($"Sending alert for temperature: {celsius} Celsius.");
        return 500;
    }
}

public class NetworkAlert : INetworkAlert
{
    public int SendAlert(float celsius)
    {
        Console.WriteLine($"Sending alert for temperature: {celsius} Celsius.");
        return 200;
    }
}
