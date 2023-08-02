using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppEBOS.Data;
using WebAppEBOS.Data.Entites;
using WebAppEBOS.Data.Repositories;
using WebAppEBOS.Data.Repositories.Interfaces;

namespace WebAppEBOS.Pages.Cakes;

public class IndexModel : PageModel
{

    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadOnlyRepository<int, Customer> _repository;

    public IndexModel(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        _repository = _unitOfWork.Repository<int, Customer>();
    }

    public List<Customer> AllCustomers = new List<Customer>();

    public async Task<IActionResult> OnGetAsync(CancellationToken cancellationToken)
    {
        
        var b = await _repository.GetAsync(1, cancellationToken);
        
        AllCustomers = new List<Customer>()
        {
            new Customer() { Id = 1, Name = "aaa1", Path = "path1", RefAppId = 1 },
            new Customer() { Id = 2, Name = "aaa2", Path = "path2", RefAppId = 1 },
            new Customer() { Id = 3, Name = "aaa3", Path = "path3", RefAppId = 1 },
            new Customer() { Id = 4, Name = "aaa4", Path = "path4", RefAppId = 1 },
            new Customer() { Id = 5, Name = "aaa5", Path = "path5", RefAppId = 1 },
            new Customer() { Id = 6, Name = "aaa6", Path = "path6", RefAppId = 1 },
            b,
        };
        return Page();
    }
}