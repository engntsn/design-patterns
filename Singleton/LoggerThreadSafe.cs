namespace Singleton;

public sealed class LoggerThreadSafe
{
    private static readonly Lazy<LoggerThreadSafe> _instance =
        new Lazy<LoggerThreadSafe>(() => new LoggerThreadSafe());

    private LoggerThreadSafe()
    {
    }

    public static LoggerThreadSafe Instance => _instance.Value;
    
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}