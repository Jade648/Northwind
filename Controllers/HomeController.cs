using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    // this controller depends on the NorthwindRepository
    private DataContext _dataContext;
    public HomeController(DataContext db) => _dataContext = db;
    public ActionResult Index() => View(_dataContext.Discounts);
}