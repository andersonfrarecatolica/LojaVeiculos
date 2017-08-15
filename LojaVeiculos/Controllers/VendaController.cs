using LojaVeiculos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVeiculos.Controllers
{
    public class VendaController : Controller
    {
        // GET: Venda
        public ActionResult Index()
        {
            var venda = new Venda();
            return View(venda);
        }
    }
}