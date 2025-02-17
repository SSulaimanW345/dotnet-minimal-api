using VillaCoupon.API.DTO;

namespace VillaCoupon.API.Repository
{
    public interface IAuthRepository:
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequestDTO);
        Task<UserDTO> Register(RegisterationRequestDTO requestDTO);
    }
}
