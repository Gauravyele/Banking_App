using Banking_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Banking_App.AppData
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) 
        {
        
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<Branches> Branches { get; set; }
        public DbSet<LoanApplication> LoanApplications { get; set; }
        public DbSet<Mfa> Mfas { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

    }
}
