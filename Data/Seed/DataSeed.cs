using WebAppEBOS.Data.Entites;
using WebAppEBOS.Data.Entites.Enums;

namespace WebAppEBOS.Data.Seed;

public class DataSeed
{

    public static IEnumerable<Customer> GetCustomers()
    {
        yield return new Customer { Id = 1, Name = "Instance", RefAppId = 1, Status = EntityStatus.Active};

    }
}