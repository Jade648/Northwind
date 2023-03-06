using Microsoft.AspNetCore.Mvc;
using System.Linq;
public class ProductController : Category
{

    private DataContext _dataContext;
  public ProductController(DataContext db) => _dataContext = db;

public IActionResult Index() => View(_dataContext.Northwind.OrderBy(c => c.Name));

}

