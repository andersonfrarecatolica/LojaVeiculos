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
                Tipo = "Carro",
                Marca = "Chevrolet",
                Modelo = "Corsa",
                Ano = 2012,
                Placa = "MIT 1236",
                Cor = "Cinza",
                Descricao = "Corsa completo, 4 portas",
                Valor = 2250.00
                
            };
            return View(veiculo);
        }
        

    }
}