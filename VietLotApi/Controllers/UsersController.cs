using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VietLotApi.Data;
using VietLotApi.DTOs;
using VietLotApi.Models;

namespace VietLotApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UsersController(AppDbContext context)
        {
            _context = context;
        }

        private UserResponseDto MapToDto(User user)
        {
            return new UserResponseDto
            {
                Id = user.Id,
                FullName = user.FullName,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                OfficeId = user.OfficeId,
                OfficeName = user.Office?.Name,
                RoleId = user.RoleId,
                RoleName = user.Role?.Name,
                Status = user.Status,
                AvatarUrl = user.AvatarUrl,
                LastLoginAt = user.LastLoginAt,
                CreatedAt = user.CreatedAt
            };
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _context.Users.Include(u => u.Role).Include(u => u.Office).OrderByDescending(u => u.CreatedAt).ToListAsync();
            var data = users.Select(MapToDto).ToList();
            return Ok(new { success = true, total = data.Count, data });
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserDto dto)
        {
            if (await _context.Users.AnyAsync(u => u.Email == dto.Email))
                return BadRequest(new { success = false, message = "Email đã tồn tại" });

            var user = new User
            {
                Id = "U" + Guid.NewGuid().ToString().Substring(0, 4).ToUpper(),
                FullName = dto.FullName,
                Email = dto.Email,
                OfficeId = dto.OfficeId,
                RoleId = dto.RoleId
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            var createdUser = await _context.Users.Include(u => u.Role).Include(u => u.Office).FirstOrDefaultAsync(u => u.Id == user.Id);
            return StatusCode(201, new { success = true, data = MapToDto(createdUser!) });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(string id, [FromBody] UpdateUserDto dto)
        {
            var user = await _context.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.Id == id);
            if (user == null) return NotFound();

            user.FullName = dto.FullName;
            user.Email = dto.Email;
            user.OfficeId = dto.OfficeId;
            user.PhoneNumber = dto.PhoneNumber;
            user.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return Ok(new { success = true, data = MapToDto(user) });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return NotFound();

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return Ok(new { success = true });
        }

        [HttpPatch("{id}/status")]
        public async Task<IActionResult> UpdateStatus(string id, [FromBody] UpdateUserStatusDto dto)
        {
            var user = await _context.Users.Include(u => u.Role).FirstOrDefaultAsync(u => u.Id == id);
            if (user == null) return NotFound();

            user.Status = dto.Status;
            user.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return Ok(new { success = true, data = MapToDto(user) });
        }

        [HttpPost("{id}/avatar")]
        public async Task<IActionResult> UploadAvatar(string id, IFormFile avatar)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null) return NotFound();
            if (avatar == null || avatar.Length == 0) return BadRequest(new { success = false, message = "File rỗng" });

            var ext = Path.GetExtension(avatar.FileName);
            var fileName = id + ext;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads", "avatars", fileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await avatar.CopyToAsync(stream);
            }

            user.AvatarUrl = "/uploads/avatars/" + fileName;
            await _context.SaveChangesAsync();

            return Ok(new { success = true, avatar_url = user.AvatarUrl });
        }
    }
}