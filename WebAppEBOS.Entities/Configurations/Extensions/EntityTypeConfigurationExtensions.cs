using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebAppEBOS.Entities.Configurations.Extensions;

public static class EntityTypeConfigurationExtensions
{
    private const string CreatedColumn = "Created";
    private const string UpdatedColumn = "Updated";
    
    public static void UseBaseProperties(this EntityTypeBuilder builder)
    {
        builder.Property(typeof(DateTime), CreatedColumn)
            .IsRequired();

        builder
            .Property(typeof(DateTime), UpdatedColumn)
            .IsRequired();
    }
}