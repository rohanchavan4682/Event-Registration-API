using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventTicketingSystem.Application.IServices
{
    public class ILogin
    {

        public async Task<UserDto> LoginAsync(UserDto user); 
    }
}
