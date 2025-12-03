namespace Domain.Interfacses.Repositories;

public interface IUserPhoneNumberRepository
{
    public  Task SaveUserPhoneNumberAsync(string phoneNumber);
}
