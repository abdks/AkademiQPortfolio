using Microsoft.AspNetCore.Mvc;

namespace AkademiQPortfolio.ViewComponents;

public class SkillViewComponent : ViewComponent
{

    public IViewComponentResult Invoke()
    {
        return View(); 
    }


}


