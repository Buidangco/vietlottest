using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VietLotApi.Data;
using VietLotApi.DTOs;
using VietLotApi.Models;

namespace VietLotApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public RolesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetRoles()
        {
            var roles = await _context.Roles
                .Include(r => r.RolePermissions)
                .Include(r => r.Users)
                .ToListAsync();

            var result = roles.Select(r => new RoleDto
            {
                Id = r.Id,
                Name = r.Name,
                Description = r.Description,
                ColorCode = r.ColorCode,
                Permissions = r.RolePermissions.Select(p => p.PermissionCode).ToList(),
                MemberCount = r.Users.Count
            }).ToList();

            return Ok(new { success = true, data = result });
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole([FromBody] CreateRoleDto dto)
        {
            if (await _context.Roles.AnyAsync(r => r.Name == dto.Name))
                return BadRequest(new { success = false, message = "Tên nhóm đã tồn tại" });

            var role = new Role
            {
                Id = "G" + Guid.NewGuid().ToString().Substring(0, 3).ToUpper(),
                Name = dto.Name,
                Description = dto.Description,
                ColorCode = dto.ColorCode
            };

            foreach (var perm in dto.Permissions)
            {
                role.RolePermissions.Add(new RolePermission { RoleId = role.Id, PermissionCode = perm });
            }

            _context.Roles.Add(role);
            await _context.SaveChangesAsync();

            return StatusCode(201, new { success = true, data = role });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRole(string id, [FromBody] UpdateRoleDto dto)
        {
            var role = await _context.Roles.Include(r => r.RolePermissions).FirstOrDefaultAsync(r => r.Id == id);
            if (role == null) return NotFound();

            if (await _context.Roles.AnyAsync(r => r.Name == dto.Name && r.Id != id))
                return BadRequest(new { success = false, message = "Tên nhóm đã tồn tại" });

            role.Name = dto.Name;
            role.Description = dto.Description;
            if (!string.IsNullOrEmpty(dto.ColorCode)) role.ColorCode = dto.ColorCode;
            role.UpdatedAt = DateTime.UtcNow;

            _context.RolePermissions.RemoveRange(role.RolePermissions);
            foreach (var perm in dto.Permissions)
            {
                role.RolePermissions.Add(new RolePermission { RoleId = role.Id, PermissionCode = perm });
            }

            await _context.SaveChangesAsync();
            return Ok(new { success = true });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await _context.Roles.Include(r => r.Users).FirstOrDefaultAsync(r => r.Id == id);
            if (role == null) return NotFound();

            if (role.Users.Any())
                return BadRequest(new { success = false, message = "Không thể xóa nhóm đang có thành viên." });

            _context.Roles.Remove(role);
            await _context.SaveChangesAsync();
            return Ok(new { success = true });
        }
    }
}