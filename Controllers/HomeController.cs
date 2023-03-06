using Microsoft.AspNetCore.Mvc;
using System.Linq;

  // this controller depends on the BloggingRepository
  
public class HomeController : Controller
{
  public IActionResult Index() => View();
}
