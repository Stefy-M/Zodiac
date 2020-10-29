using Microsoft.EntityFrameworkCore;
using ZodiacApp.API.Models;

namespace ZodiacApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}

        public DbSet<Value> Values {get;set;}

        public DbSet<User> User {get;set;}


        
    }
}