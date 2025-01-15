using PromoSpark.Domain.Entities;
namespace PromoSpark.Application.Interfaces
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<User> GetByEmailAsync(string email);
        Task<bool> EmailExistsAsync(string email);
    }
}
