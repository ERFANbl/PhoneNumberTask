using Domain.Interfacses.Integrations;
using Domain.Interfacses.Repositories;
using Domain.Interfacses.Services;

namespace Application.Services;

public class UserPhoneNumberService : IUserPhoneNumberService
{
    protected IUserPhoneNumberRepository _phoneRepository;
    protected ISmsSender _smsSender;
    

    public UserPhoneNumberService(IUserPhoneNumberRepository phoneRepository, ISmsSender smsSender)
    {
        _phoneRepository = phoneRepository;
        _smsSender = smsSender;
    }

    public async Task SaveUserPhoneNumberAsync(string phoneNumber)
    {

         await _phoneRepository.SaveUserPhoneNumberAsync(phoneNumber);
         _smsSender.SendSMS("Welcome.Your phone number has been saved.", phoneNumber);
    }
}
