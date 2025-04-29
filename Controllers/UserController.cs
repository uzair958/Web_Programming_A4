using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using wp_A4.Models;

namespace wp_A4.Controllers
{
    [Authorize(Roles = "Admin,Moderator,User")]
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            return View(user);
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
