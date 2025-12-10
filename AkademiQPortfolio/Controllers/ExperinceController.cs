using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.Controllers;

public class ExperinceController : Controller
{
    //verileri burada listeleyeceğiz
    public IActionResult Index()
    {
        return View();
    }

    //Create metotu için get fonksiyonu
    public IActionResult CreateExperince()
    {
        return View();
    }
    //güncelleme için get fonksiyonu
    //HttpGet HTTPPOST


    //Burası Get Fonksiyonu Update için
    public IActionResult UpdateExperince()
    {
        return View();
    }

    //[HttpPost]
    //public IActionResult UpdateExperince()
    //{
    //    //buraya veri tabanına kaydetmek için gerekli kodlar gelecek
    //}

    public IActionResult DeleteExperince()
    {
        //Burası değişecek
        return View();
    }
}
