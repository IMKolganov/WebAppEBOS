using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppEBOS.Entities.Configurations.Extensions;
using WebAppEBOS.Entities.EntityModels;

namespace WebAppEBOS.Entities.Configurations;

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