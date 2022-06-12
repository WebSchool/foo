using Frontend.Data;
using Microsoft.AspNetCore.Mvc;

namespace Frontend.Controllers;

public class ArticleController : Controller
{
    FrontendDbContext _dbContext;

    public ArticleController(FrontendDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public IActionResult Index()
    {
        List<Article> articles = _dbContext.Articles.ToList();

        return View(articles);
    }
}
