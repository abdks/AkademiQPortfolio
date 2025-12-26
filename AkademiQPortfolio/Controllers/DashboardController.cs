using Microsoft.AspNetCore.Mvc;
using PortfolyoDbContext;

namespace AkademiQPortfolio.Controllers;

public class DashboardController : Controller
{
    private readonly portfolyodbContext _portfolyoDbContext;

    public DashboardController(portfolyodbContext portfolyoDbContext)
    {
        _portfolyoDbContext = portfolyoDbContext;
    }

    public IActionResult Index()
    {
        ViewBag.FirstProject = _portfolyoDbContext.ProjectsTables.FirstOrDefault().ProjectName;
        ViewBag.LastProject = _portfolyoDbContext.ProjectsTables.OrderByDescending(x => x.ProjectId).FirstOrDefault().ProjectName;

        ViewBag.TotalServicesCount = _portfolyoDbContext.Services.Count();  

        ViewBag.FirstCategory = _portfolyoDbContext.CategoriesTables.FirstOrDefault().CategoryName;

        // Task

        // 1-) En çok projeye sahip kategori

        // 2-) Yenekler tablosunda en yüksek levelli yetenek

        // 3 Tanesini de siz belirleyin.

        return View();
    }
}
