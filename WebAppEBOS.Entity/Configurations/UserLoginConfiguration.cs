using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppEBOS.Entity.Entites.Identity;

namespace WebAppEBOS.Entity.Configurations;

public class UserLoginConfiguration: IEntityTypeConfiguration<UserLogin>
{
    public void Configure(EntityTypeBuilder<UserLogin> builder)
    {
        builder.ToTable("UserLogins");
        builder.HasKey(e => e.UserId);

        builder.UseBaseProperties();
        
        // builder.HasData(DataSeed.GetUserLogin());
    }
}