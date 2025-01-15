using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoSpark.Application.Models.Requests
{
    public class UpdateChallengeRequest
    {
        [StringLength(100, MinimumLength = 3)]
        public string? Title { get; set; }

        [StringLength(1000)]
        public string? Description { get; set; }

        public DateTime? Deadline { get; set; }

        [Range(1, 10)]
        public int? NumberOfWinners { get; set; }
    }
}
