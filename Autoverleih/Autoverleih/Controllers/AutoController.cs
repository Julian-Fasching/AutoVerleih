using Autoverleih.Models;
using Autoverleih.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Autoverleih.Controllers;

public class AutoController : Controller
{
    // GET
    public IActionResult Index()
    {        AutoRepository repo = new AutoRepository();
        List<Auto> myAutos = repo.GetallAutos();
        
        return View(myAutos);
        
    }

    public IActionResult New()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SaveAuto(Auto auto)
    {
        AutoRepository repo = new AutoRepository();
        
        repo.CreateAuto(auto);
        
        return Redirect("/Auto");
    }
        
}