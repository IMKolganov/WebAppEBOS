using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAppEBOS.Models;

namespace WebAppEBOS.Controllers;

public class ManageCustomersController : Controller
{
    private readonly ILogger<ManageCustomersController> _logger;

    public ManageCustomersController(ILogger<ManageCustomersController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}