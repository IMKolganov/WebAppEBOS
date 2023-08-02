using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppEBOS.Entities.Configurations.Extensions;
using WebAppEBOS.Entities.EntityModels;

namespace WebAppEBOS.Entities.Configurations;

public class CustomerConfiguration: IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("Customers");

        builder.HasKey(e => e.Id);

        builder
            .Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(255);
        
        builder
            .Property(e => e.RefAppId)
            .IsRequired();
        
        builder
            .Property(e => e.Path);
        

        builder.UseBaseProperties();
        
        // builder.HasData(DataSeed.GetCustomers());
    }
    
    
}