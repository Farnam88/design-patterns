using DesignPatterns.Laboratory.DecoratorPattern;

namespace DesignPatterns.Tests.DecoratorPattern;

public class DecoratorTests
{
    [Fact]
    public void Decorator_ShouldPersistMailMessage_OnSuccessfulSend()
    {
        //Arrange
        IMailService azureMailService = new AzureMailService();

        PersistantMailDecorator decorator = new PersistantMailDecorator(azureMailService);

        string message = "Test";
        //Act
        var result = decorator.SendMail(message);

        //Assert
        Assert.True(result);
        Assert.NotEmpty(decorator.MailMessages);
    }


    [Fact]
    public void Decorator_ShouldLogStatistics_OnSuccessfulSend()
    {
        //Arrange
        IMailService amazonMailService = new AmazonMailService();

        StatisticsDecorator decorator = new StatisticsDecorator(amazonMailService);

        string message = "Test";
        //Act
        var result = decorator.SendMail(message);

        //Assert
        Assert.True(result);
    }
}