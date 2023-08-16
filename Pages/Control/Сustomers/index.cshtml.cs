using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppEBOS.Data;
using WebAppEBOS.Data.Entites;
using WebAppEBOS.Data.Repositories;
using WebAppEBOS.Data.Repositories.Interfaces;
using WebAppEBOS.Data.Specifications;

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