using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebAppEBOS.Data;
using WebAppEBOS.Models;
using WebAppEBOS.Views.ManageCustomers;

namespace WebAppEBOS.Controllers;

// public class ManageCustomersController : Controller
// {
//     private readonly ILogger<ManageCustomersController> _logger;
//     private readonly IUnitOfWork _unitOfWork;
//
//     public ManageCustomersController(ILogger<ManageCustomersController> logger, IUnitOfWork unitOfWork)
//     {
//         _logger = logger;
//         _unitOfWork = unitOfWork;
//     }
//
//     public IActionResult Index()
//     {
//         return View( new IndexModel());
//     }
//
//     [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//     public IActionResult Error()
//     {
//         return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//     }
// }