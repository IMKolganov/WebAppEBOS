using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppEBOS.Entities.EntityModels;
using WebAppEBOS.Entities.EntityModels.Interfaces;


namespace WebAppEBOS.Data;

public class ApplicationDbContext : IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
{

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseQueryTrackingBehavior(QueryTrackingBehavior.TrackAll);
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var assembly = GetType().Assembly;
        modelBuilder.ApplyConfigurationsFromAssembly(assembly);
    }

    public override int SaveChanges() => SaveChanges(acceptAllChangesOnSuccess: true);

    public override int SaveChanges(bool acceptAllChangesOnSuccess)
    {
        SetAuditProperties();

        return base.SaveChanges(acceptAllChangesOnSuccess);
    }


    public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        => await SaveChangesAsync(acceptAllChangesOnSuccess: true, cancellationToken);

    public override async Task<int> SaveChangesAsync(
        bool acceptAllChangesOnSuccess,
        CancellationToken cancellationToken = default)
    {
        SetAuditProperties();

        return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
    }

    private void SetAuditProperties()
    {
        var entries = ChangeTracker
            .Entries()
            .Where(e => e.Entity is IEntityBase)
            .Where(e =>
                e.State is EntityState.Added or EntityState.Modified);

        foreach (var entityEntry in entries)
        {
            var auditEntry = (IEntityBase)entityEntry.Entity;

            if (entityEntry.State == EntityState.Added)
            {
                auditEntry.Created = DateTime.UtcNow;
            }

            auditEntry.Updated = DateTime.UtcNow;
        }
    }
}