using WebAppEBOS.Entity.Entites;
using WebAppEBOS.Entity.Entites.Enums;

namespace WebAppEBOS.Entity.Seed;

public class DataSeed
{
public static IEnumerable<Customer> GetCustomers()
{
    yield return new Customer
    {
        Id = 1,
        Name = "John",
        Surname = "Doe",
        TelephoneHomeNumber = "123-456-7890",
        TelephonePhoneNumber = "987-654-3210",
        TelephoneWorkNumber = "555-123-4567",
        Address = "123 Main St",
        Country = "USA",
        PostCode = 12345,
        DateBirth = new DateTime(1985, 5, 10),
        RefAppId = 1,
        Path = "path/to/file1"
    };

    yield return new Customer
    {
        Id = 2,
        Name = "Emily",
        Surname = "Smith",
        TelephoneHomeNumber = "555-789-1234",
        TelephonePhoneNumber = "444-321-5678",
        TelephoneWorkNumber = "777-555-8888",
        Address = "456 Elm St",
        Country = "Canada",
        PostCode = 56789,
        DateBirth = new DateTime(1990, 8, 15),
        RefAppId = 2,
        Path = "path/to/file2"
    };

    yield return new Customer
    {
        Id = 3,
        Name = "Jessica",
        Surname = "Johnson",
        TelephoneHomeNumber = "777-111-2222",
        TelephonePhoneNumber = "888-333-4444",
        TelephoneWorkNumber = "555-666-7777",
        Address = "789 Oak St",
        Country = "USA",
        PostCode = 67890,
        DateBirth = new DateTime(1992, 3, 25),
        RefAppId = 3,
        Path = "path/to/file3"
    };

    yield return new Customer
    {
        Id = 4,
        Name = "Daniel",
        Surname = "Williams",
        TelephoneHomeNumber = "999-444-5555",
        TelephonePhoneNumber = "222-555-6666",
        TelephoneWorkNumber = "333-666-7777",
        Address = "567 Maple St",
        Country = "USA",
        PostCode = 34567,
        DateBirth = new DateTime(1988, 12, 5),
        RefAppId = 4,
        Path = "path/to/file4"
    };

    yield return new Customer
    {
        Id = 5,
        Name = "Sophia",
        Surname = "Brown",
        TelephoneHomeNumber = "111-222-3333",
        TelephonePhoneNumber = "444-555-6666",
        TelephoneWorkNumber = "777-888-9999",
        Address = "101 Pine St",
        Country = "USA",
        PostCode = 12345,
        DateBirth = new DateTime(1993, 7, 18),
        RefAppId = 5,
        Path = "path/to/file5"
    };

    yield return new Customer
    {
        Id = 6,
        Name = "Ethan",
        Surname = "Taylor",
        TelephoneHomeNumber = "555-777-8888",
        TelephonePhoneNumber = "222-444-5555",
        TelephoneWorkNumber = "111-888-9999",
        Address = "202 Oak St",
        Country = "USA",
        PostCode = 67890,
        DateBirth = new DateTime(1991, 11, 22),
        RefAppId = 6,
        Path = "path/to/file6"
    };
}


    public static IEnumerable<Call> GetCalls()
    {
        yield return new Call
        {
            Id = 1,
            CallerId = 1,
            ReceiverId = 2,
            CallerPhoneNumber = "123-456-7890",
            ReceiverPhoneNumber = "987-654-3210",
            Subject = "Meeting",
            Description = "Discuss project status",
            StartTime = DateTime.Now.AddMinutes(-30),
            DurationInSeconds = 1800,
            CallStatus = CallStatus.Incoming,
            CallRating = CallRating.Excellent,
            IsArchived = false,
            CallDateTime = DateTime.Now.AddMinutes(-30)
        };

        yield return new Call
        {
            Id = 2,
            CallerId = 3,
            ReceiverId = 4,
            CallerPhoneNumber = "555-123-4567",
            ReceiverPhoneNumber = "555-987-6543",
            Subject = "Conference Call",
            Description = "Planning session",
            StartTime = DateTime.Now.AddHours(-2),
            DurationInSeconds = 2700,
            CallStatus = CallStatus.Outgoing,
            CallRating = CallRating.Good,
            IsArchived = true,
            CallDateTime = DateTime.Now.AddHours(-2)
        };

        yield return new Call
        {
            Id = 3,
            CallerId = 6,
            ReceiverId = 7,
            CallerPhoneNumber = "111-222-3333",
            ReceiverPhoneNumber = "444-555-6666",
            Subject = "Support Call",
            Description = "Technical assistance",
            StartTime = DateTime.Now.AddHours(-5),
            DurationInSeconds = 1200,
            CallStatus = CallStatus.Incoming,
            CallRating = CallRating.Fair,
            IsArchived = false,
            CallDateTime = DateTime.Now.AddHours(-5)
        };

        yield return new Call
        {
            Id = 4,
            CallerId = 8,
            ReceiverId = 9,
            CallerPhoneNumber = "999-888-7777",
            ReceiverPhoneNumber = "777-888-9999",
            Subject = "Sales Call",
            Description = "Product presentation",
            StartTime = DateTime.Now.AddHours(-10),
            DurationInSeconds = 1500,
            CallStatus = CallStatus.Outgoing,
            CallRating = CallRating.Excellent,
            IsArchived = true,
            CallDateTime = DateTime.Now.AddHours(-10)
        };

        yield return new Call
        {
            Id = 5,
            CallerId = 1,
            ReceiverId = 2,
            CallerPhoneNumber = "123-456-7890",
            ReceiverPhoneNumber = "987-654-3210",
            Subject = "Meeting",
            Description = "Discuss project status",
            StartTime = DateTime.Now.AddMinutes(-30),
            DurationInSeconds = 1800,
            CallStatus = CallStatus.Incoming,
            CallRating = CallRating.Excellent,
            IsArchived = false,
            CallDateTime = DateTime.Now.AddMinutes(-30)
        };

        yield return new Call
        {
            Id = 6,
            CallerId = 3,
            ReceiverId = 4,
            CallerPhoneNumber = "555-123-4567",
            ReceiverPhoneNumber = "555-987-6543",
            Subject = "Conference Call",
            Description = "Planning session",
            StartTime = DateTime.Now.AddHours(-2),
            DurationInSeconds = 2700,
            CallStatus = CallStatus.Outgoing,
            CallRating = CallRating.Good,
            IsArchived = true,
            CallDateTime = DateTime.Now.AddHours(-2)
        };

        // ... добавьте предыдущие записи

        yield return new Call
        {
            Id = 7,
            CallerId = 6,
            ReceiverId = 7,
            CallerPhoneNumber = "111-222-3333",
            ReceiverPhoneNumber = "444-555-6666",
            Subject = "Support Call",
            Description = "Technical assistance",
            StartTime = DateTime.Now.AddHours(-5),
            DurationInSeconds = 1200,
            CallStatus = CallStatus.Incoming,
            CallRating = CallRating.Fair,
            IsArchived = false,
            CallDateTime = DateTime.Now.AddHours(-5)
        };

        yield return new Call
        {
            Id = 8,
            CallerId = 8,
            ReceiverId = 9,
            CallerPhoneNumber = "999-888-7777",
            ReceiverPhoneNumber = "777-888-9999",
            Subject = "Sales Call",
            Description = "Product presentation",
            StartTime = DateTime.Now.AddHours(-10),
            DurationInSeconds = 1500,
            CallStatus = CallStatus.Outgoing,
            CallRating = CallRating.Excellent,
            IsArchived = true,
            CallDateTime = DateTime.Now.AddHours(-10)
        };

        // ... добавьте предыдущие записи

        yield return new Call
        {
            Id = 9,
            CallerId = 10,
            ReceiverId = 11,
            CallerPhoneNumber = "123-987-6543",
            ReceiverPhoneNumber = "555-123-4567",
            Subject = "Feedback Call",
            Description = "Customer satisfaction survey",
            StartTime = DateTime.Now.AddHours(-15),
            DurationInSeconds = 900,
            CallStatus = CallStatus.Incoming,
            CallRating = CallRating.Good,
            IsArchived = false,
            CallDateTime = DateTime.Now.AddHours(-15)
        };

        yield return new Call
        {
            Id = 10,
            CallerId = 12,
            ReceiverId = 13,
            CallerPhoneNumber = "777-555-8888",
            ReceiverPhoneNumber = "222-444-6666",
            Subject = "Marketing Call",
            Description = "Promotion details",
            StartTime = DateTime.Now.AddHours(-20),
            DurationInSeconds = 1800,
            CallStatus = CallStatus.Outgoing,
            CallRating = CallRating.Fair,
            IsArchived = true,
            CallDateTime = DateTime.Now.AddHours(-20)
        };
    }
}