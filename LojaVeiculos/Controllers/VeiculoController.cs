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

        // GET: Veiculo
        public ActionResult Index()
        {
            var viewModel = new VeiculoIndexViewModel()
            {
                Veiculos = Veiculos
            };

            return View(viewModel);

        }


        public ActionResult Details(int id)
        {
            if (Veiculos.Count < id)
            {
                return HttpNotFound();
            }

            var veiculo = Veiculos[id - 1];

            return View(veiculo);
        }

    }
}