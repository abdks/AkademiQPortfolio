using Microsoft.AspNetCore.Mvc;
//Kütüphaneleri çağırıyor

namespace AkademiQPortfolio.Controllers;

public class DefaultController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
