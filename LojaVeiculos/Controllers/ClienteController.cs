using LojaVeiculos.Models;
using LojaVeiculos.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaVeiculos.Controllers
{
    public class ClienteController : Controller
    {


        public List<Cliente> Clientes = new List<Cliente>
        {
            new Cliente {
                Id = 1,
                Nome = "Anderson Frare",
                Cpf = "070.932.119-84",
                DataNascimento = "19/09/1995",
                Email = "andersonfrare@hotmail.com",
                Telefone = "47-999658818",
                Rua = "Dr Arquimedes Dantas",
                Numero = "40",
                Bairro = "Vila Lenzi",
                Cidade = "Jaraguá do Sul", 
                Estado = "SC"
            }
        };

        // GET: Customers
        
        public ActionResult Index()
        {

            var viewModel = new ClienteIndexViewModel()
            {
                Clientes = Clientes
            };

            return View(viewModel);
                
        }
        
        public ActionResult Details(int id)
        {
            if (Clientes.Count < id)
            {
                return HttpNotFound();
            }

            var cliente = Clientes[id - 1];

            return View(cliente);
        }

    }
}
 