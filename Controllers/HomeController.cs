using Microsoft.AspNetCore.Mvc;
using System.Linq;

public class HomeController : Controller
{
  // this controller depends on the BloggingRepository
  private DataContext _dataContext;
  public HomeController(DataContext db) => _dataContext = db;

  public IActionResult Index() => View();
}

public class ProductController : Category
{
  // this controller depends on the BloggingRepository
  private DataContext _dataContext;
  public ProductController(DataContext db) => _dataContext = db;

  public IActionResult Index() => View(_dataContext.Product.OrderBy(p => p.CategoryName));

    private IActionResult View(IOrderedQueryable<Category> categories)
    {
        throw new NotImplementedException();
    }
}
