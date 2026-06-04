using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VietLotApi.Models
{
    public class User
    {
        [Key]
        [MaxLength(50)]
        public string Id { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string Email { get; set; } = string.Empty;

        [MaxLength(20)]
        public string? PhoneNumber { get; set; }

        [MaxLength(50)]
        public string? OfficeId { get; set; }

        public Office? Office { get; set; }

        [MaxLength(50)]
        public string? RoleId { get; set; }

        public Role? Role { get; set; }

        [MaxLength(20)]
        public string Status { get; set; } = "ACTIVE";

        [MaxLength(255)]
        public string? AvatarUrl { get; set; }

        public DateTime? LastLoginAt { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}