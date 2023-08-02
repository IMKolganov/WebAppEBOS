using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppEBOS.Entities.Configurations.Extensions;
using WebAppEBOS.Entities.EntityModels;

namespace WebAppEBOS.Entities.Configurations;

public class UserClaimConfiguration: IEntityTypeConfiguration<UserClaim>
{
    public void Configure(EntityTypeBuilder<UserClaim> builder)
    {
        builder.ToTable("UserClaims");
        builder.HasKey(e => e.Id);

        builder.UseBaseProperties();
        
        // builder.HasData(DataSeed.UserClaims());
    }
}