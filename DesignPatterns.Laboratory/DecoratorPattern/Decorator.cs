using System.Collections.ObjectModel;

namespace DesignPatterns.Laboratory.DecoratorPattern;

/// <summary>
/// Decorator
/// </summary>
public abstract class MailServiceDecoratorBase : IMailService
{
    private readonly IMailService _mailService;

    protected MailServiceDecoratorBase(IMailService mailService)
    {
        _mailService = mailService;
    }

    public virtual bool SendMail(string message)
    {
        return _mailService.SendMail(message);
    }
}

/// <summary>
/// Decorator Implementation
/// </summary>
public class StatisticsDecorator : MailServiceDecoratorBase
{
    public StatisticsDecorator(IMailService mailService) : base(mailService)
    {
    }

    public override bool SendMail(string message)
    {
        Console.WriteLine($"Collecting Statistics by {nameof(StatisticsDecorator)}");
        return base.SendMail(message);
    }
}

/// <summary>
/// Decorator Implementation
/// </summary>
public class PersistantMailDecorator : MailServiceDecoratorBase
{
    public readonly IList<string> MailMessages;

    public PersistantMailDecorator(IMailService mailService) : base(mailService)
    {
        MailMessages = new List<string>();
    }

    public override bool SendMail(string message)
    {
        var result = base.SendMail(message);
        if (result)
        {
            MailMessages.Add(message);
            Console.WriteLine($"Message added to database by {nameof(StatisticsDecorator)}");
        }

        return result;
    }
}