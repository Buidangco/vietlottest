using System.ComponentModel.DataAnnotations;

namespace VietLotApi.DTOs
{
    public class RoleDto
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? ColorCode { get; set; }
        public List<string> Permissions { get; set; } = new();
        public int MemberCount { get; set; }
    }

    public class CreateRoleDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? ColorCode { get; set; }
        public List<string> Permissions { get; set; } = new();
    }

    public class UpdateRoleDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? ColorCode { get; set; }
        public List<string> Permissions { get; set; } = new();
    }
}