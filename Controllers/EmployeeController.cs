using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace FirstWebMVC.Controllers { 
    public class EmployeeController : Controller {
        public IActionResult Index() {
            return View();
        }
        public string Goodluck() {
            return "Chúc bạn may mắn!";
        }
    }
} 