namespace API_Testing;

using Microsoft.Extensions.Logging;

public class Tests
{
    private ILogger<Tests> _logger;

    [SetUp]
    public void Setup()
    {
        var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        _logger = loggerFactory.CreateLogger<Tests>();
        _logger.LogInformation("Test setup started");
    }

    [Test]
    public void Test1()
    {
        _logger.LogInformation("Test1 execution started");
        Assert.Pass();
        _logger.LogInformation("Test1 passed");
    }
}
