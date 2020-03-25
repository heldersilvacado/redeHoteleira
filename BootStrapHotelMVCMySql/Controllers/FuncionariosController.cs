using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using BootStrapHotelMVCMySql.Models;


namespace BootStrapHotelMVCMySql.Controllers
{
    public class FuncionariosController : Controller
    {
        // GET: Funcionarios
        [HttpGet]
        public ActionResult Index()
        {
            Funcionarios funcionarios = new Funcionarios();

            return View(funcionarios);
        }

        [HttpPost]
        public ActionResult Index(Funcionarios funcionarios)
        {
            Funcionarios f = new Funcionarios();
            string nome = Request.Form["Nome"];
            funcionarios.Nome = nome.ToUpper().Trim();

            string cargo = Request.Form["Cargo"];
            funcionarios.Cargo = cargo.ToUpper().Trim();

            string email = Request.Form["Email"];
            funcionarios.Email = email.ToUpper().Trim();

            string phone = Request.Form["Phone"];
            funcionarios.Phone = phone.Trim();

            string foto = Request.Form["Foto"];
            funcionarios.Foto = foto.Trim();
            return View(funcionarios);
        }

    }
}