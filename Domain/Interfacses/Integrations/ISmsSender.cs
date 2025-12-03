namespace Domain.Interfacses.Integrations;

public interface ISmsSender
{
    public Task SendSMS(string Message, string phoneNumber);
}
