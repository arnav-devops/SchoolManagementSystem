using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.Models;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManagementSystem.Controllers
{
    public class LoginController : Controller
    {
        private readonly StudentContext _Db;
        public LoginController( StudentContext Db)
        {
            _Db = Db;
        }

        public IActionResult Login()
        {
            return View();
        }

        public List<LoginModel> PutValue()
        {
            var users = new List<LoginModel>
            {
                new LoginModel{id=1,UserName="teams@creativebuffer.com",password="P@ssword789"}

            };
            return users;
        }
        [HttpPost]
        public IActionResult verify(LoginModel user)
        {
            var u = PutValue();

            var ue = u.Where(u=>u.UserName == user.UserName);
            var up = ue.Where(p => p.password == user.password);
            if(up.Count() == 1) {
                ViewBag.message = "Login successful";
                return RedirectToAction("LoginSuccess");
            
            }
            else
            {
                ViewBag.message = "Login failed";
                return View("Login falied");
            }
        }

        public IActionResult LoginSuccess()
        {
            var stdlist = _Db.student.ToList();
            return View(stdlist);
        }

        public IActionResult Create()
        {
Student student = new Student();    
            return PartialView("_StudentPartialView",student);
        }
    }
}
