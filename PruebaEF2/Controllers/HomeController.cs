using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaEF2.Models.Clases;
using PruebaEF2.Models.Clases.ClasesModelo;
using PruebaEF2.Models.Clases.OperacionesEF;

namespace PruebaEF2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()//login con acceso a datos con ef core
        {
            return View();
        }

        public IActionResult LoginDapper()//login con acceso a datos con dapper
        {
            return View();
        }

        [HttpPost]
        public JsonResult ExisteUsuario(string username,string password)
        {
            string res = "false";
            
            OperacionesUsuarios opusu = new OperacionesUsuarios();
            foreach (Usuarios user in opusu.TraerTodo())
            {
                if (username==user.nombreUsuario && password==user.password)
                {
                    return Json("true");
                }
            }
            return Json(res);
        }

        [HttpPost]
        public JsonResult ExisteUsuarioDapper(string username, string password)
        {
            string res = "false";

            UserProvider users = new UserProvider();
            if (users.ExisteUsuario(username,password))
            {
                res = "true";
            }
            return Json(res);
        }

    }
}