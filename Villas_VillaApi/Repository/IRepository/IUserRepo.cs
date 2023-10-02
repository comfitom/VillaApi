using Villas_VillaApi.Models;
using Villas_VillaApi.Models.DTO;

namespace Villas_VillaApi.Repository.IRepository
{
    public interface IUserRepo
    {
        bool IsUniqueUser(string username);
        Task<LoginResponseDTO> Login(LoginRequestDTO loginRequest);
        Task<LocalUser> Register(RegistrationRequestDTO registrationRequest);
    }
}
