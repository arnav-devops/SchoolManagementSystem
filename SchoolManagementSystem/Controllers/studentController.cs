using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementSystem.Controllers
{
    public class studentController : Controller
    {
        public IActionResult StudentList()
        {
            return View();
        }
    }
}
