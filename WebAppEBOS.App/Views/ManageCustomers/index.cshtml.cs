using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppEBOS.Entity.Entites;
using WebAppEBOS.Entity.Entites;

namespace WebAppEBOS.Views.ManageCustomers;

public class IndexModel : PageModel
{
    // private readonly MyWorldDbContext _myWorldDbContext;
    public IndexModel(/*MyWorldDbContext myWorldDbContext*/)
    {
        // _myWorldDbContext = myWorldDbContext;
    }

    public List<Customer> Customers = new List<Customer>();

    public async Task<IActionResult> OnGetAsync()
    {
        Customers = new List<Customer>()
        {
            new Customer() { Id = 1, Name = "aaa1", Path = "path1", RefAppId = 1 },
            new Customer() { Id = 2, Name = "aaa2", Path = "path2", RefAppId = 1 },
            new Customer() { Id = 3, Name = "aaa3", Path = "path3", RefAppId = 1 },
            new Customer() { Id = 4, Name = "aaa4", Path = "path4", RefAppId = 1 },
            new Customer() { Id = 5, Name = "aaa5", Path = "path5", RefAppId = 1 },
            new Customer() { Id = 6, Name = "aaa6", Path = "path6", RefAppId = 1 },
        };
        return Page();
    }
}