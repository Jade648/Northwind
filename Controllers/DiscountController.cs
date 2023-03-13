using Microsoft.AspNetCore.Mvc;
public class DiscountController : Controller
{
  private DataContext _dataContext;

  public DiscountController(DataContext db)=>_dataContext = db;

  public ActionResult Index() => View(_dataContext.Discounts.Where(d => d.StartTime <= DateTime.Now && d.EndTime > DateTime.Now).Take(3));

}
