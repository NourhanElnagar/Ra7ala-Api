using Domain.Entities;
using System.Security.Claims;

namespace Domain.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<AppUser?> GetByIdAsync(string userId);
        Task<bool> IsSuperAdminExistsForCompanyAsync(int companyId);
        Task<string?> GetUserIdFromClaimsPrincipalAsync(ClaimsPrincipal user);
        Task<SuperAdmin?> GetSuperAdminByUserIdAsync(string userId);
        Task<Admin?> GetAdminByUserIdAsync(string userId);
        Task<Driver?> GetDriverByUserIdAsync(string userId);
        Task<Passenger?> GetPassengerByUserIdAsync(string userId);
        Task<AppUser?> GetUserByEmailAsync(string email);
        Task<bool> CheckPasswordAsync(AppUser user, string password);
        Task<AppUser?> GetSystemOwnerAsync();
        Task<IEnumerable<Admin>> GetAdminsByCompanyIdAsync(int companyId);
        Task<IEnumerable<Driver>> GetDriversByCompanyIdAsync(int companyId);
    }
}