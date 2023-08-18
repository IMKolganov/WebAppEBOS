using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppEBOS.Entity;
using WebAppEBOS.Entity.Entites;
using WebAppEBOS.Entity.Repositories.Interfaces;
using WebAppEBOS.Entity.Specifications;

namespace WebAppEBOS.Pages.Control.Calls;

public class IndexModel : PageModel
{

    private readonly IUnitOfWork _unitOfWork;
    private readonly IReadOnlyRepository<int, Call> _repository;

    public IndexModel(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        _repository = _unitOfWork.Repository<int, Call>();
    }

    public IReadOnlyCollection<Call> AllCalls = new List<Call>();

    public async Task<IActionResult> OnGetAsync(CancellationToken cancellationToken)
    {
        var query = new AllCallsSpecification();
        var allCalls = await _repository.FetchAsync(query, cancellationToken);

        var b = await _repository.GetAsync(1, cancellationToken);

        AllCalls = allCalls;
        return Page();
    }
}