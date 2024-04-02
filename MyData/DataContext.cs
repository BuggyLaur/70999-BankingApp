using _70999_BankingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace _70999_BankingApp.MyData
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }


    }
}
