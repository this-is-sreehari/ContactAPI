using ContactAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ContactAPI.Data
{
    public class ContactAPIdbcontext : DbContext
    {
        public ContactAPIdbcontext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
