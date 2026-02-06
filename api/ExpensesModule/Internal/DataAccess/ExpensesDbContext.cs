namespace ExpensesModule.Internal.DataAccess;

internal class ExpensesDbContext : DbContext
{
    public DbSet<CategoryEntity> Categories { get; set; } = null!;
    public DbSet<BudgetEntity> Budgets { get; set; } = null!;
    public DbSet<TransactionEntity> Transactions { get; set; } = null!;

    public ExpensesDbContext(DbContextOptions<ExpensesDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<CategoryEntity>(entity =>
        {
            entity.ToTable("Category");
            entity.HasKey(c => c.Name);

            entity.Property(t => t.CreatedAt)
                  .IsRequired();
        });

        modelBuilder.Entity<TransactionEntity>(entity =>
        {
            entity.ToTable("Transaction");
            entity.HasKey(t => t.Id);

            entity.Property(t => t.CreatedAt)
                  .IsRequired();

            entity.Property(t => t.Description)
                  .IsRequired();

            entity.Property(t => t.Amount)
                  .IsRequired();

            entity.Property(t => t.Date)
                  .IsRequired();

            entity.HasOne(t => t.Category)
                  .WithMany(c => c.Transactions)
                  .HasPrincipalKey(c => c.Name)
                  .HasForeignKey(t => t.CategoryName)
                  .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<BudgetEntity>(entity =>
        {
            entity.ToTable("Budget");
            entity.HasKey(b => b.Id);

            entity.Property(t => t.CreatedAt)
                  .IsRequired();

            entity.Property(b => b.Amount)
                  .IsRequired();

            entity.HasOne(b => b.Category)
                  .WithMany(c => c.Budgets)
                  .HasPrincipalKey(c => c.Name)
                  .HasForeignKey(b => b.CategoryName)
                  .OnDelete(DeleteBehavior.Cascade);
        });
    }
}
