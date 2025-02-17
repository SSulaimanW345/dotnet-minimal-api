using VillaCoupon.API.DTO;

namespace VillaCoupon.API.Repository
{
    public class AuthRepository : IAuthRepository
    {
        bool IAuthRepository.IsUniqueUser(string username)
        {
            throw new NotImplementedException();
        }

        Task<LoginResponseDTO> IAuthRepository.Login(LoginRequestDTO loginRequestDTO)
        {
            throw new NotImplementedException();
        }

        Task<UserDTO> IAuthRepository.Register(RegisterationRequestDTO requestDTO)
        {
            throw new NotImplementedException();
        }
    }
}
