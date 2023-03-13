using Microsoft.AspNetCore.Mvc;

public class CustomerController: Controller{
     private DataContext _dataContext;
    public CustomerController(DataContext db) => _dataContext = db;
}

