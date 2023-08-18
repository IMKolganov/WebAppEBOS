using WebAppEBOS.Entity.Entites;
using WebAppEBOS.Entity.Entites.Enums;

namespace WebAppEBOS.Entity.Seed;

public class DataSeed
{

    public static IEnumerable<Customer> GetCustomers()
    {
        yield return new Customer { Id = 1, Name = "John", RefAppId = 1, Status = EntityStatus.Active };
        yield return new Customer { Id = 2, Name = "Emily", RefAppId = 2, Status = EntityStatus.Active };
        yield return new Customer { Id = 3, Name = "Michael", RefAppId = 3, Status = EntityStatus.Active };
        yield return new Customer { Id = 4, Name = "Sophia", RefAppId = 9, Status = EntityStatus.Active };
        yield return new Customer { Id = 5, Name = "William", RefAppId = 5, Status = EntityStatus.Active };
        yield return new Customer { Id = 7, Name = "Olivia", RefAppId = 2, Status = EntityStatus.Active };
        yield return new Customer { Id = 8, Name = "Liam", RefAppId = 10, Status = EntityStatus.Active };
        yield return new Customer { Id = 9, Name = "Ava", RefAppId = 15, Status = EntityStatus.Active };
        yield return new Customer { Id = 10, Name = "Noah", RefAppId = 8, Status = EntityStatus.Active };
        yield return new Customer { Id = 11, Name = "Isabella", RefAppId = 4, Status = EntityStatus.Active };
        yield return new Customer { Id = 12, Name = "James", RefAppId = 1, Status = EntityStatus.Active };
        yield return new Customer { Id = 13, Name = "Emma", RefAppId = 6, Status = EntityStatus.Active };
        yield return new Customer { Id = 14, Name = "Benjamin", RefAppId = 11, Status = EntityStatus.Active };
        yield return new Customer { Id = 15, Name = "Mia", RefAppId = 14, Status = EntityStatus.Active };
        yield return new Customer { Id = 16, Name = "Ethan", RefAppId = 13, Status = EntityStatus.Active };
        yield return new Customer { Id = 17, Name = "Charlotte", RefAppId = 3, Status = EntityStatus.Active };
        yield return new Customer { Id = 18, Name = "Alexander", RefAppId = 5, Status = EntityStatus.Active };
        yield return new Customer { Id = 19, Name = "Amelia", RefAppId = 9, Status = EntityStatus.Active };
        yield return new Customer { Id = 20, Name = "Daniel", RefAppId = 7, Status = EntityStatus.Active };
        yield return new Customer { Id = 21, Name = "Harper", RefAppId = 10, Status = EntityStatus.Active };
        yield return new Customer { Id = 22, Name = "Matthew", RefAppId = 2, Status = EntityStatus.Active };
    }
}