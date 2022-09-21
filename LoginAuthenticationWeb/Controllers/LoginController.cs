using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LoginAuthenticationWeb.Controllers
{
    public class LoginController : Controller
    {
        string Baseurl = "https://localhost:44392/";
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(User parametre)
        {
            using (var httpClient = new HttpClient())
            {
                StringContent stringContent = new StringContent(JsonConvert.SerializeObject(parametre), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("https://localhost:44392/api/Login", stringContent))
                {
                    string token = await response.Content.ReadAsStringAsync();
                    if (token == "Invalid credentials")
                    {
                        ViewBag.Message = "Incorrent UserId or Password!";
                        return Redirect("~/Home/Index");
                    }
                    HttpContext.Session.SetString("JWToken", token);
                }
                return Redirect("~/User/Index");
            }
        }
      
        
        public IActionResult Logoff()
        {
            HttpContext.Session.Clear();
            return Redirect("~/User/Index");
        }

    }
}
