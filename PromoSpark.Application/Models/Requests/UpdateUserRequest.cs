using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoSpark.Application.Models.Requests
{
    public class UpdateUserRequest
    {
        [StringLength(100, MinimumLength = 2)]
        public string? FullName { get; set; }

        [StringLength(500)]
        public string? Bio { get; set; }

        public string? SocialMediaLinks { get; set; }

        [StringLength(50)]
        public string? PayoutAccountNumber { get; set; }
    }

}
