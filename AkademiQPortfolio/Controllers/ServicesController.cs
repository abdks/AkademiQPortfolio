using AkademiQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using PortfolyoDbContext;
using System.Diagnostics;

namespace AkademiQPortfolio.Controllers;

public class ServicesController : Controller
{
    private readonly portfolyodbContext _portfolyodbContext;

    public ServicesController(portfolyodbContext portfolyodbContext)
    {
        _portfolyodbContext = portfolyodbContext;
    }

    //DI DEPENDENCY INJECTİON BU KAVRAM İLE İLGİLİ EN AZ BİR  MAKALE OKUNACAK MEDİUM'DAN VE YAPAY ZEKAYA BU KAVRAM SORULACAK. Bana whatsapp üzerinden bunu göndereceksiniz.

    // asp.net DI --> farklı dillerde de bakabilirsiniz.


    public IActionResult Index()
    {
        var values = _portfolyodbContext.Services.ToList();
        return View(values);
    }


    [HttpGet]
    public IActionResult CreateServices()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CreateServices(Service service)
    {
        _portfolyodbContext.Services.Add(service);
        _portfolyodbContext.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult UpdateServices(int id) // id = 6    a tagı ->> href:/UpdateServices/6
    {
        var value = _portfolyodbContext.Services.Find(id);
        return View(value);
    }

    [HttpPost] 
    public IActionResult UpdateServices(Service service)
    {
        _portfolyodbContext.Services.Update(service);
        _portfolyodbContext.SaveChanges();
        return RedirectToAction("Index");
    }
    public IActionResult DeleteServices(int id) //6
    {
        var value = _portfolyodbContext.Services.Find(id);
        _portfolyodbContext.Services.Remove(value);

        _portfolyodbContext.SaveChanges();
        return RedirectToAction("Index");
    }



}
