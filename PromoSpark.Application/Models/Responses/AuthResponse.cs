using PromoSpark.Application.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromoSpark.Application.Models.Responses
{
    public class AuthResponse
    {
        public string Token { get; set; }
        public UserDto User { get; set; }
        public DateTime TokenExpiration { get; set; }
    }
}
