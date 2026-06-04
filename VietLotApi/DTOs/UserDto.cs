namespace VietLotApi.DTOs
{
    public class UserResponseDto
    {
        public string Id { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; }
        public string? OfficeId { get; set; }
        public string? OfficeName { get; set; }
        public string? RoleId { get; set; }
        public string? RoleName { get; set; }
        public string Status { get; set; } = string.Empty;
        public string? AvatarUrl { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class CreateUserDto
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? OfficeId { get; set; }
        public string? RoleId { get; set; }
    }

    public class UpdateUserDto
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? OfficeId { get; set; }
        public string? PhoneNumber { get; set; }
    }

    public class UpdateUserStatusDto
    {
        public string Status { get; set; } = string.Empty;
    }
}