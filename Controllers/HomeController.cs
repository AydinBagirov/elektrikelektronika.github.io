using Microsoft.AspNetCore.Mvc;

namespace ElektronikaWebLayihe.Controllers;

public class HomeController : Controller
{
    public IActionResult Home()
    {
        return View();
    }

    [HttpGet("/Projects")]
    public IActionResult Projects()
    {
        return View();
    }
    
    [HttpGet("/About")]
    public IActionResult About()
    {
        return View();
    }
    

    [HttpGet("/Contact")]
    public IActionResult Contact()
    {
        return View();
    }
    
    [HttpGet("/ProjectAbout")]
    public IActionResult ProjectAbout()
    {
        return View();
    }
}