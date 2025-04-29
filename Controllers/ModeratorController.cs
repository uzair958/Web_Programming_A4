using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace wp_A4.Controllers
{
    [Authorize(Roles = "Admin,Moderator")]
    public class ModeratorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ManageContent()
        {
            return View();
        }

        public IActionResult ReviewReports()
        {
            return View();
        }
    }
}
