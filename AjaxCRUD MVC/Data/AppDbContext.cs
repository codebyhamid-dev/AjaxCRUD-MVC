using AjaxCRUD_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace AjaxCRUD_MVC.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Transaction> Transactions { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Transaction>().HasData(
                new Transaction
                {
                    Id = 1,
                    AccountNumber = "PK00123456789",
                    BeneficiaryName = "Ali Khan",
                    BankName = "HBL",
                    SwiftCode = "HBLBPKKA",
                    Amount = 5000m,
                    Date = new DateTime(2026, 1, 1)
                },
                new Transaction
                {
                    Id = 2,
                    AccountNumber = "PK00987654321",
                    BeneficiaryName = "Sara Ahmed",
                    BankName = "UBL",
                    SwiftCode = "UNILPKKA",
                    Amount = 12000m,
                    Date = new DateTime(2026, 1, 5)
                }
            );
        }
    }
}
