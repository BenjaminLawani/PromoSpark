using PromoSpark.Domain.Common.Enums;

namespace PromoSpark.Domain.Entities
{
    public class Submission
    {
        public Guid Id { get; set; }
        public Guid ChallengeId { get; set; }
        public Guid ParticipantId { get; set; }
        public string VideoUrl { get; set; }
        public string Caption { get; set; }
        public PlatformEnum Platform { get; set; }
        public string PlatformPostUrl { get; set; }
        public int? Rank { get; set; }
        public decimal? RewardAmount { get; set; }
        public bool IsVerified { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Challenge Challenge { get; set; }
        public virtual User Participant { get; set; }
    }
}
