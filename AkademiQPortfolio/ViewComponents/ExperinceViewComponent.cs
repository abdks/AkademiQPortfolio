using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.ViewComponents;

public class ExperinceViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
