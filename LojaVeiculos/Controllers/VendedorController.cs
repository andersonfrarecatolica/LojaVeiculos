using LojaVeiculos.Models;
using LojaVeiculos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVeiculos.Controllers
{
    public class VendedorController : Controller
    {

        public List<Vendedor> Vendedores = new List<Vendedor>
        {
            new Vendedor {
                Id = 1,
                Nome = "Rodrigo",
                Cpf = "123.532.412-23",
                Telefone = "47-999887654",
                Email = "rodrigo@teste.com.br"
            }
        };

   
        // GET: Vendedor
        public ActionResult Index()
        {
            var viewModel = new VendedorIndexViewModel()
            {
                Vendedores = Vendedores
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            if (Vendedores.Count < id)
            {
                return HttpNotFound();
            }

            var vendedor = Vendedores[id - 1];

            return View(vendedor);
        }

    }


}