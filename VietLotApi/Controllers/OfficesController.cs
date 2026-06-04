using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VietLotApi.Data;
using VietLotApi.DTOs;
using VietLotApi.Models;

namespace VietLotApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public OfficesController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetOffices()
        {
            var offices = await _context.Offices
                .Include(o => o.Users)
                .OrderBy(o => o.Code)
                .ToListAsync();

            // Extract manager names
            var managerIds = offices.Where(o => !string.IsNullOrEmpty(o.ManagerId)).Select(o => o.ManagerId).Distinct().ToList();
            var managers = await _context.Users.Where(u => managerIds.Contains(u.Id)).ToDictionaryAsync(u => u.Id, u => u.FullName);

            var result = offices.Select(o => new OfficeDto
            {
                Id = o.Id,
                Code = o.Code,
                Name = o.Name,
                Type = o.Type,
                ManagerId = o.ManagerId,
                ManagerName = !string.IsNullOrEmpty(o.ManagerId) && managers.ContainsKey(o.ManagerId) ? managers[o.ManagerId] : null,
                Status = o.Status,
                EmployeeCount = o.Users.Count
            }).ToList();

            return Ok(new { success = true, total = result.Count, data = result });
        }

        [HttpPost]
        public async Task<IActionResult> CreateOffice([FromBody] CreateOfficeDto dto)
        {
            if (await _context.Offices.AnyAsync(o => o.Code == dto.Code))
                return BadRequest(new { success = false, message = "Mã đơn vị đã tồn tại" });

            var office = new Office
            {
                Id = "O" + Guid.NewGuid().ToString().Substring(0, 4).ToUpper(),
                Code = dto.Code.ToUpper(),
                Name = dto.Name,
                Type = dto.Type,
                ManagerId = dto.ManagerId
            };

            _context.Offices.Add(office);
            await _context.SaveChangesAsync();

            return StatusCode(201, new { success = true, data = office });
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOffice(string id, [FromBody] UpdateOfficeDto dto)
        {
            var office = await _context.Offices.FindAsync(id);
            if (office == null) return NotFound();

            office.Name = dto.Name;
            office.Type = dto.Type;
            office.ManagerId = dto.ManagerId;
            office.Status = dto.Status;
            office.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync();
            return Ok(new { success = true, data = office });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOffice(string id)
        {
            var office = await _context.Offices.Include(o => o.Users).FirstOrDefaultAsync(o => o.Id == id);
            if (office == null) return NotFound();

            if (office.Users.Any())
                return BadRequest(new { success = false, message = "Không thể xóa do đang có nhân sự" });

            _context.Offices.Remove(office);
            await _context.SaveChangesAsync();
            return Ok(new { success = true });
        }
    }
}