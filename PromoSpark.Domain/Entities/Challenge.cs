using System.ComponentModel.DataAnnotations.Schema;
using PromoSpark.Domain.Common.Enums;

namespace PromoSpark.Domain.Entities
{
    public class Challenge
    {
        public Guid Id { get; set; }
        public Guid CreativeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string SongUrl { get; set; }
        public decimal RewardPool { get; set; }
        public int NumberOfWinners { get; set; }
        public DateTime Deadline { get; set; }
        public List<PlatformEnum> AllowedPlatforms { get; set; }
        public StatusEnum Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual User Creative { get; set; }
        public virtual ICollection<Submission> Submissions { get; set; }
    }
}
