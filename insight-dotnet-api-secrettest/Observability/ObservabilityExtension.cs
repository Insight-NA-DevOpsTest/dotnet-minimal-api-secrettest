
namespace insight_dotnet_api_secrettest.Observability;

public static class ObservabilityExtension
{
    public static ILogger<T> GetBasicConsoleLogger<T>()
    {
        var serviceProvider = new ServiceCollection().AddLogging(config => config.AddConsole())
            .Configure<LoggerFilterOptions>(config => config.MinLevel = LogLevel.Trace)
            .BuildServiceProvider();

        return serviceProvider.GetService<ILogger<T>>() ?? throw new InvalidOperationException();
    }

}
