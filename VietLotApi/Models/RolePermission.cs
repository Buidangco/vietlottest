using System.ComponentModel.DataAnnotations;

namespace VietLotApi.Models
{
    public class RolePermission
    {
        [MaxLength(50)]
        public string RoleId { get; set; } = string.Empty;
        public Role Role { get; set; } = null!;

        [MaxLength(50)]
        public string PermissionCode { get; set; } = string.Empty;
    }
}