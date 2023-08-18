using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppEBOS.Entity.Seed;
using WebAppEBOS.Entity.Entites;
using WebAppEBOS.Entity.Seed;

namespace WebAppEBOS.Entity.Configurations;

public class CallConfiguration: IEntityTypeConfiguration<Call>
{
    public void Configure(EntityTypeBuilder<Call> builder)
    {
        builder.ToTable("Calls");

        builder.HasKey(e => e.Id);

        builder.UseBaseProperties();
        
        builder.HasData(DataSeed.GetCalls());
    }
    
    
}