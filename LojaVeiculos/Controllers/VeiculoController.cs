using LojaVeiculos.Models;
using LojaVeiculos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVeiculos.Controllers
{
    public class VeiculoController : Controller
    {
        private ApplicationDbContext _context;

        public List<Veiculo> Veiculos = new List<Veiculo>
        {
            new Veiculo {
                Id = 1,
                Tipo = "Carro",
                Marca = "Chevrolet",
                Modelo = "Corsa",
                Ano = 2012,
                Placa = "MIT 1236",
                Cor = "Cinza",
                Descricao = "Corsa completo, 4 portas",
                Valor = 2250.00
            }
        };

        public VeiculoController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Veiculo
        public ActionResult Index()
        {
            var veiculos = _context.Veiculos.ToList();

            return View(veiculos);

        }


        public ActionResult Details(int id)
        {

            var veiculo = _context.Veiculos.ToList();

            if (veiculo == null)
            {
                return HttpNotFound();
            }

            return View(veiculo);
        }

    }
}