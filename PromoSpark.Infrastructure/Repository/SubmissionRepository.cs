using Microsoft.EntityFrameworkCore;
using PromoSpark.Application.Interfaces;
using PromoSpark.Domain.Entities;
using PromoSpark.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoSpark.Infrastructure.Repository
{
    public class SubmissionRepository : Repository<Submission>, ISubmissionRepository
    {
        public SubmissionRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Submission>> GetByChallengeIdAsync(Guid challengeId)
        {
            return await _context.Submissions
                .Include(s => s.Participant)
                .Where(s => s.ChallengeId == challengeId)
                .OrderByDescending(s => s.CreatedAt)
                .ToListAsync();
        }

        public async Task<IEnumerable<Submission>> GetByParticipantIdAsync(Guid participantId)
        {
            return await _context.Submissions
                .Include(s => s.Challenge)
                .Where(s => s.ParticipantId == participantId)
                .OrderByDescending(s => s.CreatedAt)
                .ToListAsync();
        }

        public async Task<bool> HasUserSubmittedToChallenge(Guid userId, Guid challengeId)
        {
            return await _context.Submissions
                .AnyAsync(s => s.ParticipantId == userId &&
                              s.ChallengeId == challengeId);
        }

        public async Task<IEnumerable<Submission>> GetPendingVerificationAsync()
        {
            return await _context.Submissions
                .Include(s => s.Participant)
                .Include(s => s.Challenge)
                .Where(s => !s.IsVerified)
                .OrderByDescending(s => s.CreatedAt)
                .ToListAsync();
        }

        public async Task<IEnumerable<Submission>> GetRankedSubmissionsForChallenge(Guid challengeId)
        {
            return await _context.Submissions
                .Include(s => s.Participant)
                .Where(s => s.ChallengeId == challengeId &&
                           s.Rank.HasValue)
                .OrderBy(s => s.Rank)
                .ToListAsync();
        }

        public async Task<int> GetSubmissionCountForChallenge(Guid challengeId)
        {
            return await _context.Submissions
                .CountAsync(s => s.ChallengeId == challengeId);
        }

        public override async Task<Submission> GetByIdAsync(Guid id)
        {
            return await _context.Submissions
                .Include(s => s.Participant)
                .Include(s => s.Challenge)
                .FirstOrDefaultAsync(s => s.Id == id);
        }

        public override async Task<IEnumerable<Submission>> GetAllAsync()
        {
            return await _context.Submissions
                .Include(s => s.Participant)
                .Include(s => s.Challenge)
                .OrderByDescending(s => s.CreatedAt)
                .ToListAsync();
        }
    }
}
