using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppEBOS.Entity.Entites.Identity;

namespace WebAppEBOS.Entity.Configurations;

public class UserTokenConfiguration: IEntityTypeConfiguration<UserToken>
{
    public void Configure(EntityTypeBuilder<UserToken> builder)
    {
        builder.ToTable("UserTokens");
        builder.HasKey(ut => new { ut.UserId, ut.LoginProvider, ut.Value });
        builder.UseBaseProperties();
        
        // builder.HasData(DataSeed.GetUserToken());
    }
}