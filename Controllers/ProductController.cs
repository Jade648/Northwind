using Microsoft.AspNetCore.Mvc;
using System.Linq;
public class ProductController : Controller
{

    private DataContext _dataContext;
  public ProductController(DataContext db) => _dataContext = db;

public IActionResult Category() => View(_dataContext.Product.OrderBy(p => p.CategoryName));

}

