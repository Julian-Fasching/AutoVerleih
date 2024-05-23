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
}