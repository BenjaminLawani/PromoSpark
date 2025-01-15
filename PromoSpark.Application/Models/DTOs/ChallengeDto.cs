using PromoSpark.Domain.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoSpark.Application.Models.DTOs
{
    public class ChallengeDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string SongUrl { get; set; }
        public decimal RewardPool { get; set; }
        public int NumberOfWinners { get; set; }
        public DateTime Deadline { get; set; }
        public List<PlatformEnum> AllowedPlatforms { get; set; }
        public StatusEnum Status { get; set; }
        public UserDto Creative { get; set; }
    }

}
