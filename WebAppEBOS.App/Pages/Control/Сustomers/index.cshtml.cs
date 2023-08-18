using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppEBOS.Entity;
using WebAppEBOS.Entity.Entites;
using WebAppEBOS.Entity.Repositories;
using WebAppEBOS.Entity.Repositories.Interfaces;
using WebAppEBOS.Entity.Specifications;
using WebAppEBOS.Entity;
using WebAppEBOS.Entity.Entites;
using WebAppEBOS.Entity.Specifications;

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

    public IReadOnlyCollection<Customer> AllCustomers = new List<Customer>();

    public async Task<IActionResult> OnGetAsync(CancellationToken cancellationToken)
    {
        var query = new AllCustomersSpecification();
        var allCustomers = await _repository.FetchAsync(query, cancellationToken);

        var b = await _repository.GetAsync(1, cancellationToken);

        AllCustomers = allCustomers;
        return Page();
    }
}