using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BootStrapHotelMVCMySql.Models;

namespace BootStrapHotelMVCMySql.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Funcionarios funcionarios = new Funcionarios();
            return View(funcionarios);
        }
    }
}