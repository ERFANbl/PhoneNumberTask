using Domain.DbMpdels;
using Domain.Interfacses.Repositories;
using EntityFrameworkCore.Configuration;

namespace Infrastructure.Repositories;

public class UserPhoneNumberRepository : IUserPhoneNumberRepository
{

    protected readonly TaskDbContext _context;
    protected readonly ILogger<UserPhoneNumberRepository> _logger;
    public UserPhoneNumberRepository (TaskDbContext context, ILogger<UserPhoneNumberRepository> logger)
    {
        _context = context;
        _logger = logger;
    }

    public async Task SaveUserPhoneNumberAsync(string phoneNumber)
    {
        var UserNum = new UserPhoneNumber
        {
            PhoneNumber = phoneNumber,
        };

        try
        {
            await _context.AddAsync(UserNum);

            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error adding phone number {PhoneNumber}", phoneNumber);
            throw;
        }
    }
}
