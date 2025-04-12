using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace FirstWebMVC.Controllers {
    public class PersonController : Controller {
        public IActionResult Index(){
            return View();
        }
        public string Chaoban() {
            return "Tôi có thể giúp gì cho bạn?";
        }
    }
}
