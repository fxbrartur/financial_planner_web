using financial_planner_web_dotnet_domain.Entities;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace financial_planner_web_dotnet_infra;

public class financialPlannerDbContext : DbContext
{
    public DbSet<AccountPlan> AccountPlan {get; set;}
    public DbSet<Transaction> Transaction {get; set;}
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres");
    }

}
