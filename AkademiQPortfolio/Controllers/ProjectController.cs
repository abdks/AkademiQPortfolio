using AkademiQPortfolio.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PortfolyoDbContext;
using System.Diagnostics.Metrics;

namespace AkademiQPortfolio.Controllers;

public class ProjectController : Controller
{
    private readonly portfolyodbContext _portfolyodbContext;

    public ProjectController(portfolyodbContext portfolyodbContext)
    {
        _portfolyodbContext = portfolyodbContext;
    }

    public IActionResult Index()
    {
        // Include = Projeleri çekiyorum ama kategorisi de gelsin istiyorum.
        // Lambda (=>) → Kısa fonksiyon
        // Lambda --> İlgili projenin kategorisini diğer tablodan çekmek için kullanıyoruz

        //Garson örneği 🍽️

        //Sen: “Bana projeleri getir”

        //Garson: “Yanında ne olsun ?”

        //Sen: “Kategorisi de olsun”

        var value = _portfolyodbContext.ProjectsTables.Include(x => x.Category).ToList();

        return View(value);
    }

    //Dropdown --> 2 unsuru var birincisi value ikincisi gözüken kısım 

    //Kullanıcı cyberSecurity eklediğini düşünürken arka tarafta biz CyberSecurity'inin kategori ID sini ekleyeceğiz

    //Select 

    //SelectListItem

    [HttpGet]
    public IActionResult ProjectCreate()
    {
        //viewbag categories ----> her kategori için bir listeye veri ekleyecek bu listenin içerisinde bir gözüken kısım değeri ikinci olarak ise value değeri olacak.
        //bunları dropdownda kullanacağız

        // ViewBag.Categories 

        // liste[0] -> Text = web -- value = 1
        // liste[1] -> Text = Mobile value = 2

       




        ViewBag.Categories = _portfolyodbContext.CategoriesTables.Select(
            x => new SelectListItem
            {
                Text = x.CategoryName,
                Value = x.CategoryId.ToString()
            }
            );
        return View();
    }

    [HttpPost]
    public IActionResult ProjectCreate(ProjectsTable projectsTable)
    {
        _portfolyodbContext.ProjectsTables.Add(projectsTable);
        _portfolyodbContext.SaveChanges();
        return RedirectToAction("Index");
    }


    //Güncelleme kısımı sizde

}
