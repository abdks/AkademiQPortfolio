using Microsoft.AspNetCore.Mvc;
using PortfolyoDbContext;

namespace AkademiQPortfolio.ViewComponents;

public class ExperinceViewComponent : ViewComponent
{
    private readonly portfolyodbContext _portfolyodbContext;

    public ExperinceViewComponent(portfolyodbContext portfolyodbContext)
    {
        _portfolyodbContext = portfolyodbContext;
    }

    public IViewComponentResult Invoke()
    {
        var values = _portfolyodbContext.Services.ToList();
        return View(values);
    }
}
