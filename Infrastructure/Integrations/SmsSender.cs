using Domain.Interfacses.Integrations;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Integrations;

public class SmsSender : ISmsSender
{

    protected readonly ILogger<SmsSender> _logger;
    public SmsSender(ILogger<SmsSender> logger) 
    {
        _logger = logger;
    }

    public Task SendSMS(string Message, string phoneNumber)
    {
        _logger.LogInformation("Phone number {PhoneNumber} added successfully.", phoneNumber);
        return Task.CompletedTask;
    }

}
