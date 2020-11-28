using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LifeShare.Models;
using Microsoft.AspNetCore.Mvc;

namespace LifeShare.Controllers
{
    public class LoginController : Controller
    {

        Login AdminModel = new Login();

        [HttpPost]
        public IActionResult Autenticar(Login Admin)
        {
            if(Admin.Email != null && Admin.Senha != null)
            {
                if(Admin.Email.Equals(AdminModel.Email) && Admin.Senha.Equals(AdminModel.Senha))
                {
                    return Redirect("/Empresa/Index");
                }
            }
                TempData["msg"] = "Login ou senha incorretos!";
                return View();
        }

       [HttpGet]
        public IActionResult Autenticar()
        {
            return View();
        }

    
    }
}