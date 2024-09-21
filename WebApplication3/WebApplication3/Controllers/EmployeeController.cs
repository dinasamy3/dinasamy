using Microsoft.AspNetCore.Mvc;
using WebApplication3.Controllers.DAL.DB;

namespace WebApplication3.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext Db =new ApplicationDbContext();
        public IActionResult Index()
        {
            var  Result =Db.Employees.ToList();
           // ViewBag.GetAllEmployee=Result;
            return View(Result);
        }
    }
}
