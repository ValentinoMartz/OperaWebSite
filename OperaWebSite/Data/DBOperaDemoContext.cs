using Microsoft.EntityFrameworkCore;
using OperaWebSite.Models;

namespace OperaWebSite.Data
{
    public class DBOperaDemoContext : DbContext
    {
        public DBOperaDemoContext(DbContextOptions<DBOperaDemoContext> options) : base(options) { }

       public DbSet<Opera> Operas { get; set; }
    }
}
