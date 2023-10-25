using Microsoft.AspNetCore.Mvc;

namespace EncuestaDojo.Controllers;

public class PrincipalController : Controller {
    [HttpGet("")]
    public IActionResult Index(){
        ViewBag.Locations = new List<string> { "Viña del mar", "Santiago", "Coquimbo" };
        ViewBag.Languages = new List<string> { "C#", "Python" };
        return View("Index");
    }

    [HttpPost ("result")]
    public IActionResult Result(string name, string location, string languages, string comment){
        ViewBag.Name = name; 
        ViewBag.Location = location;
        ViewBag.Languages = languages;
        ViewBag.Comment = comment;

        return View("Result");

    }
}
