using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Models
{
    public class SalesWebMvcContext: DbContext
    {
        public SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options) : base(options)
        {

        }

        public DbSet<SalesWebMvc.Models.Department> Department { get; set; }

    }
}
