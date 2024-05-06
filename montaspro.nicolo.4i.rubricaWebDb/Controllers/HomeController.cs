using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using montaspro.nicolo._4i.rubricaWebDb.Models;

namespace montaspro.nicolo._4i.rubricaWebDb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
     private readonly dbContext _dbContext;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _dbContext = new();
    }

    public IActionResult Index(){
        // Passa il db alla view
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet]
      public IActionResult Persone()
    {
        
        return View(_dbContext);
    }
    
    [HttpPost]
    public IActionResult Persone (Persona p )
    {
        
        _dbContext.Persone.Add(p);
        _dbContext.SaveChanges();

        return View();
    }

     [HttpGet]
     public IActionResult AddPersona()
    {
        
        return View();
    }

       [HttpPost]
    public IActionResult AddPersona (Persona p )
    {
        
        _dbContext.Persone.Add(p);
        _dbContext.SaveChanges();

        return View("Persone", _dbContext);
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
