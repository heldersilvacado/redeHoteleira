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
            return View();
        }

        [HttpPost]
        public ActionResult Index(Funcionarios funcionarios)
        {
            Funcionarios f = new Funcionarios();

            return View(funcionarios);
        }

    }
}