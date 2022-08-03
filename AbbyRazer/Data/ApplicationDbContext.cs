using AbbyRazer.Model;
using Microsoft.EntityFrameworkCore;

namespace AbbyRazer.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {

        }
        public DbSet<Category> Category { get; set; }
    }
}
