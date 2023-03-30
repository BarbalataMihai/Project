using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Interfata.Models
{    
    //dbcontext class should inhert from idendity
    public class MyDbContext:IdentityDbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Grup> Grup { get; set; }

        public DbSet<CreateRoleViewModel> RoleName { get; set; }
        public DbSet<EditRoleViewModel> EditRole { get; set; }

        public DbSet<UserRoleViewModel> UserRole { get; set; }
    }
}
