using PromoSpark.Application.Models.Requests;
using PromoSpark.Domain.Common.Enums;
using PromoSpark.Domain.Entities;

namespace PromoSpark.Application.Interfaces
{
    public interface IChallengeRepository
    {
        Task<IEnumerable<Challenge>> GetActiveAsync();
        Task<Challenge?> GetByIdAsync(Guid id);
        Task<Challenge> CreateChallengeAsync(CreateChallengeRequest request, Guid creativeId);
        Task AddAsync(Challenge challenge);
        Task UpdateAsync(Challenge challenge);
        Task<IEnumerable<Challenge>> GetByCreativeIdAsync(Guid creativeId);
        Task<bool> UpdateStatusAsync(Guid id, StatusEnum status);
    }
}
