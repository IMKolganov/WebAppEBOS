using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppEBOS.Data.Entites;
using WebAppEBOS.Data.Seed;

namespace WebAppEBOS.Data.Configurations;

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