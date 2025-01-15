using PromoSpark.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoSpark.Application.Interfaces
{
    public interface ISubmissionRepository : IRepositoryBase<Submission>
    {
        Task<IEnumerable<Submission>> GetByChallengeIdAsync(Guid challengeId);
        Task<IEnumerable<Submission>> GetByParticipantIdAsync(Guid participantId);
        Task<bool> HasUserSubmittedToChallenge(Guid userId, Guid challengeId);
        Task<IEnumerable<Submission>> GetPendingVerificationAsync();
        Task<IEnumerable<Submission>> GetRankedSubmissionsForChallenge(Guid challengeId);
        Task<int> GetSubmissionCountForChallenge(Guid challengeId);
    }
}
