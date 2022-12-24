using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcSessionState.Models;

namespace MvcSessionState.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    //private SessionEntities _sessionEntities;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //HttpContext.Session.SetString("Selection", "Bob");
        return View();
    }
    [HttpPost]
    public IActionResult Index([FromBody] IndexPostDTO indexPostDto)
    {
        HttpContext.Session.SetString("Selection", indexPostDto.Selection);
        // _sessionEntities.StepTwoViewModel = new StepTwoViewModel { Selection = selection };
        return RedirectToAction("StepTwo");
    }

    public IActionResult StepTwo()
    {
        return View(new StepTwoViewModel
        {
            Selection = HttpContext.Session.GetString("Selection")
        });
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
