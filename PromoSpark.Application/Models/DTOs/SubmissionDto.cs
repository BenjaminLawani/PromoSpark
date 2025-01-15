using PromoSpark.Domain.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoSpark.Application.Models.DTOs
{
    public class SubmissionDto
    {
        public Guid Id { get; set; }
        public Guid ChallengeId { get; set; }
        public string VideoUrl { get; set; }
        public string Caption { get; set; }
        public PlatformEnum Platform { get; set; }
        public string PlatformPostUrl { get; set; }
        public int? Rank { get; set; }
        public decimal? RewardAmount { get; set; }
        public bool IsVerified { get; set; }
        public UserDto Participant { get; set; }
    }
}
