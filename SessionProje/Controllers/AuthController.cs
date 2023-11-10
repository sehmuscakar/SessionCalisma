using Microsoft.AspNetCore.Mvc;
using SessionProje.Extensions;
using SessionProje.Models;

namespace SessionProje.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost] 
        public IActionResult Login(LoginModel loginModel)
        {
            if (loginModel.Email=="sehmus@gmail.com"&& loginModel.Password=="1234")
            {
                //session işlemi
                //   HttpContext.Session.SetString("UserSession",loginModel.Email);//1 inci paremtere key dir ikincisi ise value dir bunlar bu isimleile oturum oluşturuyor 
                HttpContext.Session.Set<LoginModel>("UserSession", loginModel);
                
                return RedirectToAction ("Index", "Home");
            }
            return View();
        }
    }
}
