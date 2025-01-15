﻿using PromoSpark.Domain.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoSpark.Application.Models.DTOs
{
    public class TokenInfo
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public RoleEnum Role { get; set; }
        public DateTime ExpirationTime { get; set; }
    }
}
