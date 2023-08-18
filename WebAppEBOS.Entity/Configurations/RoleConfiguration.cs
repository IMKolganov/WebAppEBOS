using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppEBOS.Entity.Entites;

namespace WebAppEBOS.Entity.Configurations;

public class RoleConfiguration: IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("Roles");
        builder.HasKey(e => e.Id);

        builder.UseBaseProperties();
        
        // builder.HasData(DataSeed.GetRoles());
    }
}