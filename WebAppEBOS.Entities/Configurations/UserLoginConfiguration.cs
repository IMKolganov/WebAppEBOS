using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppEBOS.Entities.Configurations.Extensions;
using WebAppEBOS.Entities.EntityModels;

namespace WebAppEBOS.Entities.Configurations;

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