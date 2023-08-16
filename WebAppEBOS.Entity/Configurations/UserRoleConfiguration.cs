using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppEBOS.Data.Entites;
using WebAppEBOS.Data.Seed;

namespace WebAppEBOS.Data.Configurations;

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