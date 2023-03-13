using Microsoft.EntityFrameworkCore;
using LoanApplication.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using LoanApplication.Extensions;

namespace LoanApplication.Data
{
    public class LoanAppDbContext : DbContext
    {
        public LoanAppDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Seed();
        }

        public DbSet<LoanInfo> LoanInfos { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BlackList> BlackLists { get; set; }
        public DbSet<AppData> AppDatas { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
