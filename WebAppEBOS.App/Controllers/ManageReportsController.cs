using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAppEBOS.Models;

namespace WebAppEBOS.Controllers;

public class ManageReportsController : Controller
{
    private readonly ILogger<ManageReportsController> _logger;

    public ManageReportsController(ILogger<ManageReportsController> logger)
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