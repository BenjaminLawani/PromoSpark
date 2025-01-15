using PromoSpark.Domain.Common.Enums;
namespace PromoSpark.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string PasswordHash { get; set; }
        public RoleEnum Role { get; set; }
        public string? Bio { get; set; }
        public string? SocialMediaLinks { get; set; }
        public string? PayoutAccountNumber { get; set; }
        public decimal WalletBalance { get; set; }
        public bool IsEmailVerified { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
