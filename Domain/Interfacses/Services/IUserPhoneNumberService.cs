namespace Domain.Interfacses.Services;

public interface IUserPhoneNumberService
{
    public Task SaveUserPhoneNumberAsync(string phoneNumber);
}
