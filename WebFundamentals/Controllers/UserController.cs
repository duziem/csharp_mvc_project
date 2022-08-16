using Microsoft.AspNetCore.Mvc;
using WebFundamentals.Models;
using WebFundamentals.Service;

namespace WebFundamentals.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult AddUser(UserModel um)
        {
            /*if (!ModelState.IsValid)*/
            new UserService().AddUser(um);
            return View();
        }


    }
}
