using PromoSpark.Domain.Common.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoSpark.Application.Models.Requests
{
    public class CreateSubmissionRequest
    {
        [Required]
        public Guid ChallengeId { get; set; }

        [Required]
        [Url]
        public string VideoUrl { get; set; }

        [Required]
        [StringLength(1000)]
        public string Caption { get; set; }

        [Required]
        public PlatformEnum Platform { get; set; }

        [Required]
        [Url]
        public string PlatformPostUrl { get; set; }
    }
}
