using LojaVeiculos.Models;
using LojaVeiculos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVeiculos.Controllers
{
    public class VendaController : Controller
    {

        public List<Venda> Vendas = new List<Venda>
        {
            new Venda {
                Id = 1,
                IdVeiculo = 1,
                IdCliente = 1,
                IdVendedor = 1,
                NotaFiscal = "NF12321RS",
                Data = "10/02/2017",
                Valor = 22250.00
            }
        };


        // GET: Venda
        public ActionResult Index()
        {
            var viewModel = new VendaIndexViewModel()
            {
                Vendas = Vendas
            };

            return View(viewModel);

        }

        public ActionResult Details(int id)
        {
            if (Vendas.Count < id)
            {
                return HttpNotFound();
            }

            var venda = Vendas[id - 1];

            return View(venda);
        }

    }
}