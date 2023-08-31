using AutoMapper;
using HotelList.API.Data;
using HotelList.API.Models.Users;
using HotelList.API.Repository;
using Microsoft.AspNetCore.Identity;

namespace HotelList.API.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);
        Task<AuthResponseDto> Login(LoginDto loginDto);
        Task<string> CreateRefreshToken();
        Task<AuthResponseDto> VerifyRefreshToken(AuthResponseDto request);
    }
}
