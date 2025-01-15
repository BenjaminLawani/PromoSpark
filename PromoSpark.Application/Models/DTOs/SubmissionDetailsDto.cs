using PromoSpark.Domain.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoSpark.Application.Models.DTOs
{
    public class SubmissionDetailsDto : SubmissionDto
    {
        public string ChallengeName { get; set; }
        public string CreativeName { get; set; }
        public decimal ChallengeRewardPool { get; set; }
        public List<PlatformEnum> AllowedPlatforms { get; set; }
        public StatusEnum ChallengeStatus { get; set; }
    }
}
