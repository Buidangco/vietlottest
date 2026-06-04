using Microsoft.EntityFrameworkCore;
using VietLotApi.Models;

namespace VietLotApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Office> Offices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<Office>().HasIndex(o => o.Code).IsUnique();

            modelBuilder.Entity<RolePermission>()
                .HasKey(rp => new { rp.RoleId, rp.PermissionCode });

            modelBuilder.Entity<RolePermission>()
                .HasOne(rp => rp.Role)
                .WithMany(r => r.RolePermissions)
                .HasForeignKey(rp => rp.RoleId);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasOne(u => u.Office)
                .WithMany(o => o.Users)
                .HasForeignKey(u => u.OfficeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = "G001", Name = "Admin (Giam doc)", Description = "Toan quyen he thong", ColorCode = "#7c3aed" },
                new Role { Id = "G002", Name = "Nhan vien Ke toan", Description = "Chi tra, hach toan", ColorCode = "#1d4ed8" }
            );

            modelBuilder.Entity<RolePermission>().HasData(
                new RolePermission { RoleId = "G001", PermissionCode = "dashboard" },
                new RolePermission { RoleId = "G001", PermissionCode = "phathanh" },
                new RolePermission { RoleId = "G001", PermissionCode = "thuhoi" },
                new RolePermission { RoleId = "G001", PermissionCode = "trathuong" },
                new RolePermission { RoleId = "G001", PermissionCode = "ketoan" },
                new RolePermission { RoleId = "G001", PermissionCode = "thamdinh" },
                new RolePermission { RoleId = "G001", PermissionCode = "daily" },
                new RolePermission { RoleId = "G001", PermissionCode = "baocao" },
                new RolePermission { RoleId = "G001", PermissionCode = "hethong" },
                new RolePermission { RoleId = "G001", PermissionCode = "nhatky" },
                new RolePermission { RoleId = "G001", PermissionCode = "congkhach" },
                new RolePermission { RoleId = "G002", PermissionCode = "dashboard" },
                new RolePermission { RoleId = "G002", PermissionCode = "ketoan" },
                new RolePermission { RoleId = "G002", PermissionCode = "baocao" },
                new RolePermission { RoleId = "G002", PermissionCode = "nhatky" }
            );

            modelBuilder.Entity<Office>().HasData(
                new Office { Id = "O001", Code = "BGD", Name = "Ban Giam Doc", Type = "DEPARTMENT" },
                new Office { Id = "O002", Code = "PTV", Name = "Phong Tai vu", Type = "DEPARTMENT" },
                new Office { Id = "O003", Code = "CN_HCM", Name = "Chi nhanh TP.HCM", Type = "BRANCH" }
            );
        }
    }
}