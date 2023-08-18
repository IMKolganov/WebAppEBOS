using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppEBOS.Entity.Entites;

namespace WebAppEBOS.Entity.Configurations;

public class UserRoleConfiguration: IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        builder.ToTable("UserRoles");
        builder.HasKey(ur => new { ur.UserId, ur.RoleId });

        // builder
        //     .Property(e => e.RoleId)
        //     .IsRequired();
        //
        // builder
        //     .Property(e => e.UserId)
        //     .IsRequired();

        builder.UseBaseProperties();
        
        // builder.HasData(DataSeed.GetUserRole());
    }
}