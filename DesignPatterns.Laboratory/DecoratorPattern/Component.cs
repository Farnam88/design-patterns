namespace DesignPatterns.Laboratory.DecoratorPattern;

/// <summary>
/// Component
/// </summary>
public interface IMailService
{
    bool SendMail(string message);
}

/// <summary>
/// Component Implementation
/// </summary>
public class AmazonMailService : IMailService
{
    public bool SendMail(string message)
    {
        Console.WriteLine($"Mail Message: {message} \nFrom: {nameof(AmazonMailService)}");
        return true;
    }
}

/// <summary>
/// Component Implementation
/// </summary>
public class AzureMailService : IMailService
{
    public bool SendMail(string message)
    {
        Console.WriteLine($"Mail Message: {message} \nFrom: {nameof(AzureMailService)}");
        return true;
    }
}