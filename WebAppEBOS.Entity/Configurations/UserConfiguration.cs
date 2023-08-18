using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppEBOS.Entity.Entites;

namespace WebAppEBOS.Entity.Configurations;

public class UserConfiguration: IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");
        builder.HasKey(e => e.Id);

        builder.UseBaseProperties();
        
        // builder.HasData(DataSeed.GetUser());
    }
}