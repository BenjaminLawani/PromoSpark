using PromoSpark.Application.Interfaces;
using PromoSpark.Infrastructure.Data;
using PromoSpark.Domain.Common.Enums;
using Microsoft.EntityFrameworkCore;
using PromoSpark.Domain.Entities;
using PromoSpark.Application.Models.Requests;

namespace PromoSpark.Infrastructure.Repositories
{
    public class ChallengeRepository : IChallengeRepository
    {
        private readonly AppDbContext _context;

        public ChallengeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Challenge>> GetActiveAsync()
        {
            return await _context.Challenges
                .Where(c => c.Status == StatusEnum.Active)
                .ToListAsync();
        }

        public async Task<Challenge?> GetByIdAsync(Guid id)
        {
            return await _context.Challenges.FindAsync(id);
        }

        public async Task AddAsync(Challenge challenge)
        {
            await _context.Challenges.AddAsync(challenge);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Challenge challenge)
        {
            _context.Challenges.Update(challenge);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Challenge>> GetByCreativeIdAsync(Guid creativeId)
        {
            return await _context.Challenges
                .Where(c => c.CreativeId == creativeId)
                .ToListAsync();
        }

        public Task<bool> UpdateStatusAsync(Guid id, StatusEnum status)
        {
            throw new NotImplementedException();
        }

        public Task<Challenge> CreateChallengeAsync(CreateChallengeRequest request, Guid creativeId)
        {
            throw new NotImplementedException();
        }
    }
}
