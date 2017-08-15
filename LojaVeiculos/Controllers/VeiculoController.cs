using LojaVeiculos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVeiculos.Controllers
{
    public class VeiculoController : Controller
    {
        // GET: Veiculo
        public ActionResult Index()
        {
            var veiculo = new Veiculo
            {
                Id = 1,
                Marca = "Chevrolet",
                Ano = 2012,
                Modelo = "Corsa"
            };
            return View(veiculo);
        }
    }
}