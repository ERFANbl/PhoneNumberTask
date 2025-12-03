using Domain.DTOs;
using Domain.Interfacses.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPhoneNumberController : ControllerBase
    {
        protected IUserPhoneNumberService _phoneService;
        public UserPhoneNumberController(IUserPhoneNumberService phoneService) 
        {
            _phoneService = phoneService;
        }

        [HttpPost("SavePhoneNumber")]
        public async Task SaveUserPhoneNumber([FromBody] UserPhoneNumberDTO phoneNumber)
        {
            await _phoneService.SaveUserPhoneNumberAsync(phoneNumber.PhoneNumber);
        }
    }
}
