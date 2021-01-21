using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AuthServer.Core.DTOs;
using SharedLibrary.Dto;

namespace AuthServer.Core.Services
{
    public interface IUserService
    {
        Task<Response<UserAppDto>> CreateUserAsync(CreateUserDto createUserDto);

        Task<Response<UserAppDto>> GetUserByName(string userName);
    }
}
