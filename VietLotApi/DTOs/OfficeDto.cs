using System.ComponentModel.DataAnnotations;

namespace VietLotApi.DTOs
{
    public class OfficeDto
    {
        public string Id { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string? ManagerId { get; set; }
        public string? ManagerName { get; set; }
        public string Status { get; set; } = string.Empty;
        public int EmployeeCount { get; set; }
    }

    public class CreateOfficeDto
    {
        [Required]
        public string Code { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = "DEPARTMENT";
        public string? ManagerId { get; set; }
    }

    public class UpdateOfficeDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = "DEPARTMENT";
        public string? ManagerId { get; set; }
        public string Status { get; set; } = "ACTIVE";
    }
}