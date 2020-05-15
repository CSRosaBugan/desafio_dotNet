using Microsoft.EntityFrameworkCore;
using desafio.Models;

namespace desafio.data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
        : base(options)
        {

        }
        public DbSet<User> Users { get; set; } 
    }
}
