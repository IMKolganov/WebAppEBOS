using WebAppEBOS.Entity.Entites;
using WebAppEBOS.Entity.Entites.Enums;

namespace WebAppEBOS.Entity.Seed;

public class DataSeed
{

    public static IEnumerable<Customer> GetCustomers()
    {
        yield return new Customer { Id = 1, Name = "Instance", RefAppId = 1, Status = EntityStatus.Active};

    }
}