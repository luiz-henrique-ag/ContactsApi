using Microsoft.EntityFrameworkCore;

namespace ContactsApi.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) 
            : base(options) 
        {
        }

        public DbSet<Contact> Contacts { get; set; } = null!;
    }
}
