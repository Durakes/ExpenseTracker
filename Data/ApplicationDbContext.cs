using Microsoft.EntityFrameworkCore;
namespace ExpenseTracker.Data;
using ExpenseTracker.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<Income> Incomes { get; set; }
    public DbSet<IncomeCategory> IncomeCategories { get; set; }
    public DbSet<Expense> Expenses { get; set; }
    public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
    public DbSet<Store> Stores { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region TABLE NAMES
        modelBuilder.Entity<Transaction>().ToTable("transaction");
        modelBuilder.Entity<Income>().ToTable("income");
        modelBuilder.Entity<IncomeCategory>().ToTable("income_category");
        modelBuilder.Entity<Expense>().ToTable("expense");
        modelBuilder.Entity<ExpenseCategory>().ToTable("expense_category");
        modelBuilder.Entity<Store>().ToTable("store");
        #endregion
    }
}