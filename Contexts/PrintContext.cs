using Microsoft.EntityFrameworkCore;
using System.Data;

namespace TestingRestAPI.Contexts
{
    public class PrintContext : DbContext
    {

        public PrintContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Receipt> Receipts { get; set; } = null!;
    }
}
