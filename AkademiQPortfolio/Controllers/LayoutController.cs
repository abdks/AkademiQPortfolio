using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.Controllers;

public class LayoutController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}


//Wwwroot/css/site.css   

//Wwwroot/css/site.css

//Layout hiçbir zaman tek başına çalışamaz neden -> renderBody() -> bizim sonradan oluşturacağımız içerik sayfalarını buranın içine atıyor

// yetenekler sayfasında ki her şey 