
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SchoolProject1.Models;

namespace SchoolProject1.data
{
    public class ApplicationDBcontext:IdentityDbContext
    {
        public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options) : base(options) { }
        public DbSet<SchoolProject1.Models.Product> Product { get; set; }
    }
}
