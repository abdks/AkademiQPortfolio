using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.ViewComponents;

public class AdminSideBarViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
