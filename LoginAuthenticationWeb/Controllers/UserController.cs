using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace LoginAuthenticationWeb.Controllers
{
    public class UserController : Controller
    {
        string Baseurl = "https://localhost:44392/";
        public async Task<IActionResult> Index()
        {
            var accessToken = HttpContext.Session.GetString("JWToken");
            if (accessToken == "User not found") { return Redirect("~/Login/"); }
            List<User> CliInfo = new List<User>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                //client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                HttpResponseMessage Res = await client.GetAsync("api/User");
                if (Res.IsSuccessStatusCode)
                {
                    var CliResponse = Res.Content.ReadAsStringAsync().Result;

                    CliInfo = JsonConvert.DeserializeObject<List<User>>(CliResponse);
                }
                //returning the employee list to view
                if (accessToken != null)
                {
                    return View(CliInfo);
                }
                return Redirect("~/Login/");

            }
        }
        [HttpGet]
        public IActionResult Create()
        {
            var accessToken = HttpContext.Session.GetString("JWToken");
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            if (accessToken != null)
            {
                return View();
            }
            return Redirect("~/Login/");
        }
        [HttpPost]
        public IActionResult Create(User parametre)
        {

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                //client.DefaultRequestHeaders.Clear();
                string data = JsonConvert.SerializeObject(parametre);
                StringContent content = new StringContent(data, Encoding.UTF8, "application/json");

                HttpResponseMessage response = client.PostAsync(client.BaseAddress + "api/User/", content).Result;
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }

                return View();
            }
        }
        public IActionResult Details(int id)
        {
            using (var client = new HttpClient())
            {
                var accessToken = HttpContext.Session.GetString("JWToken");


                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                User userdata = new User();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync(client.BaseAddress + "api/User/" + id).Result;
                if (response.IsSuccessStatusCode)
                {
                    string data = response.Content.ReadAsStringAsync().Result;
                    userdata = JsonConvert.DeserializeObject<User>(data);
                }
                if (accessToken != null)
                {
                    return View(userdata);
                }
                return null;
            }
        }
        public IActionResult Edit(User parametre)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                var response = client.PutAsJsonAsync(client.BaseAddress + "api/User/", parametre).Result;
                if (response.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
                return View("Details", parametre.Id);
            }
        }
        public ActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage result = client.DeleteAsync(client.BaseAddress + "api/User/?id=" + id).Result;

                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");
        }
    }
}
