using BookingLib;

public class InitService : IHostedService
{
    public  Task StartAsync(CancellationToken cancellationToken)
    {
        new BookingService().Initialize();
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}

