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
    }
}
