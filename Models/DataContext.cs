using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
  public DataContext(DbContextOptions<DataContext> options) : base(options) { }

  public DbSet<Category> Product{ get; set; }
  public DbSet<Product> ProductId { get; set; }
    public object Northwind { get; internal set; }
}